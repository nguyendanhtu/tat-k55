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
    public partial class f702_dm_provider_de : Form
    {
        public f702_dm_provider_de()
        {
            InitializeComponent();
            format_controls();
        }
        #region Public Interface
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();

        }
        public void display_for_update(US_DM_PROVIDER ip_us_provider)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_provider = ip_us_provider;
            this.ShowDialog();

        }
        #endregion

        #region Members

        US_DM_PROVIDER m_us_provider = new US_DM_PROVIDER();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        
        #endregion

        #region Private Method
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            this.KeyPreview = true;
            set_define_events();
            m_lbl_add__provider.ForeColor = Color.Blue;
            m_lbl_add__provider.Font = new Font("Arial", 16);
            m_lbl_address.Font = new Font("Arial", 9);
            m_lbl_email.Font = new Font("Arial", 9);
            m_lbl_mobile.Font = new Font("Arial", 9);
            m_lbl_provider_code.Font = new Font("Arial", 9);
            m_lbl_provider_name.Font = new Font("Arial", 9);
            m_lbl_tax_code.Font = new Font("Arial", 9);
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Red;
        }
        private void us_object_2_form(US_DM_PROVIDER ip_us_provider)
        {
            m_txt_address.Text = ip_us_provider.strADDRESS;
            m_txt_email.Text = ip_us_provider.strEMAIL;
            m_txt_mobile.Text = ip_us_provider.strMOBILE;
            m_txt_provider_code.Text = ip_us_provider.strPROVIDER_CODE;
            m_txt_provider_name.Text = ip_us_provider.strPROVIDER_NAME;
            m_txt_tax_code.Text = ip_us_provider.strTAX_CODE;
        }
        private void form_2_us_object(US_DM_PROVIDER op_us_provider)
        {
            op_us_provider.strPROVIDER_CODE = m_txt_provider_code.Text;
            op_us_provider.strADDRESS = m_txt_address.Text;
            op_us_provider.strEMAIL = m_txt_email.Text;
            op_us_provider.strMOBILE = m_txt_mobile.Text;
            op_us_provider.strPROVIDER_NAME = m_txt_provider_name.Text;
            if (m_txt_tax_code.Text.Trim() == "") op_us_provider.SetTAX_CODENull();
            else op_us_provider.strTAX_CODE = m_txt_tax_code.Text.Trim();
        }
        private bool check_validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_address, DataType.StringType, allowNull.YES, true))
            { 
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_email, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_mobile, DataType.StringType, allowNull.YES, true))
            {
                return false;
            
            }
            if (!CValidateTextBox.IsValid(m_txt_provider_code, DataType.StringType, allowNull.NO, true))
            {
                return false;

            }
            if (!CValidateTextBox.IsValid(m_txt_provider_name, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_tax_code, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            return true;
        }
        private void save_data()
        {
            if (check_validate_data_is_ok() == false)
                return;
            form_2_us_object(m_us_provider);
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_provider.Insert();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_provider.Update();
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }
             BaseMessages.MsgBox_Infor(10); //Dữ liệu cập nhật thành cộng
            this.Close();
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            this.Load += new EventHandler(f702_dm_provider_de_Load);
        }

        void f702_dm_provider_de_Load(object sender, EventArgs e)
        {
            try
            {

                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        break;
                    case DataEntryFormMode.SelectDataState:
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        us_object_2_form(m_us_provider);
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
       
        #endregion

        #region Events

        void m_cmd_exit_Click(Object Sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                
                throw;
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
        #endregion
    }
}
