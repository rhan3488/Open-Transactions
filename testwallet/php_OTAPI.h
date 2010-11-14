/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.31
 * 
 * This file is not intended to be easily readable and contains a number of 
 * coding conventions designed to improve portability and efficiency. Do not make
 * changes to this file unless you know what you are doing--modify the SWIG 
 * interface file instead. 
 * ----------------------------------------------------------------------------- */

/*
  +----------------------------------------------------------------------+
  | PHP version 4.0                                                      |
  +----------------------------------------------------------------------+
  | Copyright (c) 1997, 1998, 1999, 2000, 2001 The PHP Group             |
  +----------------------------------------------------------------------+
  | This source file is subject to version 2.02 of the PHP license,      |
  | that is bundled with this package in the file LICENSE, and is        |
  | available at through the world-wide-web at                           |
  | http://www.php.net/license/2_02.txt.                                 |
  | If you did not receive a copy of the PHP license and are unable to   |
  | obtain it through the world-wide-web, please send a note to          |
  | license@php.net so we can mail you a copy immediately.               |
  +----------------------------------------------------------------------+
  | Authors:                                                             |
  |                                                                      |
  +----------------------------------------------------------------------+
 */


#ifndef PHP_OTAPI_H
#define PHP_OTAPI_H

extern zend_module_entry OTAPI_module_entry;
#define phpext_OTAPI_ptr &OTAPI_module_entry

#ifdef PHP_WIN32
# define PHP_OTAPI_API __declspec(dllexport)
#else
# define PHP_OTAPI_API
#endif

#ifdef ZTS
#include "TSRM.h"
#endif

PHP_MINIT_FUNCTION(OTAPI);
PHP_MSHUTDOWN_FUNCTION(OTAPI);
PHP_RINIT_FUNCTION(OTAPI);
PHP_RSHUTDOWN_FUNCTION(OTAPI);
PHP_MINFO_FUNCTION(OTAPI);

ZEND_NAMED_FUNCTION(_wrap_OT_API_Init);
ZEND_NAMED_FUNCTION(_wrap_OT_API_LoadWallet);
ZEND_NAMED_FUNCTION(_wrap_OT_API_connectServer);
ZEND_NAMED_FUNCTION(_wrap_OT_API_processSockets);
ZEND_NAMED_FUNCTION(_wrap_OT_API_checkServerID);
ZEND_NAMED_FUNCTION(_wrap_OT_API_createUserAccount);
ZEND_NAMED_FUNCTION(_wrap_OT_API_checkUser);
ZEND_NAMED_FUNCTION(_wrap_OT_API_getRequest);
ZEND_NAMED_FUNCTION(_wrap_OT_API_issueAssetType);
ZEND_NAMED_FUNCTION(_wrap_OT_API_getContract);
ZEND_NAMED_FUNCTION(_wrap_OT_API_getMint);
ZEND_NAMED_FUNCTION(_wrap_OT_API_createAssetAccount);
ZEND_NAMED_FUNCTION(_wrap_OT_API_getAccount);
ZEND_NAMED_FUNCTION(_wrap_OT_API_issueBasket);
ZEND_NAMED_FUNCTION(_wrap_OT_API_exchangeBasket);
ZEND_NAMED_FUNCTION(_wrap_OT_API_getTransactionNumber);
ZEND_NAMED_FUNCTION(_wrap_OT_API_notarizeWithdrawal);
ZEND_NAMED_FUNCTION(_wrap_OT_API_notarizeDeposit);
ZEND_NAMED_FUNCTION(_wrap_OT_API_notarizeTransfer);
ZEND_NAMED_FUNCTION(_wrap_OT_API_getInbox);
ZEND_NAMED_FUNCTION(_wrap_OT_API_processInbox);
ZEND_NAMED_FUNCTION(_wrap_OT_API_withdrawVoucher);
ZEND_NAMED_FUNCTION(_wrap_OT_API_depositCheque);
ZEND_NAMED_FUNCTION(_wrap_OT_API_GetNymCount);
ZEND_NAMED_FUNCTION(_wrap_OT_API_GetServerCount);
ZEND_NAMED_FUNCTION(_wrap_OT_API_GetAssetTypeCount);
ZEND_NAMED_FUNCTION(_wrap_OT_API_GetAccountCount);
ZEND_NAMED_FUNCTION(_wrap_OT_API_GetNym_ID);
ZEND_NAMED_FUNCTION(_wrap_OT_API_GetNym_Name);
ZEND_NAMED_FUNCTION(_wrap_OT_API_GetServer_ID);
ZEND_NAMED_FUNCTION(_wrap_OT_API_GetServer_Name);
ZEND_NAMED_FUNCTION(_wrap_OT_API_GetAssetType_ID);
ZEND_NAMED_FUNCTION(_wrap_OT_API_GetAssetType_Name);
ZEND_NAMED_FUNCTION(_wrap_OT_API_GetAccountWallet_ID);
ZEND_NAMED_FUNCTION(_wrap_OT_API_GetAccountWallet_Name);
#endif /* PHP_OTAPI_H */