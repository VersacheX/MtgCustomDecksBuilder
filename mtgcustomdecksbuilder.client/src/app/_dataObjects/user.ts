export class User {
  constructor() {
  }

  //Data Members
  storefrontId: string = '';
  username: string = '';
  //Password: string = '';
  firstName: string = '';
  lastName: string = '';
  email: string = '';

  //Account Details
  authData?: string = '';
  tokenExpiration: string = '';


  //Storefront Data
  sfAdminID: number = 0;
  sfUserName: string = '';
  sfAdministratorStorefrontID: number = 0;
  sfLegalName: string = '';
  sfPrimaryAccount: boolean = false;
  perM_ACCOUNT_ENABLED: boolean = false;
  perM_USER_MANAGEMENT: boolean = false;
  perM_VIEW_ORDERS: boolean = false;
  perM_EDITORDER_BILLING_SHIPPING: boolean = false;
  perM_EDITORDER_ADDMODREMOVE_ITEMS: boolean = false;
  perM_CAPTUREVOIDUPDATE_PAYMENT: boolean = false;
  perM_APPROVEVOID_ORDERS: boolean = false;
  perM_ADD_TO_BLACKLIST: boolean = false;
  perM_VIEW_PRODUCTINFO: boolean = false;
  perM_EDIT_PRODUCTINFO_INCLUDINGPRICE: boolean = false;
  perM_VIEWEDIT_KEYWORDMETATAGS: boolean = false;
  perM_EDIT_SHIP_RATES: boolean = false;
  perM_VIEW_FRAUD_BLACKLIST: boolean = false;
  perM_VIEW_BUNDLES_MANAGEMENT: boolean = false;
  perM_CREATE_EDIT_BUNDLES: boolean = false;
  perM_VIEW_EMAIL_MARKETING_CAMPAIGNS: boolean = false;
  perM_CREATE_EDIT_EMAIL_MARKETING_CAMPAIGNS: boolean = false;
  perM_VIEW_COUPON_MANAGEMENT: boolean = false;
  perM_CREATE_EDIT_COUPONS: boolean = false;
  perM_VIEW_METATAGS_INFO: boolean = false;
  perM_VIEW_FRIENDLYURL_MANAGEMENT: boolean = false;
  perM_EDIT_FRIENDLYURL_MANAGEMENT: boolean = false;
  perM_VIEW_SHIP_RATES: boolean = false;
  perM_CREATE_ORDER: boolean = false;
  perM_VIEW_DROPSHIP_BILLING_INFO: boolean = false;
  perM_WEB_SERVICE: boolean = false;
}
