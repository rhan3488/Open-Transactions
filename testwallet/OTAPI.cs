/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.31
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class OTAPI {
  public static int OT_API_Init(string szClientPath) {
    int ret = OTAPIPINVOKE.OT_API_Init(szClientPath);
    return ret;
  }

  public static int OT_API_LoadWallet(string szPath) {
    int ret = OTAPIPINVOKE.OT_API_LoadWallet(szPath);
    return ret;
  }

  public static int OT_API_ConnectServer(string SERVER_ID, string USER_ID, string szCA_FILE, string szKEY_FILE, string szKEY_PASSWORD) {
    int ret = OTAPIPINVOKE.OT_API_ConnectServer(SERVER_ID, USER_ID, szCA_FILE, szKEY_FILE, szKEY_PASSWORD);
    return ret;
  }

  public static int OT_API_ProcessSockets() {
    int ret = OTAPIPINVOKE.OT_API_ProcessSockets();
    return ret;
  }

  public static int OT_API_GetNymCount() {
    int ret = OTAPIPINVOKE.OT_API_GetNymCount();
    return ret;
  }

  public static int OT_API_GetServerCount() {
    int ret = OTAPIPINVOKE.OT_API_GetServerCount();
    return ret;
  }

  public static int OT_API_GetAssetTypeCount() {
    int ret = OTAPIPINVOKE.OT_API_GetAssetTypeCount();
    return ret;
  }

  public static int OT_API_GetAccountCount() {
    int ret = OTAPIPINVOKE.OT_API_GetAccountCount();
    return ret;
  }

  public static string OT_API_GetNym_ID(int nIndex) {
    string ret = OTAPIPINVOKE.OT_API_GetNym_ID(nIndex);
    return ret;
  }

  public static string OT_API_GetNym_Name(string NYM_ID) {
    string ret = OTAPIPINVOKE.OT_API_GetNym_Name(NYM_ID);
    return ret;
  }

  public static string OT_API_GetServer_ID(int nIndex) {
    string ret = OTAPIPINVOKE.OT_API_GetServer_ID(nIndex);
    return ret;
  }

  public static string OT_API_GetServer_Name(string SERVER_ID) {
    string ret = OTAPIPINVOKE.OT_API_GetServer_Name(SERVER_ID);
    return ret;
  }

  public static string OT_API_GetAssetType_ID(int nIndex) {
    string ret = OTAPIPINVOKE.OT_API_GetAssetType_ID(nIndex);
    return ret;
  }

  public static string OT_API_GetAssetType_Name(string ASSET_TYPE_ID) {
    string ret = OTAPIPINVOKE.OT_API_GetAssetType_Name(ASSET_TYPE_ID);
    return ret;
  }

  public static string OT_API_GetAccountWallet_ID(int nIndex) {
    string ret = OTAPIPINVOKE.OT_API_GetAccountWallet_ID(nIndex);
    return ret;
  }

  public static string OT_API_GetAccountWallet_Name(string ACCOUNT_ID) {
    string ret = OTAPIPINVOKE.OT_API_GetAccountWallet_Name(ACCOUNT_ID);
    return ret;
  }

  public static string OT_API_GetAccountWallet_Balance(string ACCOUNT_ID) {
    string ret = OTAPIPINVOKE.OT_API_GetAccountWallet_Balance(ACCOUNT_ID);
    return ret;
  }

  public static string OT_API_GetAccountWallet_Type(string ACCOUNT_ID) {
    string ret = OTAPIPINVOKE.OT_API_GetAccountWallet_Type(ACCOUNT_ID);
    return ret;
  }

  public static string OT_API_GetAccountWallet_AssetTypeID(string ACCOUNT_ID) {
    string ret = OTAPIPINVOKE.OT_API_GetAccountWallet_AssetTypeID(ACCOUNT_ID);
    return ret;
  }

  public static string OT_API_WriteCheque(string SERVER_ID, string CHEQUE_AMOUNT, string VALID_FROM, string VALID_TO, string SENDER_ACCT_ID, string SENDER_USER_ID, string CHEQUE_MEMO, string RECIPIENT_USER_ID) {
    string ret = OTAPIPINVOKE.OT_API_WriteCheque(SERVER_ID, CHEQUE_AMOUNT, VALID_FROM, VALID_TO, SENDER_ACCT_ID, SENDER_USER_ID, CHEQUE_MEMO, RECIPIENT_USER_ID);
    return ret;
  }

  public static string OT_API_LoadUserPubkey(string USER_ID) {
    string ret = OTAPIPINVOKE.OT_API_LoadUserPubkey(USER_ID);
    return ret;
  }

  public static int OT_API_VerifyUserPrivateKey(string USER_ID) {
    int ret = OTAPIPINVOKE.OT_API_VerifyUserPrivateKey(USER_ID);
    return ret;
  }

  public static string OT_API_LoadPurse(string SERVER_ID, string ASSET_TYPE_ID) {
    string ret = OTAPIPINVOKE.OT_API_LoadPurse(SERVER_ID, ASSET_TYPE_ID);
    return ret;
  }

  public static string OT_API_LoadMint(string SERVER_ID, string ASSET_TYPE_ID) {
    string ret = OTAPIPINVOKE.OT_API_LoadMint(SERVER_ID, ASSET_TYPE_ID);
    return ret;
  }

  public static string OT_API_LoadAssetContract(string ASSET_TYPE_ID) {
    string ret = OTAPIPINVOKE.OT_API_LoadAssetContract(ASSET_TYPE_ID);
    return ret;
  }

  public static string OT_API_LoadAssetAccount(string SERVER_ID, string USER_ID, string ACCOUNT_ID) {
    string ret = OTAPIPINVOKE.OT_API_LoadAssetAccount(SERVER_ID, USER_ID, ACCOUNT_ID);
    return ret;
  }

  public static string OT_API_LoadInbox(string SERVER_ID, string USER_ID, string ACCOUNT_ID) {
    string ret = OTAPIPINVOKE.OT_API_LoadInbox(SERVER_ID, USER_ID, ACCOUNT_ID);
    return ret;
  }

  public static string OT_API_LoadOutbox(string SERVER_ID, string USER_ID, string ACCOUNT_ID) {
    string ret = OTAPIPINVOKE.OT_API_LoadOutbox(SERVER_ID, USER_ID, ACCOUNT_ID);
    return ret;
  }

  public static int OT_API_Ledger_GetCount(string SERVER_ID, string USER_ID, string ACCOUNT_ID, string THE_LEDGER) {
    int ret = OTAPIPINVOKE.OT_API_Ledger_GetCount(SERVER_ID, USER_ID, ACCOUNT_ID, THE_LEDGER);
    return ret;
  }

  public static string OT_API_Ledger_CreateResponse(string SERVER_ID, string USER_ID, string ACCOUNT_ID, string ORIGINAL_LEDGER) {
    string ret = OTAPIPINVOKE.OT_API_Ledger_CreateResponse(SERVER_ID, USER_ID, ACCOUNT_ID, ORIGINAL_LEDGER);
    return ret;
  }

  public static string OT_API_Ledger_GetTransactionByIndex(string SERVER_ID, string USER_ID, string ACCOUNT_ID, string THE_LEDGER, int nIndex) {
    string ret = OTAPIPINVOKE.OT_API_Ledger_GetTransactionByIndex(SERVER_ID, USER_ID, ACCOUNT_ID, THE_LEDGER, nIndex);
    return ret;
  }

  public static string OT_API_Ledger_GetTransactionByID(string SERVER_ID, string USER_ID, string ACCOUNT_ID, string THE_LEDGER, string TRANSACTION_NUMBER) {
    string ret = OTAPIPINVOKE.OT_API_Ledger_GetTransactionByID(SERVER_ID, USER_ID, ACCOUNT_ID, THE_LEDGER, TRANSACTION_NUMBER);
    return ret;
  }

  public static string OT_API_Ledger_GetTransactionIDByIndex(string SERVER_ID, string USER_ID, string ACCOUNT_ID, string THE_LEDGER, int nIndex) {
    string ret = OTAPIPINVOKE.OT_API_Ledger_GetTransactionIDByIndex(SERVER_ID, USER_ID, ACCOUNT_ID, THE_LEDGER, nIndex);
    return ret;
  }

  public static string OT_API_Ledger_AddTransaction(string SERVER_ID, string USER_ID, string ACCOUNT_ID, string THE_LEDGER, string THE_TRANSACTION) {
    string ret = OTAPIPINVOKE.OT_API_Ledger_AddTransaction(SERVER_ID, USER_ID, ACCOUNT_ID, THE_LEDGER, THE_TRANSACTION);
    return ret;
  }

  public static string OT_API_Transaction_CreateResponse(string SERVER_ID, string USER_ID, string ACCOUNT_ID, string RESPONSE_LEDGER, string ORIGINAL_TRANSACTION, int BOOL_DO_I_ACCEPT) {
    string ret = OTAPIPINVOKE.OT_API_Transaction_CreateResponse(SERVER_ID, USER_ID, ACCOUNT_ID, RESPONSE_LEDGER, ORIGINAL_TRANSACTION, BOOL_DO_I_ACCEPT);
    return ret;
  }

  public static string OT_API_Transaction_GetType(string SERVER_ID, string USER_ID, string ACCOUNT_ID, string THE_TRANSACTION) {
    string ret = OTAPIPINVOKE.OT_API_Transaction_GetType(SERVER_ID, USER_ID, ACCOUNT_ID, THE_TRANSACTION);
    return ret;
  }

  public static void OT_API_checkServerID(string SERVER_ID, string USER_ID) {
    OTAPIPINVOKE.OT_API_checkServerID(SERVER_ID, USER_ID);
  }

  public static void OT_API_createUserAccount(string SERVER_ID, string USER_ID) {
    OTAPIPINVOKE.OT_API_createUserAccount(SERVER_ID, USER_ID);
  }

  public static void OT_API_checkUser(string SERVER_ID, string USER_ID, string USER_ID_CHECK) {
    OTAPIPINVOKE.OT_API_checkUser(SERVER_ID, USER_ID, USER_ID_CHECK);
  }

  public static void OT_API_getRequest(string SERVER_ID, string USER_ID) {
    OTAPIPINVOKE.OT_API_getRequest(SERVER_ID, USER_ID);
  }

  public static void OT_API_getTransactionNumber(string SERVER_ID, string USER_ID) {
    OTAPIPINVOKE.OT_API_getTransactionNumber(SERVER_ID, USER_ID);
  }

  public static void OT_API_issueAssetType(string SERVER_ID, string USER_ID, string THE_CONTRACT) {
    OTAPIPINVOKE.OT_API_issueAssetType(SERVER_ID, USER_ID, THE_CONTRACT);
  }

  public static void OT_API_getContract(string SERVER_ID, string USER_ID, string ASSET_ID) {
    OTAPIPINVOKE.OT_API_getContract(SERVER_ID, USER_ID, ASSET_ID);
  }

  public static void OT_API_getMint(string SERVER_ID, string USER_ID, string ASSET_ID) {
    OTAPIPINVOKE.OT_API_getMint(SERVER_ID, USER_ID, ASSET_ID);
  }

  public static void OT_API_createAssetAccount(string SERVER_ID, string USER_ID, string ASSET_ID) {
    OTAPIPINVOKE.OT_API_createAssetAccount(SERVER_ID, USER_ID, ASSET_ID);
  }

  public static void OT_API_getAccount(string SERVER_ID, string USER_ID, string ACCT_ID) {
    OTAPIPINVOKE.OT_API_getAccount(SERVER_ID, USER_ID, ACCT_ID);
  }

  public static void OT_API_issueBasket(string SERVER_ID, string USER_ID, string BASKET_INFO) {
    OTAPIPINVOKE.OT_API_issueBasket(SERVER_ID, USER_ID, BASKET_INFO);
  }

  public static void OT_API_exchangeBasket(string SERVER_ID, string USER_ID, string BASKET_ASSET_ID, string BASKET_INFO) {
    OTAPIPINVOKE.OT_API_exchangeBasket(SERVER_ID, USER_ID, BASKET_ASSET_ID, BASKET_INFO);
  }

  public static void OT_API_notarizeWithdrawal(string SERVER_ID, string USER_ID, string ACCT_ID, string AMOUNT) {
    OTAPIPINVOKE.OT_API_notarizeWithdrawal(SERVER_ID, USER_ID, ACCT_ID, AMOUNT);
  }

  public static void OT_API_notarizeDeposit(string SERVER_ID, string USER_ID, string ACCT_ID, string THE_PURSE) {
    OTAPIPINVOKE.OT_API_notarizeDeposit(SERVER_ID, USER_ID, ACCT_ID, THE_PURSE);
  }

  public static void OT_API_notarizeTransfer(string SERVER_ID, string USER_ID, string ACCT_FROM, string ACCT_TO, string AMOUNT, string NOTE) {
    OTAPIPINVOKE.OT_API_notarizeTransfer(SERVER_ID, USER_ID, ACCT_FROM, ACCT_TO, AMOUNT, NOTE);
  }

  public static void OT_API_getInbox(string SERVER_ID, string USER_ID, string ACCT_ID) {
    OTAPIPINVOKE.OT_API_getInbox(SERVER_ID, USER_ID, ACCT_ID);
  }

  public static void OT_API_processInbox(string SERVER_ID, string USER_ID, string ACCT_ID, string ACCT_LEDGER) {
    OTAPIPINVOKE.OT_API_processInbox(SERVER_ID, USER_ID, ACCT_ID, ACCT_LEDGER);
  }

  public static void OT_API_withdrawVoucher(string SERVER_ID, string USER_ID, string ACCT_ID, string RECIPIENT_USER_ID, string CHEQUE_MEMO, string AMOUNT) {
    OTAPIPINVOKE.OT_API_withdrawVoucher(SERVER_ID, USER_ID, ACCT_ID, RECIPIENT_USER_ID, CHEQUE_MEMO, AMOUNT);
  }

  public static void OT_API_depositCheque(string SERVER_ID, string USER_ID, string ACCT_ID, string THE_CHEQUE) {
    OTAPIPINVOKE.OT_API_depositCheque(SERVER_ID, USER_ID, ACCT_ID, THE_CHEQUE);
  }

}
