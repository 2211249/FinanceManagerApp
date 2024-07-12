using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace My_Expenses
{
    public partial class DashboardUC : UserControl
    {
        private Timer refreshTimer;

        public DashboardUC()
        {
            InitializeComponent();
            InitializeRefreshTimer();
        }

        private void InitializeRefreshTimer()
        {
            refreshTimer = new Timer();
            refreshTimer.Interval = 60000; // Set the interval to 60 seconds (60000 milliseconds)
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            LoadSalaryChart();
            LoadExpenseChart();
            UpdateLabels();
        }

        private void LoadSalaryChart()
        {
            decimal salary = ProfileUC.UserSalary;
            decimal totalSpent = ExpenseListUC.Transactions.Sum(t => t.Amount);
            decimal remaining = salary - totalSpent;

            // Clear existing chart
            panelSalaryChart.Controls.Clear();

            // Create a new chart
            Chart chart = new Chart
            {
                Dock = DockStyle.Fill
            };

            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                ChartType = SeriesChartType.Pie
            };

            // Add data points
            series.Points.Add(new DataPoint { AxisLabel = "Spent", YValues = new double[] { (double)totalSpent }, Color = Color.Red });
            series.Points.Add(new DataPoint { AxisLabel = "Remaining", YValues = new double[] { (double)remaining }, Color = Color.Green });

            chart.Series.Add(series);

            // Add chart to panel
            panelSalaryChart.Controls.Add(chart);
        }

        private void LoadExpenseChart()
        {
            var expensesByCategory = ExpenseListUC.Transactions
                .GroupBy(t => t.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    Amount = g.Sum(t => t.Amount)
                }).ToList();

            // Clear existing chart
            panelExpenseChart.Controls.Clear();

            // Create a new chart
            Chart chart = new Chart
            {
                Dock = DockStyle.Fill
            };

            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                ChartType = SeriesChartType.Pie
            };

            // Add data points
            foreach (var expense in expensesByCategory)
            {
                series.Points.Add(new DataPoint { AxisLabel = expense.Category, YValues = new double[] { (double)expense.Amount } });
            }

            chart.Series.Add(series);

            // Add chart to panel
            panelExpenseChart.Controls.Add(chart);
        }

        private void UpdateLabels()
        {
            decimal salary = ProfileUC.UserSalary;
            decimal totalSpent = ExpenseListUC.Transactions.Sum(t => t.Amount);
            decimal remaining = salary - totalSpent;

            lblTotalUsed.Text = $"{totalSpent:C}";
            lblTotalRemaining.Text = $"{remaining:C}";

            // Display warning if more than 60% of salary is spent
            if (totalSpent > 0.6m * salary)
            {
                lblWarning.Text = "Warning: You have spent more than 60% of your salary!";
            }
            else
            {
                lblWarning.Text = string.Empty;
            }
        }

        private void DashboardUC_Load(object sender, EventArgs e)
        {
            RefreshTimer_Tick(sender, e); // Initial load
        }
    }
}
