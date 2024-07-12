using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Expenses
{
    public partial class MainForm : Form
    {

        private Timer slideTimer;
        //private bool isPanelVisible;
        private bool isPanelExpanded;
        private const int expandedWidth = 200; // Full width when expanded
        private const int collapsedWidth = 50; // Width to show only icons
        public MainForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {

            // Initialize the panelMenu and timer
            panelMenu.Width = collapsedWidth;
            isPanelExpanded = false;
            slideTimer = new Timer();
            slideTimer.Interval = 10; // Adjust the interval for smoother or faster animation
            slideTimer.Tick += SlideTimer_Tick;

            btnMenu.Click += btnMenu_Click;
        }

        private void LoadUserControl(UserControl userControl)
        {
            panelDisplay.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelDisplay.Controls.Add(userControl);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardUC dashboardUC = new DashboardUC();
            LoadUserControl(dashboardUC);
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            ExpenseListUC expenseListUC = new ExpenseListUC();
            LoadUserControl(expenseListUC);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            ProfileUC transactionListUC = new ProfileUC();
            LoadUserControl(transactionListUC);
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            slideTimer.Start();

        }
        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            const int slideSpeed = 10; // Adjust the speed of the sliding

            if (!isPanelExpanded)
            {
                // Slide in the panel
                if (panelMenu.Width < expandedWidth)
                {
                    panelMenu.Width += slideSpeed;
                }
                else
                {
                    panelMenu.Width = expandedWidth;
                    slideTimer.Stop();
                    isPanelExpanded = true;
                }
            }
            else
            {
                // Slide out the panel
                if (panelMenu.Width > collapsedWidth)
                {
                    panelMenu.Width -= slideSpeed;
                }
                else
                {
                    panelMenu.Width = collapsedWidth;
                    slideTimer.Stop();
                    isPanelExpanded = false;
                }
            }

        }

        private void panelDisplay_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}