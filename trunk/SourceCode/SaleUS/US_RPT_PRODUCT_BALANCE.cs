///************************************************
/// Generated by: tund
/// Date: 23/08/2011 07:23:32
/// Goal: Create User Service Class for RPT_PRODUCT_BALANCE
///************************************************
/// <summary>
/// Create User Service Class for RPT_PRODUCT_BALANCE
/// </summary>


using SaleDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;


namespace SaleUS
{
public class US_RPT_PRODUCT_BALANCE : US_Object
{
	private const string c_TableName = "RPT_PRODUCT_BALANCE";
#region Public Properties
	public decimal dcID 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID"] = value;
		}
	}

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
	}

	public string strPRODUCT_ID 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "PRODUCT_ID", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["PRODUCT_ID"] = value;
		}
	}

	public bool IsPRODUCT_IDNull() 
	{
		return pm_objDR.IsNull("PRODUCT_ID");
	}

	public void SetPRODUCT_IDNull() {
		pm_objDR["PRODUCT_ID"] = System.Convert.DBNull;
	}

	public string strPRODUCT_CODE 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "PRODUCT_CODE", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["PRODUCT_CODE"] = value;
		}
	}

	public bool IsPRODUCT_CODENull() 
	{
		return pm_objDR.IsNull("PRODUCT_CODE");
	}

	public void SetPRODUCT_CODENull() {
		pm_objDR["PRODUCT_CODE"] = System.Convert.DBNull;
	}

	public string strPRODUCT_NAME 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "PRODUCT_NAME", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["PRODUCT_NAME"] = value;
		}
	}

	public bool IsPRODUCT_NAMENull() 
	{
		return pm_objDR.IsNull("PRODUCT_NAME");
	}

	public void SetPRODUCT_NAMENull() {
		pm_objDR["PRODUCT_NAME"] = System.Convert.DBNull;
	}

	public decimal dcUNIT_ID 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "UNIT_ID", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["UNIT_ID"] = value;
		}
	}

	public bool IsUNIT_IDNull()	{
		return pm_objDR.IsNull("UNIT_ID");
	}

	public void SetUNIT_IDNull() {
		pm_objDR["UNIT_ID"] = System.Convert.DBNull;
	}

	public string strUNIT_CODE 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "UNIT_CODE", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["UNIT_CODE"] = value;
		}
	}

	public bool IsUNIT_CODENull() 
	{
		return pm_objDR.IsNull("UNIT_CODE");
	}

	public void SetUNIT_CODENull() {
		pm_objDR["UNIT_CODE"] = System.Convert.DBNull;
	}

	public decimal dcQUANTITY 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "QUANTITY", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["QUANTITY"] = value;
		}
	}

	public bool IsQUANTITYNull()	{
		return pm_objDR.IsNull("QUANTITY");
	}

	public void SetQUANTITYNull() {
		pm_objDR["QUANTITY"] = System.Convert.DBNull;
	}

    public decimal dcCATEGORY_ID
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "CATEGORY_ID", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["CATEGORY_ID"] = value;
        }
    }

    public bool IsCATEGORY_IDNull()
    {
        return pm_objDR.IsNull("CATEGORY_ID");
    }

    public void SetCATEGORY_IDNull()
    {
        pm_objDR["CATEGORY_ID"] = System.Convert.DBNull;
    }

    public decimal dcREPOSITORY_ID
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "REPOSITORY_ID", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["REPOSITORY_ID"] = value;
        }
    }

    public bool IsREPOSITORY_IDNull()
    {
        return pm_objDR.IsNull("REPOSITORY_ID");
    }

    public void SetREPOSITORY_IDNull()
    {
        pm_objDR["REPOSITORY_ID"] = System.Convert.DBNull;
    }
    public DateTime datBALLANCE_DATE
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "BALLANCE_DATE", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["BALLANCE_DATE"] = value;
		}
	}

	public bool IsBALLANCE_DATENull()
	{
		return pm_objDR.IsNull("BALLANCE_DATE");
	}

	public void SetBALLANCE_DATENull()
	{
		pm_objDR["BALLANCE_DATE"] = System.Convert.DBNull;
	}
#endregion


#region Init Functions
	public US_RPT_PRODUCT_BALANCE() 
	{
		pm_objDS = new DS_RPT_PRODUCT_BALANCE();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_RPT_PRODUCT_BALANCE(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_RPT_PRODUCT_BALANCE(decimal i_dbID) 
	{
		pm_objDS = new DS_RPT_PRODUCT_BALANCE();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion


    #region Addtional Methods
    public void FillDataset(DS_RPT_PRODUCT_BALANCE op_ds_product_balance
        , DateTime ip_dat_balance_date
        , decimal ip_dc_category_id
        , decimal ip_repository_id)
    {
        CStoredProc v_obj_procedure = new CStoredProc("pr_RPT_PRODUCT_BALANCE_Select");
        v_obj_procedure.addDatetimeInputParam("@ip_balance_date", ip_dat_balance_date);
        v_obj_procedure.addDecimalInputParam("@ip_category_id", ip_dc_category_id);
        v_obj_procedure.addDecimalInputParam("@ip_repository_id", ip_repository_id);

        v_obj_procedure.fillDataSetByCommand(this, op_ds_product_balance);
    }

    public void FillDataset(DS_RPT_PRODUCT_BALANCE op_ds_product_balance
        , DateTime ip_dat_balance_date
        , decimal ip_repository_id)
    {
        CStoredProc v_obj_procedure = new CStoredProc("pr_RPT_PRODUCT_BALANCE_Select_all_categories");
        v_obj_procedure.addDatetimeInputParam("@ip_balance_date", ip_dat_balance_date);
        v_obj_procedure.addDecimalInputParam("@ip_repository_id", ip_repository_id);

        v_obj_procedure.fillDataSetByCommand(this, op_ds_product_balance);
    }
#endregion

  }
}