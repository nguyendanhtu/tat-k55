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
    public partial class f902_dm_uinit_de : Form
    {

        // Constructor
        public f902_dm_uinit_de()
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
        public void display_for_update(US_DM_UNIT ip_us_unit)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_unit = ip_us_unit;
            this.ShowDialog();

        }

        #endregion

        #region Members
        US_DM_UNIT m_us_unit = new US_DM_UNIT();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion

        #region Private Method

        /// <summary>
        /// Format control, when control be loaded.
        /// </summary>
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            this.KeyPreview = true;
            m_lbl__description.Font = new Font("Arial", 9);
            m_lbl_unit_code.Font = new Font("Arial", 9);
            m_lbl_add_unit.ForeColor = Color.Blue;
            m_lbl_add_unit.Font = new Font("Arial", 16);
            label1.ForeColor = Color.Red; 
            label2.ForeColor = Color.Red;
        }

        /// <summary>
        /// Define event
        /// </summary>
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            this.Load += new EventHandler(f902_dm_uinit_de_Load);
        }

        

        private void us_object_2_form(US_DM_UNIT ip_us_unit)
        {
            m_txt_unit_code.Text = ip_us_unit.strUNIT_CODE;
            m_txt_description.Text = ip_us_unit.strDESCRIPTION;
        }

        private void form_2_us_object(US_DM_UNIT op_us_unit)
        {
            op_us_unit.strUNIT_CODE = m_txt_unit_code.Text;
            op_us_unit.strDESCRIPTION = m_txt_description.Text;
        }

        private bool check_validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_unit_code, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_description, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }
            return true;
        }

        private void save_data()
        {
            if (check_validate_data_is_ok() == false) return;
            form_2_us_object(m_us_unit);
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_unit.Insert();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_unit.Update();
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }

            BaseMessages.MsgBox_Infor(10); //Dữ liệu cập nhật thành cộng
            this.Close();

        }

        #endregion


        // Event
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

        void f902_dm_uinit_de_Load(object sender, EventArgs e)
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
                        us_object_2_form(m_us_unit);
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
