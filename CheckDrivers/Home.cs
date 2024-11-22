using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace CheckDriver
{
    public partial class Home : Form
    {
        /*
        private List<string> msgDriversOk = new List<string>();
        private List<string> msgDriversNok = new List<string>();


        public Home()
        {
            InitializeComponent();
            Position();
            consultDataBase();
            //InitializeDriverCheck();

            buttonOkImage.Visible = false;

        }

        private void Position()
        {

            //buttonExecute.Left = (this.ClientSize.Width - buttonExecute.Width) / 2;

            label2.Text = "Developed by V. Luiz";
        }
        public void InitializeDriverCheck()
        {
            // Obtendo o diretório atual da aplicação
            string currentDirectory = Directory.GetCurrentDirectory();
            string newDirectoryName = "ConfigFiles";
            string newDirectoryPath = Path.Combine(currentDirectory, newDirectoryName);

            if (!Directory.Exists(newDirectoryPath))
            {
                // Criando o novo diretório
                Directory.CreateDirectory(newDirectoryPath);
            }

            string filePath = Path.Combine(newDirectoryPath, "config.cfg");
            if (!File.Exists(filePath))
            {
                string[] configLines = {
                    "[DRIVERS IMAGES DIRECTORY]",
                    "; driver name  = directory"
                };
                File.WriteAllLines(filePath, configLines);
            }

            Dictionary<string, string> Drivers = ReadDriversFromCfg(filePath);

            try
            {
                // Cria um objeto para buscar informações sobre os drivers
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPSignedDriver");

                // Executa a busca e itera sobre os resultados
                foreach (ManagementObject driver in searcher.Get())
                {
                    //Console.WriteLine("Driver: " + driver["Description"]+", Version:" + driver["DriverVersion"]);
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

                // Exibir mensagens
                if (msgDriversOk.Count > 0)
                {
                    MessageBox.Show(string.Join(Environment.NewLine, msgDriversOk), "Drivers OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (msgDriversNok.Count > 0)
                {
                    MessageBox.Show(string.Join(Environment.NewLine, msgDriversNok), "Drivers Not OK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Dictionary<string, string> ReadDriversFromCfg(string filePath)
        {
            var drivers = new Dictionary<string, string>();

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
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

            return drivers;
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonInsertDriverAR(object sender, EventArgs e)
        {
            /*
            InsertDriver form2 = new InsertDriver();
            form2.Show();
            this.Hide();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBoxDrivers.SelectedItem.ToString();
            string[] parts = selectedItem.Split(new[] { ", " }, StringSplitOptions.None);
            string driver = parts[0].Split(':')[1].Trim();
            string version = parts[1].Split(':')[1].Trim();
            Dictionary<string, string> drivers = new Dictionary<string, string>();
            drivers[driver] = version;
            checkDrivers(drivers);
            drivers.Clear();

            string currentDirectory = Directory.GetCurrentDirectory();
            string newDirectoryName = "ConfigFiles";
            string newDirectoryPath = Path.Combine(currentDirectory, newDirectoryName);
            string filePath = Path.Combine(newDirectoryPath, "config.cfg");
            if (File.Exists(filePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        if (line.Contains(driver))
                        {
                            string dir = line.Split('=')[1].Trim();
                            Console.WriteLine(dir);
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.Image = Image.FromFile(dir);
                            buttonOkImage.Visible = true;
                        }
                    }
                }
                catch
                {

                }
            }
        }

        public void consultDataBase()
        {
            string driver;
            string version;
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jagvluiz\Documents\dataCD.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Table_AR", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    driver = reader["Driver Name"].ToString();
                    version = reader["Driver Version"].ToString();
                    comboBoxDrivers.Items.Add("Driver: " + driver + ", Version: " + version);
                }
            }
        }
        public void checkDrivers(Dictionary<string, string> Drivers)
        {
            msgDriversOk.Clear();
            try
            {
                // Cria um objeto para buscar informações sobre os drivers
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPSignedDriver");

                // Executa a busca e itera sobre os resultados
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

                // Exibir mensagens
                if (msgDriversOk.Count > 0)
                {
                    MessageBox.Show(string.Join(Environment.NewLine, msgDriversOk), "Drivers OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (msgDriversNok.Count > 0)
                {
                    MessageBox.Show(string.Join(Environment.NewLine, msgDriversNok), "Drivers Not OK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonOkImage_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            buttonOkImage.Visible = false;
        }

        private void buttonInsertDriverVision_Click(object sender, EventArgs e)
        {

        }
    */
    }

}



