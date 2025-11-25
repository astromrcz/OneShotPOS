using SiticoneNetCoreUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneShotPOS
{
    public partial class UC_Receptionist : UserControl
    {
        private const string ConnectionString = @"Data Source=""C:\Users\morco\Downloads\testDB.db"";Version=3;";

        public UC_Receptionist()
        {
            InitializeComponent();
        }

        private void UC_Receptionist_Load(object sender, EventArgs e)
        {
            pnlTables.Padding = new Padding(10);
            pnlTables.Controls.Clear();

            //SeedTablesIfEmpty();
            //SeedQueueIfEmpty();
            LoadTableCards();
        }
        private void LoadTableCards()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // 🌟 Updated query to include DurationHours (Index 5)
                // TableID=0, TableName=1, Status=2, CustomerName=3, IsOpenTime=4, DurationHours=5
                string query = "SELECT TableID, TableName, Status, CustomerName, IsOpenTime, DurationHours FROM TBL_TABLES ORDER BY TableID;";

                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    pnlTables.Controls.Clear();

                    while (reader.Read())
                    {
                        // Accessing data by ordinal index
                        string tableName = reader.GetString(1);     // Index 1: TableName
                        string status = reader.GetString(2);        // Index 2: Status
                        string customer = reader.IsDBNull(3) ? string.Empty : reader.GetString(3); // Index 3: CustomerName
                        bool isOpenTime = reader.GetInt32(4) == 1;  // Index 4: IsOpenTime

                        // 🌟 NEW: Extract DurationHours (Index 5)
                        int durationHours = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);

                        // 1. Create the Card Panel
                        // 🌟 UPDATED COLOR LOGIC: Using Darker/Brighter colors for better contrast
                        Color cardColor = Color.White; // Default
                        if (status == "Available")
                        {
                            cardColor = Color.LightGreen;
                        }
                        else if (status == "Occupied")
                        {
                            // Use Color.Red or Color.Salmon for a confirmed occupied status
                            cardColor = Color.Salmon;
                        }
                        else
                        {
                            cardColor = Color.Khaki; // For 'Reserved' or other statuses
                        }

                        Panel card = new Panel
                        {
                            Width = 250,
                            Height = 120,
                            Margin = new Padding(10),
                            BackColor = cardColor, // Use the determined color
                            BorderStyle = BorderStyle.FixedSingle,
                            Tag = new TableData(tableName, status)
                        };

                        // 2. Attach Click Event Handlers (as before)
                        card.Click += TableCard_Click;
                        foreach (Control control in card.Controls)
                        {
                            control.Click += TableCard_Click;
                        }

                        // 3. Create Labels
                        Label lblTitle = new Label
                        {
                            Text = tableName,
                            Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                            Location = new Point(10, 10),
                            AutoSize = true
                        };

                        Label lblStatus = new Label
                        {
                            Text = $"Status: {status}",
                            Location = new Point(10, 35),
                            AutoSize = true
                        };

                        Label lblCustomer = new Label
                        {
                            Text = string.IsNullOrEmpty(customer) ? "" : $"Customer: {customer}",
                            Location = new Point(10, 55),
                            AutoSize = true
                        };

                        // 🌟 UPDATED LABEL: Show DurationHours if the table is occupied
                        string timeText = "";
                        if (isOpenTime)
                        {
                            timeText = "Open Time";
                        }
                        if (status == "Occupied" && durationHours > 0)
                        {
                            timeText += $" | Duration: {durationHours} hr(s)";
                        }

                        Label lblTimeInfo = new Label // Renamed from lblOpenTime for broader scope
                        {
                            Text = timeText,
                            Location = new Point(10, 75),
                            AutoSize = true,
                            ForeColor = status == "Occupied" ? Color.DarkRed : Color.DarkSlateBlue // Dark red text for occupied
                        };

                        // 4. Add Controls to Card and Card to Panel
                        card.Controls.Add(lblTitle);
                        card.Controls.Add(lblStatus);
                        card.Controls.Add(lblCustomer);
                        card.Controls.Add(lblTimeInfo); // Using the new label name

                        pnlTables.Controls.Add(card);
                    }
                }
            }
        }

        public struct TableData
        {
            public string Name;
            public string Status;

            public TableData(string name, string status)
            {
                Name = name;
                Status = status;
            }
        }

        private void TableCard_Click(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;
            // Safely get the parent Panel that holds the Tag data
            Panel card = clickedControl as Panel ?? clickedControl.Parent as Panel;

            if (card != null && card.Tag is TableData tableInfo)
            {
                // Get the Table Status
                string tableName = tableInfo.Name;
                string status = tableInfo.Status;

                // Check the table status and open the corresponding form
                if (status == "Available")
                {
                    // Open the StartTable form
                    StartTable startForm = new StartTable(tableName, status, ConnectionString);

                    if (startForm.ShowDialog() == DialogResult.OK)
                    {
                        // Refresh the dashboard to show the new 'Occupied' status
                        LoadTableCards();
                    }
                }
                else if (status == "Occupied")
                {
                    // 🌟 Open the OccupiedTable form 🌟
                    // NOTE: You must update the OccupiedTable constructor (see below)
                    OccupiedTable occupiedForm = new OccupiedTable(tableName, ConnectionString);

                    // Show the form. You might want to refresh the cards if any action 
                    // inside (like extending time or ending table) changes the status/data.
                    if (occupiedForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadTableCards();
                    }
                }
                else
                {
                    // Handle other statuses if necessary (e.g., "Reserved")
                    MessageBox.Show($"Table {tableName} is currently {status}.", "Table Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {

        }
    }

}


