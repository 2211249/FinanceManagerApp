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
    public partial class ExpenseListUC : UserControl
    {
        public static List<Transaction> Transactions { get; private set; }

        public ExpenseListUC()
        {
            InitializeComponent();
            InitializeCustomComponents();
            Transactions = new List<Transaction>();
        }

        private void InitializeCustomComponents()
        {
            // Populate initial categories
            comboCategory.Items.AddRange(new string[] { "Home", "Utilities" });

            // Add event handler for the Add button
            btnAdd.Click += btnAdd_Click;

            // Set txtTotal and txtDisplay to read-only
         
            txtDisplay.ReadOnly = true;
            txtDisplay.Multiline = true; // Enable multiline display
            txtDisplay.ScrollBars = ScrollBars.Vertical; // Add vertical scrollbar

            // Display the user salary in lblSalary
            lblSalary.Text = ProfileUC.UserSalary.ToString("C");
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Event handler for category selection change
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            // Event handler for amount text change
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            // Event handler for item text change
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string item = txtItem.Text;
            string category = comboCategory.Text;
            decimal amount;

            if (string.IsNullOrWhiteSpace(item))
            {
                MessageBox.Show("Please enter an item.");
                return;
            }

            if (string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Please select or enter a category.");
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            // Check if total spending exceeds the salary
            decimal totalSpending = Transactions.Sum(t => t.Amount);
            if (totalSpending + amount > ProfileUC.UserSalary)
            {
                MessageBox.Show("You cannot exceed your salary!");
                return;
            }

            // Add transaction
            var transaction = new Transaction
            {
                Item = item,
                Category = category,
                Amount = amount
            };

            Transactions.Add(transaction);
            AddTransactionToDisplay(transaction);
            UpdateTotal();

            // Clear input fields
            txtItem.Clear();
            txtAmount.Clear();
            comboCategory.Text = string.Empty;
        }

        private void AddTransactionToDisplay(Transaction transaction)
        {
            string transactionText = $"{transaction.Item} - {transaction.Category} - {transaction.Amount:C}";
            txtDisplay.AppendText(transactionText + Environment.NewLine);
        }

        private void UpdateTotal()
        {
            decimal total = Transactions.Sum(t => t.Amount);
            txtTotal.Text = total.ToString("C");
        }

        private void ExpenseListUC_Load(object sender, EventArgs e)
        {
            // Event handler for UserControl load
        }

        private void panelTransactions_Paint(object sender, PaintEventArgs e)
        {
            // Event handler for panel paint
        }

        public class Transaction
        {
            public string Item { get; set; }
            public string Category { get; set; }
            public decimal Amount { get; set; }
        }
    }
}