using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SQLite;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

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

            // Create the Initialize table if it doesn't exist
            createTableQuery = "CREATE TABLE IF NOT EXISTS Init (Id INTEGER PRIMARY KEY AUTOINCREMENT, InitializedDB BLOB DEFAULT false)";
            createTableCommand = new SQLiteCommand(createTableQuery, _connection);
            createTableCommand.ExecuteNonQuery();

            var selectQuery = "SELECT * FROM DNS";
            var selectCommand = new SQLiteCommand(selectQuery, _connection);
            var reader = selectCommand.ExecuteReader();

            if (reader.StepCount <= 0)
            {
                DNSData[] dnsArray = new DNSData[]
                {
                    new DNSData { Name = "Radar", DNS1 = "10.202.10.10", DNS2 = "10.202.10.11" },
                    new DNSData { Name = "Electro", DNS1 = "78.157.42.100", DNS2 = "78.157.42.101" },
                    new DNSData { Name = "Shecan", DNS1 = "178.22.122.100", DNS2 = "185.51.200.2" },
                    new DNSData { Name = "403.Online", DNS1 = "10.202.10.202", DNS2 = "10.202.10.102" }
                };

                foreach (var item in dnsArray)
                {
                    insert(item.Name, item.DNS1, item.DNS2);
                }
            }

            reader.Close();
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
                MessageBox.Show("Name and DNS fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsDnsFormatValid(dns1) && !IsDnsFormatValid(dns2))
            {
                MessageBox.Show("Please enter valid format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var name = comboBoxDNS.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please select a name to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var deleteQuery = "DELETE FROM DNS WHERE Name = @name";
            var deleteCommand = new SQLiteCommand(deleteQuery, _connection);
            deleteCommand.Parameters.AddWithValue("@name", name);
            deleteCommand.ExecuteNonQuery();

            LoadDNS();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var name = comboBoxDNS.SelectedItem?.ToString();
            var newDNS1 = textBoxDNS1.Text.Trim();
            var newDNS2 = textBoxDNS2.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(newDNS1) || string.IsNullOrEmpty(newDNS2))
            {
                MessageBox.Show("Name and new DNS fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsDnsFormatValid(newDNS1) && !IsDnsFormatValid(newDNS2))
            {
                MessageBox.Show("Please enter valid format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var updateQuery = "UPDATE DNS SET DNS1 = @newDNS1, DNS2 = @newDNS2 WHERE Name = @name";
            var updateCommand = new SQLiteCommand(updateQuery, _connection);
            updateCommand.Parameters.AddWithValue("@newDNS1", newDNS1);
            updateCommand.Parameters.AddWithValue("@newDNS2", newDNS2);
            updateCommand.Parameters.AddWithValue("@name", name);
            updateCommand.ExecuteNonQuery();

            LoadDNS();

            textBoxName.Text = "";
            textBoxDNS1.Text = "";
            textBoxDNS2.Text = "";
        }

        private void buttonApplyDNS_Click(object sender, EventArgs e)
        {
            var name = comboBoxDNS.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please select a name to apply DNS.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void buttonClearDNS_Click(object sender, EventArgs e)
        {
            ClearDNS();
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
            using (var process = new System.Diagnostics.Process())
            {
                var startInfo = new System.Diagnostics.ProcessStartInfo()
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
                MessageBox.Show("Please select a name to apply DNS.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}