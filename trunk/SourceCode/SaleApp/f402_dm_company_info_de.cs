using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SaleUS;
using IP.Core.IPCommon;

namespace SaleApp
{
    public partial class f402_dm_company_info_de : Form
    {
        public f402_dm_company_info_de()
        {
            InitializeComponent();
            format_controls();
            set_define_events();
        }

        #region Public Interface
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();

        }
        public void display_for_update(US_DM_COMPANY_INFO ip_us_company_info)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_company_info = ip_us_company_info;
            this.ShowDialog();

        }
        #endregion

        #region Members
        US_DM_COMPANY_INFO m_us_company_info = new US_DM_COMPANY_INFO();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion

        #region Private Method
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            this.KeyPreview = true;
            m_lbl_add_company.Font = new Font("Arial", 16);
            m_lbl_add_company.ForeColor = Color.Blue;
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Red;
            m_lbl_address.Font = new Font("Arial", 9);
            m_lbl_email.Font = new Font("Arial", 9);
            m_lbl_mobile.Font = new Font("Arial", 9);
            m_lbl_full_name.Font = new Font("Arial", 9);
            m_lbl_short_name.Font = new Font("Arial", 9);
            m_lbl_tax_code.Font = new Font("Arial", 9);
            m_txt_address.Font = new Font("Arial", 9);
        }


        private void us_object_2_form(US_DM_COMPANY_INFO ip_us_company_info)
        {
            m_txt_full_name.Text = CIPConvert.ToStr(ip_us_company_info.strFULL_NAME);
            m_txt_address.Text = CIPConvert.ToStr(ip_us_company_info.strADDRESS);
            m_txt_mobile.Text = CIPConvert.ToStr(ip_us_company_info.strMOBLIE);
            m_txt_short_name.Text = CIPConvert.ToStr(ip_us_company_info.strSHORT_NAME);
            m_txt_tax_code.Text = CIPConvert.ToStr(ip_us_company_info.strTAX_CODE);
            m_txt_email.Text = CIPConvert.ToStr(ip_us_company_info.strEMAIL);

        }


        private void form_2_us_object(US_DM_COMPANY_INFO op_us_company_info)
        {
            op_us_company_info.strADDRESS = m_txt_address.Text;
            op_us_company_info.strFULL_NAME=m_txt_full_name.Text;
            op_us_company_info.strMOBLIE=m_txt_mobile.Text;
            op_us_company_info.strSHORT_NAME=m_txt_short_name.Text;
            op_us_company_info.strTAX_CODE=m_txt_tax_code.Text;
            op_us_company_info.strEMAIL = m_txt_email.Text;
        }

        private bool check_validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_short_name, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_full_name, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_address, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_mobile, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_email, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_tax_code, DataType.NumberType, allowNull.YES, true))
            {
                return false;
            }

            return true;
        }


        private void save_data()
        {
            if (check_validate_data_is_ok() == false) return;
            form_2_us_object(m_us_company_info);
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_company_info.Insert();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_company_info.Update();
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
            this.Load += new EventHandler(f402_dm_company_info_Load);

        }


        #endregion



        #region Events
        private void f402_dm_company_info_Load(object sender, EventArgs e)
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
                        us_object_2_form(m_us_company_info);
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

        #endregion

     
      

   

     
     
    }
}
