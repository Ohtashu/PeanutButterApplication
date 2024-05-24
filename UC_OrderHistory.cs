using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard.UserControls
{
    public partial class UC_OrderHistory : UserControl
    {
        public UC_OrderHistory()
        {
            InitializeComponent();
        }

        private void dgvOrderHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       

        private void UC_OrderHistory_Load(object sender, EventArgs e)
        {
            dgvOrderHistory.Columns[0].Width = 142;
            dgvOrderHistory.Columns[1].Width = 142;
            dgvOrderHistory.Columns[2].Width = 142;
            dgvOrderHistory.Columns[3].Width = 142;
        }
    }
}
