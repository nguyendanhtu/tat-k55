﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaleDS.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=INT-TUND;Initial Catalog=Auction_ACBS;Integrated Security=True")]
        public string Auction_ACBSConnectionString {
            get {
                return ((string)(this["Auction_ACBSConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(local)\\sqlexpress;Initial Catalog=Auction_IBS;Integrated Security=Tr" +
            "ue")]
        public string Auction_IBSConnectionString {
            get {
                return ((string)(this["Auction_IBSConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=TUND-PC\\SQLEXPRESS;Initial Catalog=QuanLyDien;User ID=sa;Password=sa")]
        public string QuanLyDienConnectionString {
            get {
                return ((string)(this["QuanLyDienConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=VIETNAM-TEAM\\SQLEXPRESS;Initial Catalog=QuanLyBaoHiem;Persist Securit" +
            "y Info=True;User ID=sa;Password=sa")]
        public string QuanLyBaoHiemConnectionString {
            get {
                return ((string)(this["QuanLyBaoHiemConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=VIETNAM-TEAM\\SQLEXPRESS;Initial Catalog=QuanLyBaoHiem;Integrated Secu" +
            "rity=True")]
        public string QuanLyBaoHiemConnectionString1 {
            get {
                return ((string)(this["QuanLyBaoHiemConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=TUND-PC\\SQL2005;Initial Catalog=QuanLyBanHang;Integrated Security=Tru" +
            "e")]
        public string QuanLyBanHangConnectionString {
            get {
                return ((string)(this["QuanLyBanHangConnectionString"]));
            }
        }
    }
}