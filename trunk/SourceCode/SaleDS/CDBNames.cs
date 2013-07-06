using System;

namespace Sale.CDBNames
{
	/// <summary>
	/// Summary description for CDBNames.
	/// </summary>
    /// 

    public class GD_DELIVERY_ORDER_DETAIL
    {
        public const string ID = "ID";
        public const string DELIVERY_ORDER_ID = "DELIVERY_ORDER_ID";
        public const string PRODUCT_ID = "PRODUCT_ID";
        public const string QUANTITY = "QUANTITY";
    }


    public class GD_DELIVERY_ORDER
    {
        public const string ID = "ID";
        public const string DELIVERY_ORDER_CODE = "DELIVERY_ORDER_CODE";
        public const string DELIVERY_ORDER_DATE = "DELIVERY_ORDER_DATE";
        public const string REPOSITORY_ID = "REPOSITORY_ID";
        public const string USER_ID = "USER_ID";
        public const string CUSTOMER_ID = "CUSTOMER_ID";
        public const string IN_OUT_YN = "IN_OUT_YN";
    }
    public class V_RPT_DELIVERY_ODER
    {
        public const string ID = "ID";
        public const string DELIVERY_ORDER_ID = "DELIVERY_ORDER_ID";
        public const string PRODUCT_ID = "PRODUCT_ID";
        public const string QUANTITY = "QUANTITY";
        public const string DELIVERY_ORDER_CODE = "DELIVERY_ORDER_CODE";
        public const string DELIVERY_ORDER_DATE = "DELIVERY_ORDER_DATE";
        public const string PRODUCT_CODE = "PRODUCT_CODE";
        public const string PRODUCT_NAME = "PRODUCT_NAME";
        public const string UNIT_ID = "UNIT_ID";
        public const string UNIT_CODE = "UNIT_CODE";
        public const string QUANTITY_IN = "QUANTITY_IN";
        public const string QUANTITY_OUT = "QUANTITY_OUT";
    }

    public class RPT_BILL_DETAIL_SALES
    {
        public const string ID = "ID";
        public const string PRODUCT_ID = "PRODUCT_ID";
        public const string PRODUCT_CODE = "PRODUCT_CODE";
        public const string PRODUCT_NAME = "PRODUCT_NAME";
        public const string QUANTITY = "QUANTITY";
        public const string UNIT_PRICE = "UNIT_PRICE";
        public const string COST = "COST";
    }
    public class V_GD_PRODUCT_PRICE
    {
        public const string ID = "ID";
        public const string PRODUCT_ID = "PRODUCT_ID";
        public const string PRODUCT_NAME = "PRODUCT_NAME";
        public const string APPLY_DATE = "APPLY_DATE";
        public const string PRICE = "PRICE";
        public const string UNIT_ID = "UNIT_ID";
        public const string UNIT_CODE = "UNIT_CODE";
        public const string DESCRIPTION = "DESCRIPTION";
    }

    public class V_RPT_GD_BILL_DETAIL
    {
        public const string ID = "ID";
        public const string BILL_ID = "BILL_ID";
        public const string PRODUCT_ID = "PRODUCT_ID";
        public const string QUANTITY = "QUANTITY";
        public const string BILL_SERI = "BILL_SERI";
        public const string CUSTOMER_ID = "CUSTOMER_ID";
        public const string BILL_DATE = "BILL_DATE";
        public const string CUSTOMER_NAME = "CUSTOMER_NAME";
        public const string PRODUCT_NAME = "PRODUCT_NAME";
        public const string PRODUCT_CODE = "PRODUCT_CODE";
        public const string CATEGORY_NAME = "CATEGORY_NAME";
        public const string CURRENT_PRICE = "CURRENT_PRICE";
        public const string AMOUNT = "AMOUNT";
    }

    public class V_RPT_GD_BILL
    {
        public const string ID = "ID";
        public const string BILL_SERI = "BILL_SERI";
        public const string CUSTOMER_ID = "CUSTOMER_ID";
        public const string BILL_DATE = "BILL_DATE";
        public const string TAX_RATE = "TAX_RATE";
        public const string AMMOUNT = "AMMOUNT";
        public const string USER_ID = "USER_ID";
        public const string CUSTOMER_NAME = "CUSTOMER_NAME";
    }

    public class RPT_PRODUCT_BALANCE
    {
        public const string ID = "ID";
        public const string PRODUCT_ID = "PRODUCT_ID";
        public const string PRODUCT_CODE = "PRODUCT_CODE";
        public const string PRODUCT_NAME = "PRODUCT_NAME";
        public const string UNIT_ID = "UNIT_ID";
        public const string UNIT_CODE = "UNIT_CODE";
        public const string QUANTITY = "QUANTITY";
    }


    public class DM_PROVIDER
    {
        public const string ID = "ID";
        public const string PROVIDER_CODE = "PROVIDER_CODE";
        public const string PROVIDER_NAME = "PROVIDER_NAME";
        public const string MOBILE = "MOBILE";
        public const string EMAIL = "EMAIL";
        public const string ADDRESS = "ADDRESS";
        public const string TAX_CODE = "TAX_CODE";
    }

    public class DM_CATEGORY
    {
        public const string ID = "ID";
        public const string CATEGORY_CODE = "CATEGORY_CODE";
        public const string CATEGORY_NAME = "CATEGORY_NAME";
        public const string CATEGORY_PARENT_ID = "CATEGORY_PARENT_ID";
        public const string DISPLAY_ORDER = "DISPLAY_ORDER";
        public const string DISPLAY_LEVEL = "DISPLAY_LEVEL";
        public const string CATEGORY_DESCRIPTION = "CATEGORY_DESCRIPTION";
    }

    public class DM_PRODUCT_DE
    {
        public const string ID = "ID";
        public const string PRODUCT_CODE = "PRODUCT_CODE";
        public const string PRODUCT_NAME = "PRODUCT_NAME";
        public const string UNIT_ID = "UNIT_ID";
        public const string CATEGORY_ID = "CATEGORY_ID";
        public const string CATEGORY_NAME = "CATEGORY_NAME";
        public const string UNIT_NANE = "UNIT_NANE";
        public const string IMAGE_PATH = "IMAGE_PATH";
        public const string DESCRIPTION = "DESCRIPTION";
        public const string PROVIDER_ID = "PROVIDER_ID";
        public const string CURRENT_PRICE = "CURRENT_PRICE";
    }


    public class DM_UNIT
    {
        public const string ID = "ID";
        public const string UNIT_CODE = "UNIT_CODE";
        public const string DESCRIPTION = "DESCRIPTION";
    }

    public class DM_CUSTOMER_GROUP
    {
        public const string ID = "ID";
        public const string CUSTOMER_GROUP_NAME = "CUSTOMER_GROUP_NAME";
    }

    public class DM_CUSTOMER
    {
        public const string ID = "ID";
        public const string CUSTOMER_GROUP_ID = "CUSTOMER_GROUP_ID";
        public const string CUSTOMER_NAME = "CUSTOMER_NAME";
        public const string MOBLIE_PHONE = "MOBLIE_PHONE";
        public const string EMAIL = "EMAIL";
        public const string ADDRESS = "ADDRESS";
        public const string WEBSITE = "WEBSITE";
        public const string TAX_CODE = "TAX_CODE";
    }

    public class DM_COMPANY_INFO
    {
        public const string ID = "ID";
        public const string SHORT_NAME = "SHORT_NAME";
        public const string FULL_NAME = "FULL_NAME";
        public const string ADDRESS = "ADDRESS";
        public const string MOBLIE = "MOBLIE";
        public const string EMAIL = "EMAIL";
        public const string TAX_CODE = "TAX_CODE";
    }

    public class DM_REPOSITORY
    {
        public const string ID = "ID";
        public const string REPOSITORY_CODE = "REPOSITORY_CODE";
        public const string REPOSITORY_NAME = "REPOSITORY_NAME";
        public const string ADDRESS = "ADDRESS";
        public const string MOBILE = "MOBILE";
    }
    public class DM_PRODUCT
    {
        public const string ID = "ID";
        public const string PRODUCT_CODE = "PRODUCT_CODE";
        public const string PRODUCT_NAME = "PRODUCT_NAME";
        public const string UNIT_ID = "UNIT_ID";
        public const string CATEGORY_ID = "CATEGORY_ID";
        public const string IMAGE_PATH = "IMAGE_PATH";
        public const string DESCRIPTION = "DESCRIPTION";
        public const string PROVIDER_ID = "PROVIDER_ID";
        public const string CURRENT_PRICE = "CURRENT_PRICE";
    }

    public class GD_BILL
    {
        public const string ID = "ID";
        public const string BILL_SERI = "BILL_SERI";
        public const string CUSTOMER_ID = "CUSTOMER_ID";
        public const string BILL_DATE = "BILL_DATE";
        public const string TAX_RATE = "TAX_RATE";
        public const string AMMOUNT = "AMMOUNT";
        public const string USER_ID = "USER_ID";
    }

    public class GD_BILL_DETAIL
    {
        public const string ID = "ID";
        public const string BILL_ID = "BILL_ID";
        public const string PRODUCT_ID = "PRODUCT_ID";
        public const string QUANTITY = "QUANTITY";
        public const string UNIT_PRICE = "UNIT_PRICE";
    }

    public class GD_PRODUCT_PRICE
    {
        public const string ID = "ID";
        public const string PRODUCT_ID = "PRODUCT_ID";
        public const string APPLY_DATE = "APPLY_DATE";
        public const string PRICE = "PRICE";
        public const string UNIT_ID = "UNIT_ID";
    }

   
}



