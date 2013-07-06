using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using SaleUS;
using SaleDS;
using Sale.CDBNames;

namespace SaleApp
{
    public partial class f502_dm_customer_de : Form
    {
        public f502_dm_customer_de()
        {
            InitializeComponent();
            format_control();
            set_define_event();
        }

        #region Public Interface

        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();

        }
        public void display_for_update(US_DM_CUSTOMER ip_us_customer)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_customer = ip_us_customer;
            this.ShowDialog();

        }

        #endregion

        #region Private Method

        private void format_control()
        {
            CControlFormat.setFormStyle(this);
            this.KeyPreview = true;
            m_lbl_add_customer.ForeColor = Color.Blue;
            m_lbl_add_customer.Font = new Font("Arial", 16);
            m_lbl_address.Font = new Font("Arial", 9);
            m_lbl_customer_group_name.Font = new Font("Arial", 9);
            m_lbl_email.Font = new Font("Arial", 9);
            m_lbl_customer_name.Font = new Font("Arial", 9);
            m_lbl_mobile_phone.Font = new Font("Arial", 9);
            m_lbl_tax_code.Font = new Font("Arial", 9);
            m_lbl_website.Font = new Font("Arial", 9);
            label1.ForeColor = Color.Red;
        }

        private void set_define_event()
        {
            this.Load += new EventHandler(f502_dm_customer_de_Load);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);

        }

        private void us_object_2_form(US_DM_CUSTOMER ip_us_customer)
        {
            m_txt_customer_name.Text = ip_us_customer.strCUSTOMER_NAME;
            m_txt_tax_code.Text = ip_us_customer.strTAX_CODE;
            m_txt_address.Text = ip_us_customer.strADDRESS;
            m_txt_mobile_phone.Text = ip_us_customer.strMOBLIE_PHONE;
            m_txt_email.Text = ip_us_customer.strEMAIL;
            m_txt_website.Text = ip_us_customer.strWEBSITE;
            m_cbo_customer_group_name.SelectedValue = ip_us_customer.dcCUSTOMER_GROUP_ID;
        }

        private void form_2_us_object(US_DM_CUSTOMER op_us_customer)
        {
            op_us_customer.strCUSTOMER_NAME = m_txt_customer_name.Text;
            op_us_customer.strTAX_CODE = m_txt_tax_code.Text;
            op_us_customer.strADDRESS = m_txt_address.Text;
            op_us_customer.strMOBLIE_PHONE = m_txt_mobile_phone.Text;
            op_us_customer.strEMAIL = m_txt_email.Text;
            op_us_customer.strWEBSITE = m_txt_website.Text;
            op_us_customer.dcCUSTOMER_GROUP_ID = (decimal)m_cbo_customer_group_name.SelectedValue;
        }

        private bool check_validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_customer_name, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_tax_code,DataType.StringType, allowNull.YES, true) )
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_mobile_phone, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            return true;
        }

        private void save_data()
        {
            if (check_validate_data_is_ok() == false)
                return;
            form_2_us_object(m_us_customer);
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_customer.Insert();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_customer.Update();
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }

            BaseMessages.MsgBox_Infor(10);
            this.Close();
        }

        private void load_data_2_cbo()
        {
            US_DM_CUSTOMER_GROUP v_us_customer_group = new US_DM_CUSTOMER_GROUP();
            DS_DM_CUSTOMER_GROUP v_ds_customer_group = new DS_DM_CUSTOMER_GROUP();
            v_us_customer_group.FillDataset(v_ds_customer_group, " ORDER BY " + DM_CUSTOMER_GROUP.CUSTOMER_GROUP_NAME);
            v_ds_customer_group.EnforceConstraints = false;

            m_cbo_customer_group_name.DisplayMember = DM_CUSTOMER_GROUP.CUSTOMER_GROUP_NAME;
            m_cbo_customer_group_name.ValueMember = DM_CUSTOMER_GROUP.ID;
            m_cbo_customer_group_name.DataSource = v_ds_customer_group.DM_CUSTOMER_GROUP;
        }

        #endregion

        #region Member
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        US_DM_CUSTOMER m_us_customer = new US_DM_CUSTOMER();
        #endregion


        // 
        // Event
        //
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

        void f502_dm_customer_de_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_cbo();
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        break;
                    case DataEntryFormMode.SelectDataState:
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        us_object_2_form(m_us_customer);
                        break;
                    case DataEntryFormMode.ViewDataState:
                        break;
                    default:
                        break;
                }

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
