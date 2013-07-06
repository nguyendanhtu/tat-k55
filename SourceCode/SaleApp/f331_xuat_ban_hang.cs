using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;

using Sale.CDBNames;
using SaleDS;
using SaleUS;
using C1.Win.C1FlexGrid;

namespace SaleApp
{
    public partial class f331_xuat_ban_hang : Form
    {
        // Constructor
        public f331_xuat_ban_hang()
        {
            InitializeComponent();
            format_control();
        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }

        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_DM_PRODUCT m_ds_product = new DS_DM_PRODUCT();
        US_DM_CUSTOMER m_us_customer = new US_DM_CUSTOMER();

        US_GD_BILL m_us_gd_bill = new US_GD_BILL();
        US_GD_DELIVERY_ORDER m_us_gd_delivery_order = new US_GD_DELIVERY_ORDER();

        Hashtable m_hst_mapping_code_2_id_product = new Hashtable();
        Hashtable m_hst_mapping_id_2_code_product = new Hashtable();

        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;

        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            PRODUCT_CODE = 1,
            PRODUCT_NAME = 2,
            QUANTITY = 4,
            UNIT_PRICE = 3,
            AMMOUNT = 5,
            PRODUCT_ID = 6
        }

        #endregion

        #region Private Method

        private void format_control()
        {
           // CControlFormat.setC1FlexFormat(m_fg);

            //CControlFormat.setFormStyle(this);
            
            m_fg.AllowEditing = true;
            set_define_event();
            m_lbl_header.ForeColor = Color.Blue;
            m_lbl_header.Font = new Font("Arial", 16);
            m_lbl_address.Font = new Font("Arial", 9);
            
            //m_lbl_company_info_address.Font = new Font("Arial", 9);
            
            m_lbl_depository.Font = new Font("Arial", 9);
            m_lbl_customer.Font = new Font("Arial", 9);
            m_lbl_noi_ban.Font = new Font("Arial", 9);
            m_lbl_order_number.Font = new Font("Arial", 9);
            m_lbl_date.Font = new Font("Arial", 9);

            m_fg.Cols[(int)e_col_Number.PRODUCT_ID].Visible = false;
        }

        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(GD_BILL_DETAIL.PRODUCT_ID, e_col_Number.PRODUCT_ID);
            v_htb.Add(GD_BILL_DETAIL.QUANTITY, e_col_Number.QUANTITY);
            v_htb.Add(GD_BILL_DETAIL.UNIT_PRICE, e_col_Number.UNIT_PRICE);
            DS_GD_BILL_DETAIL v_ds_gd_bill_detail = new DS_GD_BILL_DETAIL();
            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, v_ds_gd_bill_detail.GD_BILL_DETAIL.NewRow());
            return v_obj_trans;
        }

        private void set_inital_form_load()
        {

            m_obj_trans = get_trans_object(m_fg);
            load_data_2_repository();
            mapping_col_product_code();
        }

        private void load_data_2_repository()
        {
            US_DM_REPOSITORY v_us_repository = new US_DM_REPOSITORY();
            DS_DM_REPOSITORY v_ds_repository = new DS_DM_REPOSITORY();
            v_us_repository.FillDataset(v_ds_repository);
            m_cbo_repository.DataSource = v_ds_repository.DM_REPOSITORY;
            m_cbo_repository.DisplayMember = DM_REPOSITORY.REPOSITORY_NAME;
            m_cbo_repository.ValueMember = DM_REPOSITORY.ID;
        }

        private void mapping_col_product_code()
        {
            US_DM_PRODUCT v_us_product = new US_DM_PRODUCT();
            m_ds_product.DM_PRODUCT.Clear();

            v_us_product.FillDataset(m_ds_product, "ORDER BY " + DM_PRODUCT.PRODUCT_CODE);
            m_hst_mapping_code_2_id_product.Clear();
            m_hst_mapping_id_2_code_product.Clear();
            foreach (DataRow v_dr in m_ds_product.DM_PRODUCT.Rows)
            {
                m_hst_mapping_code_2_id_product.Add(v_dr[DM_PRODUCT.PRODUCT_CODE], v_dr[DM_PRODUCT.ID]);
                m_hst_mapping_id_2_code_product.Add( v_dr[DM_PRODUCT.ID], v_dr[DM_PRODUCT.PRODUCT_CODE]);
            }

        }
       

        private bool is_check_validate_data_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_bill_code, DataType.StringType, allowNull.NO, true)) return false;
            if (!CValidateTextBox.IsValid(m_txt_customer, DataType.StringType, allowNull.NO, true)) return false;
            if (!CValidateTextBox.IsValid(m_txt_total_price, DataType.NumberType, allowNull.NO, true)) return false;

            if (m_cbo_repository.SelectedValue == null)
            {
                BaseMessages.MsgBox_Warning("Bạn chưa chọn kho xuất hàng!");
                return false;
            }
            // check so hoa don nay da co' hay chua?

            // check grid co' okie du lieu hay khong?
            return true;
        }

        private void grid_2_us_object(int i_grid_row, US_GD_BILL_DETAIL op_us_gd_bill_detail, US_GD_DELIVERY_ORDER_DETAIL op_us_gd_delivery_order_detail)
        {
            //1. grid 2 us gd bill detail
            op_us_gd_bill_detail.dcBILL_ID = m_us_gd_bill.dcID;
            op_us_gd_bill_detail.dcPRODUCT_ID = CIPConvert.ToDecimal(m_hst_mapping_code_2_id_product[m_fg[i_grid_row, (int)e_col_Number.PRODUCT_CODE]]);
            op_us_gd_bill_detail.dcQUANTITY = CIPConvert.ToDecimal(m_fg[i_grid_row, (int)e_col_Number.QUANTITY]);
            op_us_gd_bill_detail.dcUNIT_PRICE = CIPConvert.ToDecimal(m_fg[i_grid_row, (int)e_col_Number.UNIT_PRICE]);
            //2. grid 2 us gd delivery order detail
            op_us_gd_delivery_order_detail.dcDELIVERY_ORDER_ID = m_us_gd_delivery_order.dcID;
            op_us_gd_delivery_order_detail.dcPRODUCT_ID = op_us_gd_bill_detail.dcPRODUCT_ID;
            op_us_gd_delivery_order_detail.dcQUANTITY = op_us_gd_bill_detail.dcQUANTITY * (-1);
            
        }

        private void form_2_us_object(US_GD_BILL op_us_gd_bill, US_GD_DELIVERY_ORDER op_us_gd_delivery_order)
        {
            //1. form 2 us bill
            op_us_gd_bill.strBILL_SERI = m_txt_bill_code.Text;
            op_us_gd_bill.dcCUSTOMER_ID = m_us_customer.dcID;
            op_us_gd_bill.datBILL_DATE = m_dat_bill_date.Value.Date;          
            op_us_gd_bill.SetTAX_RATENull(); // Chương trình chưa xử lý phần thuế
            op_us_gd_bill.dcAMMOUNT = CIPConvert.ToDecimal(m_txt_total_price.Text);
            op_us_gd_bill.dcUSER_ID = CAppContext_201.getCurrentUserID();

            //1. form 2 us delivery
            op_us_gd_delivery_order.strDELIVERY_ORDER_CODE = m_txt_bill_code.Text;
            op_us_gd_delivery_order.dcCUSTOMER_ID = m_us_customer.dcID;
            op_us_gd_delivery_order.datDELIVERY_ORDER_DATE = m_dat_bill_date.Value.Date;
            op_us_gd_delivery_order.dcREPOSITORY_ID = CIPConvert.ToDecimal(m_cbo_repository.SelectedValue);
            op_us_gd_delivery_order.dcUSER_ID = CAppContext_201.getCurrentUserID();
            op_us_gd_delivery_order.strIN_OUT_YN = "N";// Xuất hàng
        }

        private bool is_validate_grid_row(int i_grid_row)
        {
            if (m_fg[i_grid_row, (int)e_col_Number.PRODUCT_CODE] == null) return false;
            if (m_fg[i_grid_row, (int)e_col_Number.UNIT_PRICE] == null) return false;
            if (m_fg[i_grid_row, (int)e_col_Number.QUANTITY] == null) return false;
            if (CIPConvert.is_valid_number(m_fg[i_grid_row, (int)e_col_Number.UNIT_PRICE]) == false) return false;
            if (CIPConvert.is_valid_number(m_fg[i_grid_row, (int)e_col_Number.QUANTITY]) == false) return false; 
            return true;
        }

        private void save_data()
        {
            if (!is_check_validate_data_ok())    return;
            form_2_us_object(m_us_gd_bill, m_us_gd_delivery_order);
            US_GD_BILL_DETAIL v_us_gd_bill_detail = new US_GD_BILL_DETAIL();
            US_GD_DELIVERY_ORDER_DETAIL v_us_gd_delivery_order_detail = new US_GD_DELIVERY_ORDER_DETAIL();
            try
            {
                m_us_gd_bill.BeginTransaction();
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        m_us_gd_bill.Insert();
                        m_us_gd_delivery_order.UseTransOfUSObject(m_us_gd_bill);
                        m_us_gd_delivery_order.Insert();

                        v_us_gd_bill_detail.UseTransOfUSObject(m_us_gd_bill);
                        v_us_gd_delivery_order_detail.UseTransOfUSObject(m_us_gd_bill);
                        for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count; v_i_cur_row++)
                        {
                            if (is_validate_grid_row(v_i_cur_row) == false) continue;
                            grid_2_us_object(v_i_cur_row, v_us_gd_bill_detail, v_us_gd_delivery_order_detail);
                            v_us_gd_bill_detail.Insert();
                            v_us_gd_delivery_order_detail.Insert();
                        }

                        break;
                    case DataEntryFormMode.UpdateDataState:
                        break;
                    case DataEntryFormMode.ViewDataState:
                        break;
                }

                m_us_gd_bill.CommitTransaction();

                BaseMessages.MsgBox_Infor(10);

            }
            catch (Exception v_e)
            {
                if (m_us_gd_bill.is_having_transaction())
                {
                    m_us_gd_bill.Rollback();
                }
                throw;
            }
        }

        private void calculate_total_amount()
        {
            decimal v_dc_total_price = 0;
            for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count; v_i_cur_row++)
            {
                if (m_fg[v_i_cur_row, (int)e_col_Number.AMMOUNT] == null) continue;
                if (CIPConvert.is_valid_number(m_fg[v_i_cur_row, (int)e_col_Number.AMMOUNT]) == false) continue;
                v_dc_total_price += CIPConvert.ToDecimal(m_fg[v_i_cur_row, (int)e_col_Number.AMMOUNT]);
            }
            m_txt_total_price.Text = CIPConvert.ToStr(v_dc_total_price, "#,###");
        }

        private void us_gd_bill_2_form(US_GD_BILL ip_us_gd_bill)
        {
            //1. us gd bill 2 form
            m_txt_bill_code.Text = ip_us_gd_bill.strBILL_SERI;
            m_us_customer = new US_DM_CUSTOMER(ip_us_gd_bill.dcCUSTOMER_ID);
            m_txt_customer.Text = m_us_customer.strCUSTOMER_NAME;
            m_dat_bill_date.Value = ip_us_gd_bill.datBILL_DATE;
            //op_us_gd_bill.SetTAX_RATENull(); // Chương trình chưa xử lý phần thuế
            m_txt_total_price.Text = CIPConvert.ToStr(ip_us_gd_bill.dcAMMOUNT, "#,###");

            //2. load us gd delivery 2 form
            m_us_gd_delivery_order.InitByDELIVERY_CODE(ip_us_gd_bill.strBILL_SERI);
            m_cbo_repository.SelectedValue = m_us_gd_delivery_order.dcREPOSITORY_ID;

            //3. load us gd bill detail 2 grid
            US_GD_BILL_DETAIL v_us_gd_bill_detail = new US_GD_BILL_DETAIL();
            DS_GD_BILL_DETAIL v_ds_gd_bill_detail = new DS_GD_BILL_DETAIL();
            v_us_gd_bill_detail.FillDataset(v_ds_gd_bill_detail," WHERE " + GD_BILL_DETAIL.BILL_ID +"="+ ip_us_gd_bill.dcID.ToString());
            CGridUtils.ClearDataInGrid(m_fg);
            CGridUtils.Dataset2C1Grid(v_ds_gd_bill_detail, m_fg, m_obj_trans);
            for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count-1; v_i_cur_row++)
            {
                if (m_fg[v_i_cur_row, (int)e_col_Number.PRODUCT_ID] == null) continue;

                m_fg[v_i_cur_row, (int)e_col_Number.PRODUCT_CODE] = m_hst_mapping_id_2_code_product[m_fg[v_i_cur_row, (int)e_col_Number.PRODUCT_ID]];
            }

        }

        private void select_hoa_don()
        {
            f932_bao_cao_doanh_thu_theo_ky v_frm932 = new f932_bao_cao_doanh_thu_theo_ky();
            if (v_frm932.select_gd_bill(ref m_us_gd_bill) == DialogResult.OK)
            {
                us_gd_bill_2_form(m_us_gd_bill);
            }
        }
        #endregion


        #region Event

        void set_define_event()
        {
            this.Load += new EventHandler(f331_xuat_ban_hang_Load);
            this.m_fg.CellChanged += new C1.Win.C1FlexGrid.RowColEventHandler(this.m_fg_CellChanged);
            m_cmd_add_customer.Click += new EventHandler(m_cmd_add_customer_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            this.m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);            
            this.m_cmd_remove_row.Click += new EventHandler(m_cmd_remove_row_Click);

            this.m_cmd_ds_hoa_don.Click += new EventHandler(m_cmd_ds_hoa_don_Click);

        }

        void m_cmd_ds_hoa_don_Click(object sender, EventArgs e)
        {
            try
            {
                select_hoa_don();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

       

        void m_cmd_remove_row_Click(object sender, EventArgs e)
        {
            try
            {
                m_fg.Rows.Remove(m_fg.Row);
                calculate_total_amount();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
       
        private void m_fg_CellChanged(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                //1. Tự động đưa thông tin về tên sản phẩm và giá thành

                  // Nếu cột có dữ liệu thay đổi là Cột product_code
                if (e.Col == (int)e_col_Number.PRODUCT_CODE)
                {
                    m_fg[e.Row, (int)e_col_Number.PRODUCT_CODE] = m_fg[e.Row, (int)e_col_Number.PRODUCT_CODE].ToString().ToUpper();
                    DataRow[] v_dr_product = m_ds_product.DM_PRODUCT.Select(DM_PRODUCT.PRODUCT_CODE + " = '" + m_fg[e.Row, (int)e_col_Number.PRODUCT_CODE].ToString()+"'");
                    if (v_dr_product.Length == 0)
                    {
                        BaseMessages.MsgBox_Warning("Không có mặt hàng có mã này");
                        return;// Neu khong co' trong ban PRODUCT thi phai thoat luon? Nhung cha'c cha'n la sai do'
                    }
                    m_fg[e.Row, (int)e_col_Number.PRODUCT_NAME] = v_dr_product[0][DM_PRODUCT.PRODUCT_NAME];
                    m_fg[e.Row, (int)e_col_Number.UNIT_PRICE] = v_dr_product[0][DM_PRODUCT.CURRENT_PRICE];
                    // Focus vào cột nào(tương ứng với dòng nào)
                }

                if (m_fg[e.Row, (int)e_col_Number.UNIT_PRICE] == null) return;
                if (m_fg[e.Row, (int)e_col_Number.QUANTITY] == null) return;
                if (CIPConvert.is_valid_number(m_fg[e.Row, (int)e_col_Number.UNIT_PRICE]) == false) return;
                if (CIPConvert.is_valid_number(m_fg[e.Row, (int)e_col_Number.QUANTITY]) == false) return;
                
                // 2. Tự động tính thông tin thành tiền trên từng dòng
                m_fg[e.Row, (int)e_col_Number.AMMOUNT]
                    = CIPConvert.ToDecimal(m_fg[e.Row, (int)e_col_Number.UNIT_PRICE])
                        * CIPConvert.ToDecimal(m_fg[e.Row, (int)e_col_Number.QUANTITY]);
                //3. Tự động tính tổng tiền bán
                calculate_total_amount();
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

        void m_cmd_update_Click(object sender, EventArgs e)
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

        void m_cmd_add_customer_Click(object sender, EventArgs e)
        {
            try
            {
                f501_dm_customer v_frm501_customer = new f501_dm_customer();
                v_frm501_customer.select_customer(ref m_us_customer);
                m_txt_customer.Text = m_us_customer.strCUSTOMER_NAME;
                m_fg.Focus();

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f331_xuat_ban_hang_Load(object sender, EventArgs e)
        {
            try
            {
                set_inital_form_load();
               
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #endregion

        
       

     


    }
}

