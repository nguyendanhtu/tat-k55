using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using IP.Core.IPException;
using IP.Core.IPCommon;
using IP.Core.IPUserService;

using SaleUS;
using SaleDS;
using Sale.CDBNames;

namespace SaleApp
{
    public partial class f321_nhap_so_du_hang_hoa : Form
    {
        public f321_nhap_so_du_hang_hoa()
        {
            InitializeComponent();
            format_controls();
            
        }

        #region Members

        ITransferDataRow m_obj_trans;
        #endregion

        #region Data Structure
        private enum ecolNumber
        {
            colProductCode = 1
            , colProductName = 2
            , colProductUnit = 3
            , colQuantity = 4
        }
        #endregion

        #region Public Interfaces
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Private Methods

        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            CControlFormat.setC1FlexFormat(m_fg);
            m_fg.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.None;
            m_fg.AllowEditing = true;
            m_lbl_header.ForeColor = Color.Blue;
            m_lbl_header.Font = new Font("Arial", 16);
            set_define_events();
        }

        private ITransferDataRow get_mapping_grid_col()
        {
            Hashtable v_obj_hst = new Hashtable();
            v_obj_hst.Add(RPT_PRODUCT_BALANCE.PRODUCT_CODE, ecolNumber.colProductCode);
            v_obj_hst.Add(RPT_PRODUCT_BALANCE.PRODUCT_NAME, ecolNumber.colProductName);
            v_obj_hst.Add(RPT_PRODUCT_BALANCE.UNIT_CODE, ecolNumber.colProductUnit);
            v_obj_hst.Add(RPT_PRODUCT_BALANCE.QUANTITY, ecolNumber.colQuantity);

            DS_RPT_PRODUCT_BALANCE v_ds_rpt_producdt_balace = new DS_RPT_PRODUCT_BALANCE();

            return new CC1TransferDataRow(m_fg, v_obj_hst, v_ds_rpt_producdt_balace.RPT_PRODUCT_BALANCE.NewRPT_PRODUCT_BALANCERow());

        }


        private void load_data_2_grid()
        {
            if (m_cbo_category.SelectedValue == null) return;

            US_RPT_PRODUCT_BALANCE v_us_rpt_product_balance = new US_RPT_PRODUCT_BALANCE();
            DS_RPT_PRODUCT_BALANCE v_ds_rpt_product_balance = new DS_RPT_PRODUCT_BALANCE();
            //v_ds_rpt_product_balance.EnforceConstraints = false;
            v_us_rpt_product_balance.FillDataset(
                v_ds_rpt_product_balance
                , m_dat_ngay_nhap.Value.Date
                , CIPConvert.ToDecimal( m_cbo_category.SelectedValue)
                , 1 // ID repository Mai LinhDH phai them combox
                );

            CGridUtils.Dataset2C1Grid(v_ds_rpt_product_balance, m_fg, m_obj_trans);
        }

        private void load_data_to_cbo_category()
        {
            US_DM_CATEGORY v_us_dm_category = new US_DM_CATEGORY();
            DS_DM_CATEGORY v_ds_dm_category = new DS_DM_CATEGORY();

            v_us_dm_category.FillDataset(v_ds_dm_category,"ORDER BY "+ DM_CATEGORY.DISPLAY_ORDER);
            m_cbo_category.SelectedIndexChanged -= new EventHandler(m_cbo_product_SelectedIndexChanged);
            m_cbo_category.DisplayMember = DM_CATEGORY.CATEGORY_NAME;
            m_cbo_category.ValueMember = DM_PRODUCT.ID;
            m_cbo_category.DataSource = v_ds_dm_category.DM_CATEGORY;
            m_cbo_category.SelectedIndexChanged += new EventHandler(m_cbo_product_SelectedIndexChanged);
        }
        private DS_DM_PRODUCT Load_product_by_id(int ip_i_product_id)
        {
            US_DM_PRODUCT v_us_dm_product = new US_DM_PRODUCT();
            DS_DM_PRODUCT v_ds_dm_product = new DS_DM_PRODUCT();

            v_us_dm_product.FillDataset(v_ds_dm_product, "WHERE ID="+ip_i_product_id);
            return v_ds_dm_product;
        }

        private void set_initial_form_load()
        {
            m_obj_trans = get_mapping_grid_col();

            load_data_to_cbo_category();

            load_data_2_grid();

        }
        private void check_data_validate()
        {
           
        }

        private void grid_2_us_object(int i_grid_row, US_RPT_PRODUCT_BALANCE ip_us_product_balace)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            ip_us_product_balace.DataRow2Me(v_dr);
        }


        private void save_data()
        {
            
            US_RPT_PRODUCT_BALANCE v_us_product_balance = new US_RPT_PRODUCT_BALANCE();
            for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count; v_i_cur_row++)
            {
                grid_2_us_object(v_i_cur_row, v_us_product_balance);
                if (v_us_product_balance.IsQUANTITYNull()) continue;
                if (v_us_product_balance.dcQUANTITY == 0) continue;
                v_us_product_balance.Insert();
            }
            BaseMessages.MsgBox_Infor(10);

        }

        private void set_define_events()
        {

            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cbo_category.SelectedIndexChanged += new EventHandler(m_cbo_product_SelectedIndexChanged);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            this.Load += new EventHandler(f321_nhap_so_du_hang_hoa_Load);
        }
        #endregion
        void f321_nhap_so_du_hang_hoa_Load(object sender, EventArgs e)
        {
            try
            {

                set_initial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
       

        #region Events      
    
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
        void m_cbo_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                load_data_2_grid();
                
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
