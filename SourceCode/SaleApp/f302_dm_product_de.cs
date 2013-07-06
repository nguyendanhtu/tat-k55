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
    public partial class f302_dm_product_de : Form
    {
        public f302_dm_product_de()
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

        public void display_for_update(US_DM_PRODUCT ip_us_product_detail)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_product_detail = ip_us_product_detail;
            this.ShowDialog();
        }
        public void display_for_view(US_DM_PRODUCT ip_us_detail)
        {

            m_e_form_mode = DataEntryFormMode.ViewDataState;
            m_us_product_detail = ip_us_detail;
            this.ShowDialog();
        }

        public void display()
        {
            m_e_form_mode = DataEntryFormMode.ViewDataState;
            this.ShowDialog();
        }

      

        #endregion 

        #region Members
        US_DM_PRODUCT m_us_product_detail = new US_DM_PRODUCT();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion

        #region Privvate Method
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            this.KeyPreview = true;
            mlbl_add_product.Font = new Font("Arial", 16);
            label1.ForeColor = Color.Red;
            mlbl_add_product.ForeColor = Color.Blue;
            label2.ForeColor = Color.Red;
            label3.ForeColor = Color.Red;
            label4.ForeColor = Color.Red;
            label5.ForeColor = Color.Red;
            m_lbl_categories.Font = new Font("Arial", 9);
            m_lbl_price.Font = new Font("Arial", 9);
            m_lblproduct_code.Font = new Font("Arial", 9);
            m_lblproduct_description.Font = new Font("Arial", 9);
            m_lblproduct_name.Font = new Font("Arial", 9);
            m_lblproduct_unit.Font = new Font("Arial", 9);
        }
        private void us_object_2_form(US_DM_PRODUCT ip_us_product_detail)
        {
            m_txt_product_code.Text = ip_us_product_detail.strPRODUCT_CODE;
            m_txt_product_name.Text = ip_us_product_detail.strPRODUCT_NAME;
            m_txt_price.Text = CIPConvert.ToStr(ip_us_product_detail.dcCURRENT_PRICE,"#,###");
            m_txt_description.Text = ip_us_product_detail.strDESCRIPTION;
            m_cbo_unit.SelectedValue = CIPConvert.ToStr(ip_us_product_detail.dcUNIT_ID);
            m_cbo_category.SelectedValue = CIPConvert.ToStr(ip_us_product_detail.dcCATEGORY_ID);
            m_txt_image_path.Text = ip_us_product_detail.strIMAGE_PATH;
        }
        private void load_data_2_unit_cbo()
        {
            US_DM_UNIT v_us_unit = new US_DM_UNIT();
            DS_DM_UNIT v_ds_dm_unit = new DS_DM_UNIT();
            v_us_unit.FillDataset(v_ds_dm_unit);
            m_cbo_unit.DisplayMember = DM_UNIT.UNIT_CODE;
            m_cbo_unit.ValueMember = DM_UNIT.ID;
            m_cbo_unit.DataSource = v_ds_dm_unit.DM_UNIT;
        }
        private void load_data_2_unit_category()
        {
            US_DM_CATEGORY v_us_category = new US_DM_CATEGORY();
            DS_DM_CATEGORY v_ds_dm_category = new DS_DM_CATEGORY();
            v_us_category.FillDataset(v_ds_dm_category, " ORDER BY " + DM_CATEGORY.DISPLAY_ORDER);
            m_cbo_category.DisplayMember = DM_CATEGORY.CATEGORY_NAME;
            m_cbo_category.ValueMember = DM_CATEGORY.ID;
            m_cbo_category.DataSource = v_ds_dm_category.DM_CATEGORY;
        }
        private void form_2_us_object(US_DM_PRODUCT op_us_product)
        {
            op_us_product.strPRODUCT_CODE= m_txt_product_code.Text;
            op_us_product.strPRODUCT_NAME=m_txt_product_name.Text;
            op_us_product.dcCURRENT_PRICE = CIPConvert.ToDecimal(m_txt_price.Text.Trim());
            op_us_product.strDESCRIPTION = m_txt_description.Text;
            op_us_product.dcUNIT_ID = CIPConvert.ToDecimal(m_cbo_unit.SelectedValue);
            op_us_product.dcCATEGORY_ID = CIPConvert.ToDecimal(m_cbo_category.SelectedValue);
            //op_us_product.SetPROVIDER_CODENull();
            op_us_product.strIMAGE_PATH=m_txt_image_path.Text;
        }
        private bool check_data_validate()
        {
            
             if (!CValidateTextBox.IsValid(m_txt_product_code, DataType.StringType, allowNull.NO, true))
                return false;
             if (!CValidateTextBox.IsValid(m_txt_product_name, DataType.StringType, allowNull.NO, true))
                return false;
             if (!CValidateTextBox.IsValid(m_txt_price, DataType.NumberType, allowNull.NO, true))
                 return false;

            return true;
        }
        private void save_data()
        {
            if (!check_data_validate()) return;
            form_2_us_object(m_us_product_detail);
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_product_detail.Insert();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_product_detail.Update();
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
                  
            }
            BaseMessages.MsgBox_Infor(10); //Dữ liệu cập nhật thành công
            this.Close();
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            this.Load += new EventHandler(f302_dm_product_de_Load);

            m_txt_price.Leave += new EventHandler(m_txt_price_Leave);
        }

        void m_txt_price_Leave(object sender, EventArgs e)
        {
            try
            {
                if (CIPConvert.is_valid_number(m_txt_price.Text))
                {
                    m_txt_price.Text =
                        CIPConvert.ToStr(
                        CIPConvert.ToDecimal(m_txt_price.Text), "#,###");
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
            
        }
        #endregion

        // ======================
        //============Event =========
        //==========================
        void f302_dm_product_de_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_unit_cbo();
                load_data_2_unit_category();
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        break;
                    case DataEntryFormMode.SelectDataState:
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        us_object_2_form(m_us_product_detail);
                        //m_txt_price.Enabled = false;
                        break;
                    case DataEntryFormMode.ViewDataState:
                        us_object_2_form(m_us_product_detail);
                        break;
                    default:
                        break;
                }
                if (m_txt_image_path.Text!="")
                {
                    Image m_img_myimage = Image.FromFile(m_txt_image_path.Text);
                    pictureBox1.Image = m_img_myimage;
                }
                
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

        private void m_cmd_browse_img_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string m_str_image_path = openFileDialog1.FileName;
           
            m_txt_image_path.Text = m_str_image_path;
            Image m_img_myimage = Image.FromFile(m_txt_image_path.Text);
            pictureBox1.Image = m_img_myimage;
        }
    }
}
