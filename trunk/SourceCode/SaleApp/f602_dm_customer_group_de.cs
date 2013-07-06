using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SaleUS;
using SaleDS;
using Sale.CDBNames;
using IP.Core.IPCommon;

namespace SaleApp
{
    public partial class f602_dm_customer_group_de : Form
    {
        public f602_dm_customer_group_de()
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
        public void display_for_update(US_DM_CUSTOMER_GROUP ip_us_customer_group)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_customer_group = ip_us_customer_group;
            this.ShowDialog();

        }
        #endregion

        #region Members
        US_DM_CUSTOMER_GROUP m_us_customer_group = new US_DM_CUSTOMER_GROUP();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion

        #region Private Method
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            this.KeyPreview = true;
            m_lbl_add_customer_group.ForeColor = Color.Blue;
            m_lbl_add_customer_group.Font = new Font("Arial", 16);
            m_lbl_customer_group_name.Font = new Font("Arial", 9);
            label1.ForeColor = Color.Red;
        }


        private void us_object_2_form(US_DM_CUSTOMER_GROUP ip_us_customer_group)
        {
            m_txt_customer_group_name.Text =CIPConvert.ToStr(ip_us_customer_group.strCUSTOMER_GROUP_NAME);

        }


        private void form_2_us_object(US_DM_CUSTOMER_GROUP op_us_customer_group)
        {
            op_us_customer_group.strCUSTOMER_GROUP_NAME = m_txt_customer_group_name.Text;
        }

        private bool check_validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_customer_group_name, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }

            return true;
        }


        private void save_data()
        {
            if (check_validate_data_is_ok() == false) return;
            form_2_us_object(m_us_customer_group);
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_customer_group.Insert();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_customer_group.Update();
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
            this.Load += new EventHandler(f602_dm_customer_group_Load);


        }


        #endregion



        #region Events
        private void f602_dm_customer_group_Load(object sender, EventArgs e)
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
                        us_object_2_form(m_us_customer_group);
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
