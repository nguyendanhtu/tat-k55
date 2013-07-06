using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using SaleUS;

namespace SaleApp
{
    public partial class f802_dm_repository_de : Form
    {
        public f802_dm_repository_de()
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
        public void display_for_update(US_DM_REPOSITORY ip_us_repository)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_repository = ip_us_repository;
            this.ShowDialog();
        }
        #endregion

        #region Members
        US_DM_REPOSITORY m_us_repository = new US_DM_REPOSITORY();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion


        #region Private Method

        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            this.KeyPreview = true;
            m_lbl_add_repository.ForeColor = Color.Blue;
            m_lbl_address.Font = new Font("Arial", 9);
            m_lbl_mobile.Font = new Font("Arial", 9);
            m_lbl_repository_code.Font = new Font("Arial", 9);
            m_lbl_repository_name.Font = new Font("Arial", 9);
            m_lbl_add_repository.Font = new Font("Arial", 16);
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Red;
        }

        private void us_object_2_form(US_DM_REPOSITORY ip_us_repository)
        {
            m_txt_repository_code.Text = ip_us_repository.strREPOSITORY_CODE;
            m_txt_repository_name.Text = ip_us_repository.strREPOSITORY_NAME;
            m_txt_address.Text = ip_us_repository.strADDRESS;
            m_txt_mobile.Text = ip_us_repository.strMOBILE;
        }


        private void form_2_us_object(US_DM_REPOSITORY op_us_repository)
        {
            op_us_repository.strREPOSITORY_CODE = m_txt_repository_code.Text;
            op_us_repository.strREPOSITORY_NAME = m_txt_repository_name.Text;
            op_us_repository.strMOBILE = m_txt_mobile.Text;
            op_us_repository.strADDRESS = m_txt_address.Text;

        }

        private bool check_validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_repository_code, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }

            if (!CValidateTextBox.IsValid(m_txt_repository_name, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_mobile, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_address, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            
            return true;
        }


        private void save_data()
        {
            if (check_validate_data_is_ok() == false) return;
            form_2_us_object(m_us_repository);
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_repository.Insert();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_repository.Update();
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
            this.Load += new EventHandler(f802_dm_repository_de_Load);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
        }

        #endregion 


        #region Event

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

        void f802_dm_repository_de_Load(object sender, EventArgs e)
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
                        us_object_2_form(m_us_repository);
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
    }
}
