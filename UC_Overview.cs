using SiticoneNetCoreUI;
using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.IO;

// 🎯 FIX: Define an alias for the Charting namespace to resolve ambiguity
using Charting = System.Windows.Forms.DataVisualization.Charting;

namespace OneShotPOS
{
    public partial class UC_Overview : UserControl
    {
   
        private const string ConnectionString = @"Data Source=C:\Users\morco\source\repos\OneShotPOS\OneShotDB.db;";
        private static readonly Color ChartSeriesColor = Color.FromArgb(46, 204, 113);
        
        public UC_Overview()
        {
            InitializeComponent();
        }

        private void UC_Overview_Load(object sender, EventArgs e)
        {
          
            string dbPath = ConnectionString.Replace("Data Source=", "").TrimEnd(';');
            if (!File.Exists(dbPath))
            {
                MessageBox.Show($"DATABASE FILE NOT FOUND at path: {dbPath}\n\nPlease verify the ConnectionString.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            
            LoadSummaryLabels();
        }

        private void LoadSummaryLabels()
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    // 1. Revenue Calculations
                    string today = DateTime.Now.ToString("yyyy-MM-dd");
                    string yesterday = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");

                    string queryRevenue = $@"
                        SELECT 
                            SUM(CASE WHEN strftime('%Y-%m-%d', SaleDate) = '{today}' THEN TotalAmount ELSE 0 END) AS TodayRevenue,
                            SUM(CASE WHEN strftime('%Y-%m-%d', SaleDate) = '{yesterday}' THEN TotalAmount ELSE 0 END) AS YesterdayRevenue
                        FROM Sales;";

                    using (var cmd = new SQLiteCommand(queryRevenue, connection))
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            double todayRevenue = reader["TodayRevenue"] is DBNull ? 0 : Convert.ToDouble(reader["TodayRevenue"]);
                            double yesterdayRevenue = reader["YesterdayRevenue"] is DBNull ? 0 : Convert.ToDouble(reader["YesterdayRevenue"]);

                            lblRevenue.Text = $"₱{todayRevenue:N2}";

                            if (yesterdayRevenue > 0)
                            {
                                double percentage = ((todayRevenue - yesterdayRevenue) / yesterdayRevenue) * 100;
                                lblPercentage.Text = $"{(percentage >= 0 ? "+" : "")}{percentage:N1}% from yesterday";
                                lblPercentage.ForeColor = percentage >= 0 ? Color.Green : Color.Red;
                            }
                            else
                            {
                                lblPercentage.Text = "No previous day data";
                                lblPercentage.ForeColor = Color.Gray;
                            }
                        }
                    }

                    // 2. Low Stock Items
                    string queryStock = @"
                        SELECT 
                            COUNT(CASE WHEN StockQuantity <= ReorderLevel THEN 1 END) AS LowStockCount,
                            COUNT(CASE WHEN StockQuantity = 0 THEN 1 END) AS OutOfStockCount
                        FROM Products 
                        WHERE IsActive = 1;";

                    using (var cmd = new SQLiteCommand(queryStock, connection))
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int lowStockCount = Convert.ToInt32(reader["LowStockCount"]);
                            int outOfStockCount = Convert.ToInt32(reader["OutOfStockCount"]);

                            lblLowStockItems.Text = lowStockCount.ToString();
                            lblRequireReorder.Text = $"{outOfStockCount} Out of Stock";
                            lblLowStockItems.ForeColor = lowStockCount > 0 ? Color.OrangeRed : Color.DarkGreen;
                        }
                    }

                   
                    lblActiveTables.Text = "6 / 12";
                    lblOccupancyRate.Text = "50% occupancy rate";
                    lblCurrentQueue.Text = "4 groups";
                    lblAvgWaitTime.Text = "Average wait: 15 min";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Connection/Read Error (Summary): {ex.Message}", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblRevenue.Text = "DB Error";
                lblLowStockItems.Text = "DB Error";
            }
        }

        private void siticoneAdvancedPanel1_Paint(object sender, PaintEventArgs e) { }
        private void siticoneAdvancedPanel7_Paint(object sender, PaintEventArgs e) { }
    }
}