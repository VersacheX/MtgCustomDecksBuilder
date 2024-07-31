using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Printing;

namespace MtgCustomDecksBuilder.Server.Models.Identity
{
    public class UserCredential
    {
        public string AuthData { get; set; }
        public string TokenExpiration { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive numbers allowed")]
        public string StorefrontId { get; set; }

        [StringLength(75, MinimumLength = 3)]
        [Required]
        public string? Username { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(25, MinimumLength = 5)]
        [Required]
        public string? Password { get; set; }


        public int SFAdminID { get; set; }
        [AllowNull]
        public string SFUserName { get; set; }
        public int SFAdministratorStorefrontID { get; set; }
        [AllowNull]
        public string SFLegalName { get; set; }
        public bool SFPrimaryAccount { get; set; }


        public bool PERM_ACCOUNT_ENABLED { get; set; }
        public bool PERM_USER_MANAGEMENT { get; set; }
        public bool PERM_VIEW_ORDERS { get; set; }
        public bool PERM_EDITORDER_BILLING_SHIPPING { get; set; }
        public bool PERM_EDITORDER_ADDMODREMOVE_ITEMS { get; set; }
        public bool PERM_CAPTUREVOIDUPDATE_PAYMENT { get; set; }
        public bool PERM_APPROVEVOID_ORDERS { get; set; }
        public bool PERM_ADD_TO_BLACKLIST { get; set; }
        public bool PERM_VIEW_PRODUCTINFO { get; set; }
        public bool PERM_EDIT_PRODUCTINFO_INCLUDINGPRICE { get; set; }
        public bool PERM_VIEWEDIT_KEYWORDMETATAGS { get; set; }
        public bool PERM_EDIT_SHIP_RATES { get; set; }
        public bool PERM_VIEW_FRAUD_BLACKLIST { get; set; }
        public bool PERM_VIEW_BUNDLES_MANAGEMENT { get; set; }
        public bool PERM_CREATE_EDIT_BUNDLES { get; set; }
        public bool PERM_VIEW_EMAIL_MARKETING_CAMPAIGNS { get; set; }
        public bool PERM_CREATE_EDIT_EMAIL_MARKETING_CAMPAIGNS { get; set; }
        public bool PERM_VIEW_COUPON_MANAGEMENT { get; set; }
        public bool PERM_CREATE_EDIT_COUPONS { get; set; }
        public bool PERM_VIEW_METATAGS_INFO { get; set; }
        public bool PERM_VIEW_FRIENDLYURL_MANAGEMENT { get; set; }
        public bool PERM_EDIT_FRIENDLYURL_MANAGEMENT { get; set; }
        public bool PERM_VIEW_SHIP_RATES { get; set; }
        public bool PERM_CREATE_ORDER { get; set; }
        public bool PERM_VIEW_DROPSHIP_BILLING_INFO { get; set; }
        public bool PERM_WEB_SERVICE { get; set; }


        public int Admin_WarehouseID { get; set; }
        public int Admin_ProviderID { get; set; }
        [AllowNull]
        public string Admin_WarehouseName { get; set; }
        [AllowNull]
        public string Admin_ProviderName { get; set; }
        public int AdminID { get; set; }
        public int Admin_Auth_AdminID { get; set; }
        [AllowNull]
        public string Admin_Auth_UserName { get; set; }
        [AllowNull]
        public string Admin_Auth_Password { get; set; }
        [AllowNull]
        public string Admin_Auth_EmailAddress { get; set; }
        public bool Admin_Auth_AccountEnabled { get; set; }
        public bool Admin_Auth_SysAdmin { get; set; }
        public bool Admin_Auth_PickPacking { get; set; }
        public bool Admin_Auth_CreateEditPO { get; set; }
        public bool Admin_Auth_ViewPO { get; set; }
        public bool Admin_Auth_ReceiveInvForPO { get; set; }
        public bool Admin_Auth_AdjustInventory { get; set; }
        public bool Admin_Auth_AddEditProdsExceptPrice { get; set; }
        public bool Admin_Auth_AddEditProdsIncludingPrice { get; set; }
        public bool Admin_Auth_ViewMarketingInfo { get; set; }
        public bool Admin_Auth_StorefrontManagement { get; set; }
        public bool Admin_Auth_CreateEditWholesaleOrders { get; set; }
        public bool Admin_Auth_EditCriticalData { get; set; }
        public bool Admin_Auth_EditVendors { get; set; }
        public bool Admin_Auth_CreateEditRO { get; set; }
        public bool Admin_Auth_CreateBoxSugg { get; set; }
        public bool Admin_Auth_EditTimeSheets { get; set; }
        public bool Admin_Auth_CustomerReturns { get; set; }
        public bool Admin_Auth_ViewDropshipBillingInfo { get; set; }
        public bool Admin_Auth_CreateEditDropshipBillingInfo { get; set; }
        public bool Admin_Auth_CreateOrderBatches { get; set; }
        public bool Admin_Auth_EditWholesaleOrdersPayments { get; set; }
        public bool Admin_Auth_Supervisor { get; set; }
        public bool Admin_Auth_SalesSupervisor { get; set; }
        public bool Admin_Auth_CreateEditWholesaleOrdersWithSensitiveInfo { get; set; }
        public bool Admin_Auth_SalesRepBasic { get; set; }
        public bool Admin_Auth_CreateEditInterProviderBilling { get; set; }

    }
}
