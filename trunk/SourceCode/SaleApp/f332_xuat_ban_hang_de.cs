using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using SaleUS;

namespace SaleApp
{
    public partial class f332_xuat_ban_hang_de : Form
    {
        public f332_xuat_ban_hang_de(US_GD_BILL ip_us_bill)
        {
            InitializeComponent();

            m_us_bill = ip_us_bill;
            format_control();
            set_define_event();
        }

        #region Public Interface

        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        #endregion

        #region Member
        US_GD_BILL m_us_bill = new US_GD_BILL();
        US_GD_BILL_DETAIL m_us_bill_detail = new US_GD_BILL_DETAIL();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion

        #region Private Method

        private void format_control()
        {
            CControlFormat.setFormStyle(this);
            this.KeyPreview = true;
        }

        private void set_define_event()
        {
            this.Load += new EventHandler(f332_xuat_ban_hang_de_Load);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
        }

        private bool check_data_validate_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_product_code, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_product_count, DataType.NumberType, allowNull.NO, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_product_price, DataType.NumberType, allowNull.NO, true))
            {
                return false;
            }

            return true;
        }

        private void form_2_us_object(US_GD_BILL_DETAIL op_us_bill_detail)
        {
            op_us_bill_detail.dcBILL_ID = m_us_bill.dcID;
            op_us_bill_detail.dcPRODUCT_ID = CIPConvert.ToDecimal(m_txt_product_code.Text);
            op_us_bill_detail.dcQUANTITY = CIPConvert.ToDecimal(m_txt_product_count.Text);
            op_us_bill_detail.dcUNIT_PRICE = CIPConvert.ToDecimal(m_txt_product_price.Text);
        }

        private void save_data()
        {
            if (!check_data_validate_is_ok())
                return;

            form_2_us_object(m_us_bill_detail);
        }

        #endregion


        #region Event

        private void f332_xuat_ban_hang_de_Load(object sender, EventArgs e)
        {
            try
            {
                m_lbl_bill_code.Text = m_us_bill.strBILL_SERI;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #endregion 
    }
}
