using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderMakingApp
{
    public enum MessageType
    {
        Error,
        Information
    }

    public partial class MainForm : Form, IMainView
    {
        public event EventHandler<OrderedDishesEventArgs> OrderWasMade = delegate { };
        public event EventHandler Init;
        public MainForm()
        {
            InitializeComponent();
            this.Load += (sender, args) => Invoke(Init);
        }

        public void LoadMenu(List<Dish> menu)
        {
            MenuGridView.DataSource = menu;
        }

        public void Show()
        {
            Application.Run(this);
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            List<string> OrderedDishesNames = new List<string>();
            var checkedRows = from DataGridViewRow row in MenuGridView.Rows
                              where Convert.ToBoolean(row.Cells["IsDishOrdered"].Value) == true
                              select row;

            foreach (var row in checkedRows)
            {
                row.Cells["IsDishOrdered"].Value = false;
                OrderedDishesNames.Add(row.Cells["nameDataGridViewTextBoxColumn"].Value.ToString());
            }

            OrderWasMade(this, new OrderedDishesEventArgs(OrderedDishesNames));
        }

        public void ShowMessage(string text, MessageType type)
        {
            if (type == MessageType.Error)
                MessageBox.Show(text, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (type == MessageType.Information)
                MessageBox.Show(text, "Інформація про замовлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
