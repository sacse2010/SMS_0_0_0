
var simsCommonManager = {
    
    GetHierarchyCompany: function () {
        var objCompany = "";
        var jsonParam = "";
        var serviceUrl = "../Company/GetMotherCompany/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {
            objCompany = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objCompany;
    },
    
    GenerateBranchCombo: function (companyId) {
        var objBranch = "";
        var jsonParam = "companyId=" + companyId;
        var serviceUrl = "../../Branch/GetBranchByCompanyIdForCombo/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {
            objBranch = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objBranch;
    },
    GenerateAllBranchCombo: function (rootCompanyId) {
        var objBranch = "";
        var jsonParam = "rootCompanyId=" + rootCompanyId;
        var serviceUrl = "../../Branch/GetAllBranchByCompanyIdForCombo/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {
            objBranch = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objBranch;
    },
    
    GetDepartmentByCompanyId: function (companyId) {
        var objDepartment = "";
        var jsonParam = "companyId=" + companyId;
        var serviceUrl = "../../Department/GetDepartmentByCompanyId/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {

            objDepartment = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objDepartment;
    },

    GetEmployeeByCompanyIdAndBranchIdAndDepartmentId: function (companyId, branchId, departmentId) {
        var objEmployee = "";
        var jsonParam = "companyId=" + companyId + "&branchId=" + branchId + "&departmentId=" + departmentId;
        var serviceUrl = "../../Employee/GetEmployeeByCompanyIdAndBranchIdAndDepartmentId/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {

            objEmployee = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objEmployee;
    },

    GetEmployeeByDepartmentId: function (departmentId) {
        var objEmployee = "";
        var jsonParam = "departmentId=" + departmentId;
        var serviceUrl = "../../Employee/GenerateEmployeeByDepartmentId/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {

            objEmployee = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objEmployee;
    },
    
    GetEmployeeType: function () {
        var objEmployeeType = "";
        var jsonParam = "";

        var serviceUrl = "../../Employee/GetEmployeeTypeForCombo/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {
            objEmployeeType = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objEmployeeType;
    },
    
    GetSalaryStatus: function () {
        var objEmployeeType = "";
        var jsonParam = "";

        var serviceUrl = "../../Status/GetSalaryStatus/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {
            objEmployeeType = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objEmployeeType;
    },
    
    GetPayrollStatus: function () {
        var objEmployeeType = "";
        var jsonParam = "";

        var serviceUrl = "../../Status/GetPayrollStatus/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {
            objEmployeeType = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objEmployeeType;
    },
    
    GetBonusStatus: function () {
        var objEmployeeType = "";
        var jsonParam = "";

        var serviceUrl = "../../Status/GetBonusStatus/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {
            objEmployeeType = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objEmployeeType;
    },
    
    GetProjectStatus: function () {
    
        var objEmployeeType = "";
        var jsonParam = "";

        var serviceUrl = "../Status/GetProjectStatus/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {
            objEmployeeType = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objEmployeeType;
    },
    
    GetCoffStatus: function () {
        var objStatus = "";
        var jsonParam = "";
        var serviceUrl = "../Status/GetCoffStatus/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {
            objStatus = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objStatus;
    },
    
    GetLeaveForwadingStatus: function () {
        var objStatus = "";
        var jsonParam = "";
        var serviceUrl = "../Status/GetLeaveForwadingStatus/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {
            objStatus = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objStatus;
    },
    
    GetAccessPermissionForCurrentUserForHrAccountsModule: function () {
        var objEmployeeType = "";
        var jsonParam = "";

        var serviceUrl = "../../Status/GetAccessPermissionForCurrentUserForHrAccountsModule/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {
            objEmployeeType = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objEmployeeType;
    },
    
    GetActionButtonByState: function (stateId) {
        var objAction = "";
        var jsonParam = "stateId=" + stateId;
        var serviceUrl = "../Status/GetActionByStateIdAndUserId/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {
            objAction = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objAction;
    },

    
    GetClient: function (companyId) {
        var objClient = "";
        var jsonParam = "companyId=" + companyId;
        var serviceUrl = "../Client/GetClient/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {
            objClient = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objClient;
    },
    
    GenerateDesignationCombo: function (companyId) {
        var objDesignation = "";
        var jsonParam = "companyId=" + companyId + "&status=" + 1;
        var serviceUrl = "../Designation/GetAllDesignationByCompanyIdAndStatus/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {
            objDesignation = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objDesignation;
    },
    
    GenerateDesignationByDepartmentIdCombo: function (departmentId) {
        var objDesignation = "";
        var jsonParam = "departmentId=" + departmentId + "&status=" + 1;
        var serviceUrl = "../Designation/GenerateDesignationByDepartmentIdCombo/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {
            objDesignation = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objDesignation;
    },
   



    GetTrainingType: function () {
        var obj = "";
        var JsonParam = "";
        var serviceUrl = "../TrainingInfo/GetTrainingTypeForCombo";
        AjaxManager.GetJsonResult(serviceUrl, JsonParam, false, false, onSuccess, onFailed);
        function onSuccess(jsonData) {

            obj = jsonData;
        }
        function onFailed() {
            window.alert(error.statusText);
        }

        return obj;
    },

    GetDataForAnyCombo: function (serviceUrl) {
        var obj = "";
        var JsonParam = "";
        //var serviceUrl = "../TrainingInfo/GetTrainingTypeForCombo";
        AjaxManager.GetJsonResult(serviceUrl, JsonParam, false, false, onSuccess, onFailed);
        function onSuccess(jsonData) {

            obj = jsonData;
        }
        function onFailed() {
            window.alert(error.statusText);
        }

        return obj;
    },
    
    GenerateCommonGrid: function (ctlId,url,columns) {
        $("#" + ctlId).kendoGrid({
            dataSource: simsCommonManager.gridDataSource(url),
            pageable: {
                refresh: true,
                serverPaging: true,
                serverFiltering: true,
                serverSorting: true
            },
            filterable: true,
            sortable: true,
            columns: columns,
            editable: false,
            navigatable: true,
            selectable: "row",
        });
    },

    gridDataSource: function (url) {
        var gridDataSource = new kendo.data.DataSource({
            type: "json",
            serverPaging: true,

            serverSorting: true,

            serverFiltering: true,

            allowUnsort: true,

            pageSize: 10,

            transport: {
                read: {
                    //url: '../AccessControl/GetAccessControlSummary/',
                    url:url,

                    type: "POST",

                    dataType: "json",

                    contentType: "application/json; charset=utf-8"
                },
                update: {
                    //url: '../AccessControl/GetAccessControlSummary/',
                    url:url,
                    dataType: "json"
                },

                parameterMap: function (options) {

                    return JSON.stringify(options);

                }
            },
            schema: { data: "Items", total: "TotalCount" }
        });
        return gridDataSource;
    },
    
  

    GetBranchInfoByBranchId: function (branchId) {
        var objBranch = "";
        var jsonParam = "branchId=" + branchId;
        var serviceUrl = "../../Branch/GetBranchInfoByBranchId/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {

            objBranch = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objBranch;
    },
    
 
   
   
    
    GetDiscountAmountByType: function (discountType) {
        var objDiscount = "";
        var jsonParam = "discountType=" + discountType;
        var serviceUrl = "../../Discount/GetDiscountInfoByType/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {

            objDiscount = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objDiscount;
    },
    
    GetDiscountTypeCombo: function () {
        var objDiscountType = "";
        var jsonParam = "";
        var serviceUrl = "../../Discount/GetDiscountTypeCombo/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {
            objDiscountType = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objDiscountType;
    },
    
    GetAllItemData: function () {
        var objModel = "";
        var jsonParam = "";
        var serviceUrl = "../Product/GetAllItemForCombo/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);
        function onSuccess(jsonData) {
            objModel = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return objModel;
    },
    
    GetUserLevel: function (module) {
        var isRootLevelUser = "";
        var jsonParam = "module="+module;
        var serviceUrl = "../Common/CheckIsRootLevelAdmin/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);
        function onSuccess(jsonData) {
            isRootLevelUser = jsonData;
        }
        function onFailed(error) {
        }
        return isRootLevelUser;
    },
    GetAllPaymentTypeData: function () {
        var obj = "";
        var jsonParam = "";
        var serviceUrl = "../Common/GetAllPaymentTypeData/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);
        function onSuccess(jsonData) {
            obj = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return obj;
    },
    GetAllSupplierData: function () {
        var obj = "";
        var jsonParam = "";
        var serviceUrl = "../Common/GetAllSupplierData/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);
        function onSuccess(jsonData) {
            obj = jsonData;
        }
        function onFailed(error) {
            window.alert(error.statusText);
        }
        return obj;
    },

};


var simsCommonHelper = {
    
    initePanelBer: function (ctlDivId) {
        var original = $("#" + ctlDivId).clone(true);
        original.find(".k-state-active").removeClass("k-state-active");

        $(".configuration input").change(function () {
            var panelBar = $("#" + ctlDivId),
                clone = original.clone(true);

            panelBar.data("kendoPanelBar").collapse($("#" + ctlDivId + " .k-link"));

            panelBar.replaceWith(clone);

            initPanelBar();
        });

        var initPanelBar = function () {
            $("#" + ctlDivId).kendoPanelBar({ animation: { expand: { duration: 500, } } });
        };

        initPanelBar();

    },
    GenerareHierarchyCompanyCombo: function (identity) {
        var objCompany = simsCommonManager.GetHierarchyCompany();
        $("#" + identity).kendoComboBox({
            placeholder: "Select Company",
            dataTextField: "CompanyName",
            dataValueField: "CompanyId",
            dataSource: objCompany,
            
        });
    },
    
    GenerateBranchCombo: function (companyId, identity) {
        var objBranch = simsCommonManager.GenerateBranchCombo(companyId);
        $("#" + identity).kendoComboBox({
            placeholder: "All",
            dataTextField: "BranchName",
            dataValueField: "BranchId",
            dataSource: objBranch,
            
            change: function () {
                AjaxManager.isValidItem(identity, true);
            }
        });
    },
    GenerateAllBranchCombo: function (rootCompanyId, identity) {
        var objBranch = simsCommonManager.GenerateAllBranchCombo(rootCompanyId);
        $("#" + identity).kendoComboBox({
            placeholder: "All",
            dataTextField: "BranchName",
            dataValueField: "BranchId",
            dataSource: objBranch
        });
    },
    
   
    GetDepartmentByCompanyId: function (companyId, identity) {
        var objDepartment = new Object();

        objDepartment = simsCommonManager.GetDepartmentByCompanyId(companyId);

        $("#" + identity).kendoComboBox({
            placeholder: "Select Department",
            dataTextField: "DepartmentName",
            dataValueField: "DepartmentId",
            dataSource: objDepartment
        });

    },
    
   
   
    commonValidator: function (ctlId) {
        var data = [];
        var validator = $("#" + ctlId).kendoValidator().data("kendoValidator"),
            status = $(".status");
        if (validator.validate()) {
            status.text("").addClass("valid");
            return true;
        } else {
            status.text("Oops! There is invalid data in the form.").addClass("invalid");
            return false;
        }

    },
    
   
    initePanelBer: function (ctlDivId) {
        var original = $("#" + ctlDivId).clone(true);
        original.find(".k-state-active").removeClass("k-state-active");

        $(".configuration input").change(function () {
            var panelBar = $("#" + ctlDivId),
                clone = original.clone(true);

            panelBar.data("kendoPanelBar").collapse($("#" + ctlDivId + " .k-link"));

            panelBar.replaceWith(clone);

            initPanelBar();
        });

        var initPanelBar = function () {
            $("#" + ctlDivId).kendoPanelBar({ animation: { expand: { duration: 500, } } });
        };

        initPanelBar();

    },
    
  

  
    GenerateItemCombo: function (identity) {
        
        var objModel = simsCommonManager.GetAllItemData();
        $("#" + identity).kendoComboBox({
            placeholder: "Select Item",
            dataTextField: "ItemName",
            dataValueField: "ItemId",
            dataSource: objModel,
            suggest: true,
            change: function () {
                AjaxManager.isValidItem(identity, true);
            }
        });
    },
    GeneratePaymentTypeCombo: function (identity) {

        var objModel = simsCommonManager.GetAllPaymentTypeData();
        $("#" + identity).kendoComboBox({
            placeholder: "Select Type",
            dataTextField: "PaymentType",
            dataValueField: "PaymentTypeId",
            dataSource: objModel,
            suggest: true,
            change: function () {
                AjaxManager.isValidItem(identity, true);
            }
        });
    },
    GenerateSupplierCombo: function (identity) {

        var objSupplier = simsCommonManager.GetAllSupplierData();
        $("#" + identity).kendoComboBox({
            placeholder: "Select Supplier",
            dataTextField: "SupplierName",
            dataValueField: "SupplierId",
            dataSource: objSupplier,
            suggest: true,
            change: function () {
                AjaxManager.isValidItem(identity, true);
            }
        });
    },
};