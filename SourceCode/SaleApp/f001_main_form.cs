﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Configuration;


using System.Collections;


using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using GuiDev;
using SaleApp.UC;

namespace SaleApp
{
    public partial class f001_main_form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private IContainer components;

        public f001_main_form()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            format_controls();
            DevExpress.Skins.SkinManager.Default.RegisterAssembly(typeof(DevExpress.UserSkins.BonusSkins).Assembly);
            DevExpress.Skins.SkinManager.Default.RegisterAssembly(typeof(DevExpress.UserSkins.OfficeSkins).Assembly);
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

      



        #region public Interface
        public void display(ref IPConstants.HowUserWantTo_Exit_MainForm o_exitMode)
        {
            this.ShowDialog();
            o_exitMode = m_exitMode;
        }

        #endregion
        #region Data Structures

        #endregion

        #region Members

        IPConstants.HowUserWantTo_Exit_MainForm m_exitMode = IPConstants.HowUserWantTo_Exit_MainForm.ExitFromSystem;
        TabAdd m_obj_tab = new TabAdd();
        #endregion

        #region Private Methods
        private void close_tab_A(bool ip_y_n) {
            if(ip_y_n == true)
                m_xtab_control.TabPages.RemoveAt(m_xtab_control.SelectedTabPageIndex);
        }
        
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            this.ShowInTaskbar = true;
            set_define_events();
        }

        private void show_bao_cao_xuat_nhap_theo_ky()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.BACK_UP_AND_RESTORE))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được quyền truy nhập phần này !!! ");
                return;
            }
            f961_bao_cao_xuat_nhap_trong_ky v_frm = new f961_bao_cao_xuat_nhap_trong_ky();
            v_frm.close_tab_B = new f961_bao_cao_xuat_nhap_trong_ky.close_tab(close_tab_A);
            uc_for_form v_uc = new uc_for_form();
            m_obj_tab.AddFormToUC(v_frm, v_uc);
            m_obj_tab.AddTab(m_xtab_control, "tab_bc_xuat_nhap_ton", "Báo cáo xuất-nhập-tồn", v_uc);

            //f961_bao_cao_xuat_nhap_trong_ky v_frm_961 = new f961_bao_cao_xuat_nhap_trong_ky();
            //v_frm_961.display();
        }

        private void show_manager_user()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.BACK_UP_AND_RESTORE))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được quyền truy nhập phần này !!! ");
                return;
            }
            f999_ht_nguoi_su_dung v_frm_999 = new f999_ht_nguoi_su_dung();
            v_frm_999.display();
        }
        private void show_product_price()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.BACK_UP_AND_RESTORE))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được quyền truy nhập phần này !!! ");
                return;
            }
            f311_gd_product_price v_frm = new f311_gd_product_price();
            v_frm.close_tab_B = new f311_gd_product_price.close_tab(close_tab_A);
            uc_for_form v_uc = new uc_for_form();
            m_obj_tab.AddFormToUC(v_frm, v_uc);
            m_obj_tab.AddTab(m_xtab_control, "tab_product_price", "Cập nhật giá sản phẩm", v_uc);

            //f311_gd_product_price v_frm_311 = new f311_gd_product_price();
            //v_frm_311.display();
        }
        private void show_introduction()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f996_license_form v_frm996 = new f996_license_form();
            v_frm996.display();
            //			IP.Core.IPSystemAdmin.f996_license v_frm = new f996_license () ;
            //			v_frm.display () ;
        }

        private void show_tu_dien_phan_quyen()
        {
            //if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.CHUC_NANG))
            //{
            //    BaseMessages.MsgBox_Infor(" Người sử dụng không có quyền truy nhập phần này ! ");
            //    return;
            //}
            f100_TuDien v_frm = new f100_TuDien();
            v_frm.ShowDialog();
        }

        private void set_inital_form_load()
        {

        }
        private void show_category()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f201_dm_category v_frm = new f201_dm_category();
            v_frm.close_tab_B = new f201_dm_category.close_tab(close_tab_A);
            uc_for_form v_uc = new uc_for_form();
            m_obj_tab.AddFormToUC(v_frm, v_uc);
            m_obj_tab.AddTab(m_xtab_control, "tab_dm_category", "Nhóm sản phẩm", v_uc);
            //f201_dm_category v_frm201 = new f201_dm_category();
            //v_frm201.display();
        }

        private void show_product()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f301_dm_product v_frm = new f301_dm_product();
            v_frm.close_tab_B = new f301_dm_product.close_tab(close_tab_A);
            uc_for_form v_uc = new uc_for_form();
            m_obj_tab.AddFormToUC(v_frm, v_uc);
            m_obj_tab.AddTab(m_xtab_control, "tab_dm_product", "Sản phẩm", v_uc);
            //f301_dm_product v_frm301 = new f301_dm_product();
            //v_frm301.display();
        }

        /// <summary>
        /// Show form danh mục quản lý đơn vị 
        /// </summary>
        private void show_unit_product()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f901_dm_unit v_frm = new f901_dm_unit();
            v_frm.close_tab_B = new f901_dm_unit.close_tab(close_tab_A);
            uc_for_form v_uc = new uc_for_form();
            m_obj_tab.AddFormToUC(v_frm, v_uc);
            m_obj_tab.AddTab(m_xtab_control, "tab_unit", "Đơn vị tính", v_uc);

            //f901_dm_unit v_frm901 = new f901_dm_unit();
            //v_frm901.display();
        }
        private void show_provider()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f701_dm_provider v_frm = new f701_dm_provider();
            v_frm.close_tab_B = new f701_dm_provider.close_tab(close_tab_A);
            uc_for_form v_uc = new uc_for_form();
            m_obj_tab.AddFormToUC(v_frm, v_uc);
            m_obj_tab.AddTab(m_xtab_control, "tab_provider", "Nhà cung cấp", v_uc);
            //f701_dm_provider v_frm701 = new f701_dm_provider();
            //v_frm701.display();
        }
        private void show_repository()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f801_dm_repository v_frm = new f801_dm_repository();
            v_frm.close_tab_B = new f801_dm_repository.close_tab(close_tab_A);
            uc_for_form v_uc = new uc_for_form();
            m_obj_tab.AddFormToUC(v_frm, v_uc);
            m_obj_tab.AddTab(m_xtab_control, "tab_responsitory", "Kho", v_uc);

            //f801_dm_repository v_frm801 = new f801_dm_repository();
            //v_frm801.display();
        }
        private void show_form_nhap_so_du_dau()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f321_nhap_so_du_hang_hoa v_frm = new f321_nhap_so_du_hang_hoa();
            v_frm.close_tab_B = new f321_nhap_so_du_hang_hoa.close_tab(close_tab_A);
            uc_for_form v_uc = new uc_for_form();
            m_obj_tab.AddFormToUC(v_frm, v_uc);
            m_obj_tab.AddTab(m_xtab_control, "tab_so_du_dau", "Nhập số dư đầu", v_uc);

            //f321_nhap_so_du_hang_hoa v_frm321 = new f321_nhap_so_du_hang_hoa();
            //v_frm321.display();
        }

        private void show_customer()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f501_dm_customer v_frm = new f501_dm_customer();
            v_frm.close_tab_B = new f501_dm_customer.close_tab(close_tab_A);
            uc_for_form v_uc = new uc_for_form();
            m_obj_tab.AddFormToUC(v_frm, v_uc);
            m_obj_tab.AddTab(m_xtab_control, "tab_customer", "Khách hàng", v_uc);


            //f501_dm_customer v_frm501 = new f501_dm_customer();
            //v_frm501.display();
        }
        private void show_customer_group()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f601_dm_customer_group v_frm = new f601_dm_customer_group();
            v_frm.close_tab_B = new f601_dm_customer_group.close_tab(close_tab_A);
            uc_for_form v_uc = new uc_for_form();
            m_obj_tab.AddFormToUC(v_frm, v_uc);
            m_obj_tab.AddTab(m_xtab_control, "tab_group_customer", "Nhóm khách hàng", v_uc);

            //f601_dm_customer_group v_frm601 = new f601_dm_customer_group();
            //v_frm601.display();
        }
        private void show_company_info()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }

            //f401_dm_company_info v_frm401 = new f401_dm_company_info();
            //v_frm401.display();
            f401_dm_company_info v_frm = new f401_dm_company_info();
            v_frm.close_tab_B = new f401_dm_company_info.close_tab(close_tab_A);
            uc_for_form v_uc = new uc_for_form();
            m_obj_tab.AddFormToUC(v_frm, v_uc);
            m_obj_tab.AddTab(m_xtab_control, "tab_company", "Cửa hàng", v_uc);
    
        }
        private void show_bao_cao_theo_nhom()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f921_bao_cao_theo_nhom v_frm = new f921_bao_cao_theo_nhom();
            v_frm.close_tab_B = new f921_bao_cao_theo_nhom.close_tab(close_tab_A);
            uc_for_form v_uc = new uc_for_form();
            m_obj_tab.AddFormToUC(v_frm, v_uc);
            m_obj_tab.AddTab(m_xtab_control, "tab_bc_nhom_hang", "Báo cáo theo nhóm hàng", v_uc);
            //f921_bao_cao_theo_nhom v_frm921 = new f921_bao_cao_theo_nhom();
            //v_frm921.display();
        }
        private void show_form_ban_hang()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không đươc phép truy nhập phần này !!! ");
                return;
            }
            f331_xuat_ban_hang v_frm = new f331_xuat_ban_hang();
            v_frm.close_tab_B = new f331_xuat_ban_hang.close_tab(close_tab_A);
            uc_for_form v_uc = new uc_for_form();
            m_obj_tab.AddFormToUC(v_frm, v_uc);
            m_obj_tab.AddTab(m_xtab_control, "tab_xuat_hang", "Xuất hàng", v_uc);
            //f331_xuat_ban_hang v_frm331 = new f331_xuat_ban_hang();
            //v_frm331.display();
        }

        private void show_rpt_doanh_thu_ban_hang_theo_ky()
        {
            //f932_bao_cao_doanh_thu_theo_ky v_frm932 = new f932_bao_cao_doanh_thu_theo_ky();
            //v_frm932.display();
            f932_bao_cao_doanh_thu_theo_ky v_frm = new f932_bao_cao_doanh_thu_theo_ky();
            v_frm.close_tab_B = new f932_bao_cao_doanh_thu_theo_ky.close_tab(close_tab_A);
            uc_for_form v_uc = new uc_for_form();
            m_obj_tab.AddFormToUC(v_frm, v_uc);
            m_obj_tab.AddTab(m_xtab_control, "tab_bc_doanh_thu", "Báo cáo doanh thu theo kỳ", v_uc);

        }
        private void show_rpt_doanh_thu_ban_hang_theo_mat_hang()
        {
            //f931_bao_cao_theo_hang v_frm931 = new f931_bao_cao_theo_hang();
            //v_frm931.display();
            f931_bao_cao_theo_hang v_frm = new f931_bao_cao_theo_hang();
            v_frm.close_tab_B = new f931_bao_cao_theo_hang.close_tab(close_tab_A);
            uc_for_form v_uc = new uc_for_form();
            m_obj_tab.AddFormToUC(v_frm, v_uc);
            m_obj_tab.AddTab(m_xtab_control, "tab_bc_theo_mat_hang", "Báo cáo theo mặt hàng", v_uc);

        }

        private void show_employee()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }

            f401_dm_company_info v_frm401 = new f401_dm_company_info();
            v_frm401.display();
        }

        private void show_nhap_xuat()
        {
            f351_nhap_hang_nha_san_xuat v_frm = new f351_nhap_hang_nha_san_xuat();
            v_frm.close_tab_B = new f351_nhap_hang_nha_san_xuat.close_tab(close_tab_A);
            uc_for_form v_uc = new uc_for_form();
            m_obj_tab.AddFormToUC(v_frm, v_uc);
            m_obj_tab.AddTab(m_xtab_control, "tab_nhap_xuat", "Nhập hàng từ NCC", v_uc);

            //f351_nhap_hang_nha_san_xuat v_frm351 = new f351_nhap_hang_nha_san_xuat();
            //v_frm351.display();
        }
        private void show_phieu_nhap_xuat_trong_ky()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f971_danh_sach_phieu_nhap_xuat_trong_ky v_frm = new f971_danh_sach_phieu_nhap_xuat_trong_ky();
            v_frm.close_tab_B = new f971_danh_sach_phieu_nhap_xuat_trong_ky.close_tab(close_tab_A);
            uc_for_form v_uc = new uc_for_form();
            m_obj_tab.AddFormToUC(v_frm, v_uc);
            m_obj_tab.AddTab(m_xtab_control, "tab_ds_phieu_nhap_xuat", "Danh sách phiếu nhập xuất trong kỳ", v_uc);

            //f971_danh_sach_phieu_nhap_xuat_trong_ky v_frm971 = new f971_danh_sach_phieu_nhap_xuat_trong_ky();
            //v_frm971.display();
        }        
        #endregion
        //
        //
        //   event handlers
        //
        //
        private void set_define_events()
        {
            m_xtab_control.CloseButtonClick += m_xtab_control_CloseButtonClick;
        }

        void m_xtab_control_CloseButtonClick(object sender, EventArgs e) {
            try {
                m_xtab_control.TabPages.RemoveAt(m_xtab_control.SelectedTabPageIndex);
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_user_management_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                show_manager_user();

            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void mnu_directory_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

                show_tu_dien_phan_quyen();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
           
        }


        private void mnu_type_of_directory_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {


            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (BaseMessages.MsgBox_Confirm("Bạn có thật sự muốn kết thúc chương trình không ? "))
                {
                    m_exitMode = IPConstants.HowUserWantTo_Exit_MainForm.ExitFromSystem;
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_category_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                show_category();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_product_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                show_product();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_dm_unit_product_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                show_unit_product();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_license_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

                show_introduction();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_dm_repository_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                show_repository();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void mnu_dm_provider_ItemClick(object sender, ItemClickEventArgs e)
        {

            try
            {

                show_provider();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_product_price_ItemClick(object sender, ItemClickEventArgs e)
        {
             try
            {

                show_product_price();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
           
        }

        private void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {
            string SkinName = barEditItem1.EditValue.ToString();//lấy tên giao diện được chọn.
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SkinName);//đổi giao diện thành giao diện được chọn.            
            //lưu giao diện được chọn vào file config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["SkinName"].Value = SkinName;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSetting");
        }

        private void f001_main_form_Load(object sender, EventArgs e)
        {
            string SkinName = ConfigurationManager.AppSettings["SkinName"];//lấy tên giao diện được chọn đã lưu trong file config
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SkinName);
            barEditItem1.EditValue = SkinName;
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void mnu_dm_customer_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                show_customer();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_cmd_sodudau_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                show_form_nhap_so_du_dau();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


        private void mnu_dm_goupcustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                show_customer_group();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_dm_employee_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                show_company_info();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_cmd_xuatbanhang_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

                show_form_ban_hang();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_bc_banhang_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                show_rpt_doanh_thu_ban_hang_theo_ky();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_mnu_bc_theo_hang_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                show_rpt_doanh_thu_ban_hang_theo_mat_hang();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_cmd_employee_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                show_employee();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_cmd_kiemkehanghoa_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void mnu_bao_cao_theo_nhom_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                show_bao_cao_theo_nhom();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_cmd_hangnhacungcap_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                show_nhap_xuat();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_bc_xuatnhapton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                show_bao_cao_xuat_nhap_theo_ky();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_phieu_nhap_xuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                show_phieu_nhap_xuat_trong_ky();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}