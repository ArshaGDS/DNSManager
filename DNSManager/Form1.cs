using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SQLite;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace DNSManager
{
    public partial class Form1 : MaterialForm
    {        
        private SQLiteConnection _connection;

        public Form1()
        {
            InitializeComponent();
            InitializeSkin();
            InitializeDatabase();
            LoadDNS();
        }

        private void InitializeSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple400, Primary.Purple900, Primary.Purple900, Accent.Purple200, TextShade.WHITE);
        }

        private void InitializeDatabase()
        {

            _connection = new SQLiteConnection("Data Source=dns.db;Version=3;");
            _connection.Open();

            // Create the DNS table if it doesn't exist
            var createTableQuery = "CREATE TABLE IF NOT EXISTS DNS (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, DNS1 TEXT, DNS2 TEXT)";
            var createTableCommand = new SQLiteCommand(createTableQuery, _connection);
            createTableCommand.ExecuteNonQuery();

            var selectQuery = "SELECT * FROM DNS";
            var selectCommand = new SQLiteCommand(selectQuery, _connection);
            var reader = selectCommand.ExecuteReader();

            if (reader.StepCount <= 0)
            {
                foreach (var item in GetDefaultDNSs())
                {
                    insert(item.Name, item.DNS1, item.DNS2);
                }
            }

            reader.Close();
        }

        private DNSData[] GetDefaultDNSs()
        {
            return new DNSData[]
                {
                    new DNSData { Name = "Radar.Game", DNS1 = "10.202.10.10",   DNS2 = "10.202.10.11"    },
                    new DNSData { Name = "Electro",    DNS1 = "78.157.42.100",  DNS2 = "78.157.42.101"   },
                    new DNSData { Name = "Shecan",     DNS1 = "178.22.122.100", DNS2 = "185.51.200.2"    },
                    new DNSData { Name = "403.Online", DNS1 = "10.202.10.202",  DNS2 = "10.202.10.102"   },
                    new DNSData { Name = "Begzar",     DNS1 = "185.55.226.26",  DNS2 = "185.55.225.25"   },
                    new DNSData { Name = "Quad DNS",   DNS1 = "9.9.9.9",        DNS2 = "149.112.112.112" },
                    new DNSData { Name = "Open DNS",   DNS1 = "208.67.222.222", DNS2 = "208.67.220.220"  },
                    new DNSData { Name = "Cloudflare", DNS1 = "1.1.1.1",        DNS2 = "1.0.0.1"         },
                    new DNSData { Name = "Google",     DNS1 = "8.8.8.8",        DNS2 = "8.8.4.4"         },
                    new DNSData { Name = "DNS1",       DNS1 = "94.203.132.99",  DNS2 = "94.200.156.82"   },
                    new DNSData { Name = "DNS2",       DNS1 = "77.88.8.1",      DNS2 = "77.88.8.8"       },
                    new DNSData { Name = "DNS3",       DNS1 = "94.140.14.140",  DNS2 = "94.140.14.141"   }
                };
        }

        private void LoadDNS()
        {
            comboBoxDNS.Items.Clear();

            var selectQuery = "SELECT Name FROM DNS";
            var selectCommand = new SQLiteCommand(selectQuery, _connection);
            var reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                comboBoxDNS.Items.Add(reader.GetString(0));
            }

            reader.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text.Trim();
            var dns1 = textBoxDNS1.Text.Trim();
            var dns2 = textBoxDNS2.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(dns1) || string.IsNullOrEmpty(dns2))
            {                
                MessageForm messageForm = new MessageForm("Error", "Name and DNS fields cannot be empty.", "Ok");
                messageForm.ShowDialog();
                return;
            }

            if (checkName(name))
            {                
                MessageForm messageForm = new MessageForm("Error", "The DNS name must not be duplicated.", "Ok");
                messageForm.ShowDialog();
                return;
            }

            if (!IsDnsFormatValid(dns1) && !IsDnsFormatValid(dns2))
            {                
                MessageForm messageForm = new MessageForm("Error", "Please enter valid format.", "Ok");
                messageForm.ShowDialog();
                return;
            }

            insert(name, dns1, dns2);

            LoadDNS();

            textBoxName.Text = "";
            textBoxDNS1.Text = "";
            textBoxDNS2.Text = "";
        }

        private void insert(string name, string dns1, string dns2)
        {
            var insertQuery = "INSERT INTO DNS (Name, DNS1, DNS2) VALUES (@name, @dns1, @dns2)";
            var insertCommand = new SQLiteCommand(insertQuery, _connection);
            insertCommand.Parameters.AddWithValue("@name", name);
            insertCommand.Parameters.AddWithValue("@dns1", dns1);
            insertCommand.Parameters.AddWithValue("@dns2", dns2);
            insertCommand.ExecuteNonQuery();
        }

        private bool checkName(string name)
        {

            var selectQuery = "SELECT Name FROM DNS";
            var selectCommand = new SQLiteCommand(selectQuery, _connection);
            var reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetString(0) == name)
                {
                    return true;
                }
            }

            reader.Close();

            return false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            var name = comboBoxDNS.SelectedItem?.ToString();
            MessageForm messageForm;

            if (string.IsNullOrEmpty(name))
            {
                messageForm = new MessageForm("Error", "Please select a name to delete.", "Ok");
                messageForm.ShowDialog();
                return;
            }

            Action btnYes = () => {

                var deleteQuery = "DELETE FROM DNS WHERE Name = @name";
                var deleteCommand = new SQLiteCommand(deleteQuery, _connection);
                deleteCommand.Parameters.AddWithValue("@name", name);
                deleteCommand.ExecuteNonQuery();

                LoadDNS();

                textBoxName.Text = "";
                textBoxDNS1.Text = "";
                textBoxDNS2.Text = "";

                messageForm = new MessageForm("Done.", "Ok");
                messageForm.ShowDialog();
            };

            Action btnNo = () => { };

            messageForm = new MessageForm("Warning", "Are you sure?", "Yes", "No", btnYes, btnNo);
            messageForm.ShowDialog();            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            var selectedItem = comboBoxDNS.SelectedItem?.ToString();
            var newName = textBoxName.Text.Trim();
            var newDNS1 = textBoxDNS1.Text.Trim();
            var newDNS2 = textBoxDNS2.Text.Trim();

            MessageForm messageForm;

            if (string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newDNS1) || string.IsNullOrEmpty(newDNS2))
            {
                messageForm = new MessageForm("Error", "Name and new DNS fields cannot be empty.", "Ok");
                messageForm.ShowDialog();
                return;
            }

            if (!IsDnsFormatValid(newDNS1) && !IsDnsFormatValid(newDNS2))
            {
                messageForm = new MessageForm("Error", "Please enter valid format.", "Ok");
                messageForm.ShowDialog();
                return;
            }

            Action btnYes = () => {

                var updateQuery = "UPDATE DNS SET Name = @newName, DNS1 = @newDNS1, DNS2 = @newDNS2 WHERE Name = @selectedDNS";
                var updateCommand = new SQLiteCommand(updateQuery, _connection);
                updateCommand.Parameters.AddWithValue("@newName", newName);
                updateCommand.Parameters.AddWithValue("@newDNS1", newDNS1);
                updateCommand.Parameters.AddWithValue("@newDNS2", newDNS2);
                updateCommand.Parameters.AddWithValue("@selectedDNS", selectedItem);
                updateCommand.ExecuteNonQuery();

                LoadDNS();

                textBoxName.Text = "";
                textBoxDNS1.Text = "";
                textBoxDNS2.Text = "";

                messageForm = new MessageForm("Done.", "Ok");
                messageForm.ShowDialog();
            };

            Action btnNo = () => { };
            
            messageForm = new MessageForm("Warning", "Are you sure?", "Yes", "No", btnYes, btnNo);
            messageForm.ShowDialog();                      
        }

        private void buttonApplyDNS_Click(object sender, EventArgs e)
        {
            var name = comboBoxDNS.SelectedItem?.ToString();

            MessageForm messageForm;

            if (string.IsNullOrEmpty(name))
            {                
                messageForm = new MessageForm("Error", "Please select a name to apply DNS.", "Ok");
                messageForm.ShowDialog();
                return;
            }

            var selectQuery = "SELECT DNS1, DNS2 FROM DNS WHERE Name = @name";
            var selectCommand = new SQLiteCommand(selectQuery, _connection);
            selectCommand.Parameters.AddWithValue("@name", name);
            var reader = selectCommand.ExecuteReader();

            if (reader.Read())
            {
                var dns1 = reader.GetString(0);
                var dns2 = reader.GetString(1);
                ApplyDNS(dns1, dns2);
            }

            reader.Close();

            messageForm = new MessageForm("Done.", "Ok");
            messageForm.ShowDialog();
        }

        private void buttonClearDNS_Click(object sender, EventArgs e)
        {
            ClearDNS();
            MessageForm messageForm = new MessageForm("Done.", "Ok");
            messageForm.ShowDialog();
        }

        private void ApplyDNS(string dns1, string dns2)
        {
            ExecuteCommand($"netsh interface ipv4 set dns name=\"{GetActiveNetworkInterfaceName()}\" static {dns1}");
            ExecuteCommand($"netsh interface ipv4 add dns name=\"{GetActiveNetworkInterfaceName()}\" {dns2} index=2");
        }

        private void ClearDNS()
        {
            ExecuteCommand($"netsh interface ipv4 set dnsservers name=\"{GetActiveNetworkInterfaceName()}\" source=dhcp");
        }

        private void ExecuteCommand(string command)
        {
            // Execute a command in a new process and wait for it to finish
            using (var process = new Process())
            {
                var startInfo = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    Arguments = "/C " + command,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    Verb = "runas"
                };
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }
        }

        private string GetActiveNetworkInterfaceName()
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in interfaces)
            {
                if (ni.OperationalStatus == OperationalStatus.Up && ni.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    IPInterfaceProperties properties = ni.GetIPProperties();
                    if (properties.GatewayAddresses.Count > 0)
                    {
                        return ni.Name;
                    }
                }
            }

            return string.Empty;
        }

        private void comboBoxDNS_TextChanged(object sender, EventArgs e)
        {
            var name = comboBoxDNS.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(name))
            {
                MessageForm messageForm = new MessageForm("Error", "Please select a name to apply DNS.", "Ok");
                messageForm.ShowDialog();
                return;
            }

            var selectQuery = "SELECT NAME, DNS1, DNS2 FROM DNS WHERE Name = @name";
            var selectCommand = new SQLiteCommand(selectQuery, _connection);
            selectCommand.Parameters.AddWithValue("@name", name);
            var reader = selectCommand.ExecuteReader();

            if (reader.Read())
            {
                textBoxName.Text = reader.GetString(0);
                textBoxDNS1.Text = reader.GetString(1);
                textBoxDNS2.Text = reader.GetString(2);
            }

            reader.Close();
        }

        public static bool IsDnsFormatValid(string dns)
        {
            string pattern = @"^(\d{1,3}\.){3}\d{1,3}$";
            return Regex.IsMatch(dns, pattern);
        }

        private void githubLink_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://github.com/ArshaGDS/DNSManager", UseShellExecute = true });
        }
    }
}