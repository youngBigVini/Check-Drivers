using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Drawing;


namespace CheckDrivers
{
    public partial class initial : Form
    {
   
        public void config()
        {
                        
            
            string newDirectoryPath = @"C:\Check Drivers";

            if (!Directory.Exists(newDirectoryPath))
            {
                
                Directory.CreateDirectory(newDirectoryPath);
            }

            string filePath = @"C:\Check Drivers\config.cfg";
            if (!File.Exists(filePath))
            {
                string[] configLines = {
                    "[DRIVERS IMAGES DIRECTORY]",
                    "; driver name  = directory",
                    "",
                    "[DRIVERS AND VERSIONS]",
                    "; driver name = driver version"
                };
                File.WriteAllLines(filePath, configLines);
            }
        }
        private List<string> msgDriversOk = new List<string>();
        private List<string> msgDriversNok = new List<string>();
        public initial()
        {
            InitializeComponent();           
            buttonOkBoard.Visible = false;
            consultDataBase();
            config();
        }

        
        private Dictionary<string, string> ReadDriversFromCfg(string filePath)
        {
            var drivers = new Dictionary<string, string>();

            if (File.Exists(filePath))
            {
                bool isInDriversSection = false;
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    if (line.Trim() == "[DRIVERS IMAGES DIRECTORY]")
                    {
                        isInDriversSection = true;
                        continue;
                    }
                    if (isInDriversSection)
                    {
                        if (line.StartsWith("["))
                        {
                            break;
                        }
                        if (line.Contains("="))
                        {
                            var parts = line.Split(new[] { '=' }, 2);
                            if (parts.Length == 2)
                            {
                                var driverName = parts[0].Trim();
                                var driverImageDirectory = parts[1].Trim();
                                drivers[driverName] = driverImageDirectory;
                            }
                        }
                    }
                    
                }
            }

            return drivers;
        }




        private void comboBoxBoard_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBoxBoard.SelectedItem.ToString();
            string[] parts = selectedItem.Split(new[] { ", " }, StringSplitOptions.None);
            string driver = parts[0].Split(':')[1].Trim();
            string version = parts[1].Split(':')[1].Trim();
            Dictionary<string, string> drivers = new Dictionary<string, string>();
            drivers[driver] = version;

            
            string filePath = @"C:\Check Drivers\config.cfg";
            if (File.Exists(filePath))
            {
                try
                {
                    string selectedDriver = driver;
                    
                    var driversImages = ExtractDriversImages(filePath);

                    
                   
                    foreach (var entry in driversImages)
                    {
                        Console.WriteLine($"Driver: {entry.Key}, Diretório: {entry.Value}");
                    }

                    
                    bool driverExists = driversImages.ContainsKey(selectedDriver);
                    
                    if (selectedDriver != null && driverExists)
                    {
                        
                        pictureBoxBoard.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBoxBoard.Image = Image.FromFile(driversImages[selectedDriver]);
                        buttonOkBoard.Visible = true;                       
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            checkDrivers(drivers);
            drivers.Clear();
        }
        public void consultDataBase()
        {
            string filePath = @"C:\Check Drivers\config.cfg";
            var driversVersions = ExtractDriversVersions(filePath);

            foreach (var entry in driversVersions)
            {
                comboBoxBoard.Items.Add($"Driver: {entry.Key}, Versão: {entry.Value}");
            }


        }
        static Dictionary<string, string> ExtractDriversVersions(string filePath)
        {
            var driversVersions = new Dictionary<string, string>();
            string[] lines = File.ReadAllLines(filePath);
            bool isInDriversSection = false;

            foreach (string line in lines)
            {
                if (line.Trim() == "[DRIVERS AND VERSIONS]")
                {
                    isInDriversSection = true;
                    continue;
                }

                if (isInDriversSection)
                {
                    if (line.StartsWith("["))
                    {
                        break;
                    }
                    if (line.StartsWith(";"))
                    {
                        continue;
                    }


                    if (line.Contains("="))
                    {
                        string[] parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            string driver = parts[0].Trim();
                            string version = parts[1].Trim();
                            driversVersions[driver] = version;
                        }
                    }
                }
            }

            return driversVersions;
        }
        static Dictionary<string, string> ExtractDriversImages(string filePath)
        {
            var driversImages = new Dictionary<string, string>();
            string[] lines = File.ReadAllLines(filePath);
            bool isInDriversSection = false;

            foreach (string line in lines)
            {
                if (line.Trim() == "[DRIVERS IMAGES DIRECTORY]")
                {
                    isInDriversSection = true;
                    continue;
                }

                if (isInDriversSection)
                {
                    if (line.StartsWith("["))
                    {
                        break;
                    }
                    if (line.StartsWith(";")) 
                    {
                        continue;
                    }

                        if (line.Contains("="))
                    {
                        string[] parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            string driver = parts[0].Trim();
                            string directory = parts[1].Trim();
                            driversImages[driver] = directory;
                        }
                    }
                }
            }

            return driversImages;
        }
        public void checkDrivers(Dictionary<string, string> Drivers)
        {
            msgDriversOk.Clear();
            msgDriversNok.Clear();
            try
            {
                
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPSignedDriver");

               
                foreach (ManagementObject driver in searcher.Get())
                {
                    if (driver["Description"] != null && driver["DriverVersion"] != null)
                    {
                        foreach (var Cdriver in Drivers)
                        {
                            if (driver["Description"].ToString() == Cdriver.Key)
                            {
                                if (driver["DriverVersion"].ToString() == Cdriver.Value)
                                {
                                    msgDriversOk.Add($"Driver: {Cdriver.Key}, Version: {Cdriver.Value}, OK.");
                                }
                                else
                                {
                                    msgDriversNok.Add($"Driver: {Cdriver.Key}, Version: {driver["DriverVersion"].ToString()}, not OK. Please change the driver version to the correct version.");
                                }
                            }
                        }
                    }
                }

                
                if (msgDriversOk.Count > 0)
                {
                    MessageBox.Show(string.Join(Environment.NewLine, msgDriversOk), "Driver OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (msgDriversNok.Count > 0)
                {
                    MessageBox.Show(string.Join(Environment.NewLine, msgDriversNok), "Driver Not OK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if ((msgDriversOk.Count == 0) && (msgDriversNok.Count == 0))
                {
                    MessageBox.Show("Driver not found!", "Check Drivers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void initial_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonOkBoard_Click(object sender, EventArgs e)
        {
            pictureBoxBoard.Image = null;
            buttonOkBoard.Visible = false;
        }
    }
}

