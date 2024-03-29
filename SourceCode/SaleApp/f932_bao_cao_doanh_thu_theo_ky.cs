///************************************************
/// Generated by: tund
/// Date: 24/08/2011 07:02:09
/// Goal: Create Form for V_RPT_GD_BILL
///************************************************


using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;

using SaleUS;
using SaleDS;
using Sale.CDBNames;

using C1.Win.C1FlexGrid;
using IP.Core.IPExcelReport;

namespace SaleApp
{



    public class f932_bao_cao_doanh_thu_theo_ky : System.Windows.Forms.Form
    {
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_export_excel;
        internal SIS.Controls.Button.SiSButton m_cmd_select;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        private Label m_lbl_header;
        private GroupBox groupBox1;
        internal SIS.Controls.Button.SiSButton m_cmd_view;
        private DateTimePicker m_dat_to_date;
        private Label label2;
        private DateTimePicker m_dat_from_date;
        private Label label1;
        private System.ComponentModel.IContainer components;

        public f932_bao_cao_doanh_thu_theo_ky()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            format_controls();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f932_bao_cao_doanh_thu_theo_ky));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_select = new SIS.Controls.Button.SiSButton();
            this.m_cmd_export_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_dat_to_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.m_dat_from_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_select);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_export_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 415);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(581, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.ImageList = this.ImageList;
            this.m_cmd_delete.Location = new System.Drawing.Point(92, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_delete.TabIndex = 23;
            this.m_cmd_delete.Text = "Xóa hóa đơn";
            // 
            // m_cmd_select
            // 
            this.m_cmd_select.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_select.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_select.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_select.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_select.ImageIndex = 14;
            this.m_cmd_select.ImageList = this.ImageList;
            this.m_cmd_select.Location = new System.Drawing.Point(401, 4);
            this.m_cmd_select.Name = "m_cmd_select";
            this.m_cmd_select.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_select.TabIndex = 22;
            this.m_cmd_select.Text = "Chọn";
            // 
            // m_cmd_export_excel
            // 
            this.m_cmd_export_excel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_export_excel.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_export_excel.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_export_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_export_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_export_excel.ImageIndex = 19;
            this.m_cmd_export_excel.ImageList = this.ImageList;
            this.m_cmd_export_excel.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_export_excel.Name = "m_cmd_export_excel";
            this.m_cmd_export_excel.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_export_excel.TabIndex = 21;
            this.m_cmd_export_excel.Text = "In báo cáo";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(489, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 112);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(581, 303);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Blue;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(581, 44);
            this.m_lbl_header.TabIndex = 24;
            this.m_lbl_header.Text = "BÁO CÁO DOANH THU BÁN HÀNG THEO KỲ";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_cmd_view);
            this.groupBox1.Controls.Add(this.m_dat_to_date);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.m_dat_from_date);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 68);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin báo cáo";
            // 
            // m_cmd_view
            // 
            this.m_cmd_view.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_view.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_view.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_view.ImageIndex = 5;
            this.m_cmd_view.ImageList = this.ImageList;
            this.m_cmd_view.Location = new System.Drawing.Point(414, 16);
            this.m_cmd_view.Name = "m_cmd_view";
            this.m_cmd_view.Size = new System.Drawing.Size(88, 40);
            this.m_cmd_view.TabIndex = 22;
            this.m_cmd_view.Text = "In báo cáo";
            // 
            // m_dat_to_date
            // 
            this.m_dat_to_date.CustomFormat = "dd/MM/yyyy";
            this.m_dat_to_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_to_date.Location = new System.Drawing.Point(279, 27);
            this.m_dat_to_date.Name = "m_dat_to_date";
            this.m_dat_to_date.Size = new System.Drawing.Size(102, 20);
            this.m_dat_to_date.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày";
            // 
            // m_dat_from_date
            // 
            this.m_dat_from_date.CustomFormat = "dd/MM/yyyy";
            this.m_dat_from_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_from_date.Location = new System.Drawing.Point(101, 27);
            this.m_dat_from_date.Name = "m_dat_from_date";
            this.m_dat_from_date.Size = new System.Drawing.Size(102, 20);
            this.m_dat_from_date.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày";
            // 
            // f932_bao_cao_doanh_thu_theo_ky
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(581, 451);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f932_bao_cao_doanh_thu_theo_ky";
            this.Text = "F932 - Báo cáo doanh thu bán hàng theo kỳ";
            this.Load += new System.EventHandler(this.f932_bao_cao_doanh_thu_theo_ky_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Public Interface
        public void display()
        {
            m_e_form_mode = DataEntryFormMode.ViewDataState;
            this.ShowDialog();
        }

        public DialogResult select_gd_bill(ref US_GD_BILL op_gd_bill)
        {
            m_dgl_result = DialogResult.Cancel;
            m_e_form_mode = DataEntryFormMode.SelectDataState;
            op_gd_bill = m_us_gd_bill;
            this.ShowDialog();
            return m_dgl_result;
        }
        public delegate void close_tab(bool ip_y_n);
        public close_tab close_tab_B;

        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            BILL_DATE = 1
,
            CUSTOMER_NAME = 3
                ,
            BILL_SERI = 2
                , AMMOUNT = 4

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_RPT_GD_BILL m_ds = new DS_V_RPT_GD_BILL();
        US_V_RPT_GD_BILL m_us_v_rpt_gd_bill = new US_V_RPT_GD_BILL();

        US_GD_BILL m_us_gd_bill = new US_GD_BILL();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.ViewDataState;
        DialogResult m_dgl_result = DialogResult.Cancel;
        #endregion

        #region Private Methods

        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid();

            switch (m_e_form_mode)
            {

                case DataEntryFormMode.SelectDataState:
                    this.Text = "F932 - Danh sách hóa đơn bán hàng";
                    m_cmd_select.Visible = true;
                    m_cmd_delete.Visible = true;
                    break;
          
                case DataEntryFormMode.ViewDataState:
                    this.Text = "F932 - Báo cáo doanh thu bán hàng theo kỳ";
                    m_cmd_select.Visible = false;
                    m_cmd_delete.Visible = false;
                    break;

            }
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_RPT_GD_BILL.BILL_DATE, e_col_Number.BILL_DATE);
            v_htb.Add(V_RPT_GD_BILL.CUSTOMER_NAME, e_col_Number.CUSTOMER_NAME);
            v_htb.Add(V_RPT_GD_BILL.BILL_SERI, e_col_Number.BILL_SERI);
            v_htb.Add(V_RPT_GD_BILL.AMMOUNT, e_col_Number.AMMOUNT);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_RPT_GD_BILL.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_RPT_GD_BILL();
            m_us_v_rpt_gd_bill.FillDataset(m_ds, m_dat_from_date.Value.Date, m_dat_to_date.Value.Date);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Subtotal(AggregateEnum.Sum, 0, -1, (int)e_col_Number.AMMOUNT, "Tổng tiền bán hàng");
            m_fg.Redraw = true;
        }
        private void grid2us_object(US_V_RPT_GD_BILL i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_RPT_GD_BILL i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }

        private void view_v_rpt_gd_bill()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us_v_rpt_gd_bill, m_fg.Row);
            //	f932_bao_cao_doanh_thu_theo_ky_DE v_fDE = new f932_bao_cao_doanh_thu_theo_ky_DE();			
            //	v_fDE.display(m_us);
        }

        private void select_hoa_don_ban_hang()
        {

            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;

            if (m_fg.Rows[m_fg.Row].IsNode == true) return;
            grid2us_object(m_us_v_rpt_gd_bill, m_fg.Row);

            m_us_v_rpt_gd_bill.CopyData2US_GD_BILL(ref m_us_gd_bill);
            m_dgl_result = DialogResult.OK;
            this.Close();
        }

        private void export_excel()
        {
            CExcelReport v_obj_export_excel = new CExcelReport("f932_rpt_bao_cao_doanh_thu_ban_hang_theo_ky.xlsx", 6, 1);
            v_obj_export_excel.AddFindAndReplaceItem("</TU_NGAY>", m_dat_from_date.Value.Date.ToString("dd/MM/yyyy"));
            v_obj_export_excel.AddFindAndReplaceItem("</DEN_NGAY>", m_dat_to_date.Value.Date.ToString("dd/MM/yyyy"));
            v_obj_export_excel.FindAndReplace(false);
            v_obj_export_excel.Export2ExcelWithoutFixedRows(m_fg, (int)e_col_Number.BILL_DATE, m_fg.Cols.Count - 1, true);


        }

        private void delete_gd_bill()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (m_fg.Rows[m_fg.Row].IsNode == true) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            grid2us_object(m_us_v_rpt_gd_bill, m_fg.Row);
            m_us_v_rpt_gd_bill.CopyData2US_GD_BILL(ref m_us_gd_bill);
            try
            {
                m_us_gd_bill.BeginTransaction();
                m_us_gd_bill.Delete();
                m_us_gd_bill.CommitTransaction();
            }
            catch (Exception v_e)
            {
                if (m_us_gd_bill.is_having_transaction())
                {
                    m_us_gd_bill.Rollback();
                }
                throw;
            }
            load_data_2_grid();   
         

        }
        #endregion
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);

            m_cmd_export_excel.Click += new EventHandler(m_cmd_export_excel_Click);
            m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);

            m_cmd_select.Click += new EventHandler(m_cmd_select_Click);
            m_fg.DoubleClick += new EventHandler(m_fg_DoubleClick);
            this.KeyDown += new KeyEventHandler(f932_bao_cao_doanh_thu_theo_ky_KeyDown);
        }

        void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                delete_gd_bill();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f932_bao_cao_doanh_thu_theo_ky_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        if ((m_fg.Focused)&&(m_e_form_mode == DataEntryFormMode.SelectDataState))
                        {
                            select_hoa_don_ban_hang();
                        }
                        break;
                }                
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_fg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                select_hoa_don_ban_hang();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_select_Click(object sender, EventArgs e)
        {
            try
            {
                select_hoa_don_ban_hang();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_view_Click(object sender, EventArgs e)
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
        //
        //
        //		EVENT HANLDERS
        //
        //
        private void f932_bao_cao_doanh_thu_theo_ky_Load(object sender, System.EventArgs e)
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

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                close_tab_B(true);

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }




        private void m_cmd_export_excel_Click(object sender, EventArgs e)
        {
            try
            {
                export_excel();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}

