using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SaleApp
{
    public partial class f211_gd_bill : Form
    {
        public f211_gd_bill()
        {
            InitializeComponent();
        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cập nhật thành công");
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void display()
        {
            this.ShowDialog();
        }
    }
}
