

var TestDetailsManager = {
    SaveTestData: function () {

        var obj = TestDetailsHelper.CreateTestObject();

        var objTest = JSON.stringify(obj).replace(/&/g, "^");
        var jsonParam = 'objTest:' + objTest;
        var serviceUrl = "../Test/SaveTestData/";
        AjaxManager.SendJson2(serviceUrl, jsonParam, onSuccess, onFailed);

        function onSuccess(jsonData) {
            if (jsonData == "Success") {

                AjaxManager.MsgBox('success', 'center', 'Success:', 'Test Saved Successfully',
                    [{
                        addClass: 'btn btn-primary', text: 'Ok', onClick: function ($noty) {
                            $noty.close();
                            $("#gridTest").data("kendoGrid").dataSource.read();
                        }
                    }]);
            }
            else if (jsonData == "Exist") {

                AjaxManager.MsgBox('warning', 'center', 'Already Exists:', 'Test Code Already Exist !',
                      [{
                          addClass: 'btn btn-primary', text: 'Ok', onClick: function ($noty) {
                              $noty.close();
                          }
                      }]);
            }
            else {
                AjaxManager.MsgBox('error', 'center', 'Error', jsonData,
                        [{
                            addClass: 'btn btn-primary', text: 'Ok', onClick: function ($noty) {
                                $noty.close();
                            }
                        }]);
            }
        }

        function onFailed(error) {
            AjaxManager.MsgBox('error', 'center', 'Error', error.statusText,
                        [{
                            addClass: 'btn btn-primary', text: 'Ok', onClick: function ($noty) {
                                $noty.close();
                            }
                        }]);
        }
    },

    GetTestTypeComboData: function () {
        var obj = "";
        var jsonParam = "";
        var serviceUrl = "../Test/GetTestTypeComboData/";
        AjaxManager.GetJsonResult(serviceUrl, jsonParam, false, false, onSuccess, onFailed);

        function onSuccess(jsonData) {
            obj = jsonData;
        }
        function onFailed(jqXHR, textStatus, errorThrown) {
            window.alert(errorThrown);
        }
        return obj;
    }

};


var TestDetailsHelper = {
    CreateTestObject: function () {
        var obj = new Object();
        obj.TestId = $("#hdnTestId").val();
        obj.TestCode = $("#txtTestCode").val();
        obj.TestName = $("#txtTestName").val();
        obj.TestDescription = $("#txtTestDescription").val();
        obj.IsActive = $("#chkIsActive").is(":checked") == true ? 1 : 0;
        return obj;
    },

    PopulateTestTypeCombo: function () {
        var objType = new Object();
        objType = TestDetailsManager.GetTestTypeComboData();

        $("#cmbTestType").kendoComboBox({
            placeholder: "Select Type...",
            dataTextField: "TestName",
            dataValueField: "TestId",
            dataSource: objType,
            suggest: true,
            change: function () {

                var value = this.value();
                AjaxManager.isValidItem("cmbTestType", true);
            }
        });
    },

    PopulateTestTypeDropDown: function () {
        var objType = new Object();
        objType = TestDetailsManager.GetTestTypeComboData();

        $("#ddlTestType").kendoDropDownList({
            placeholder: "Select Type...",
            dataTextField: "TestName",
            dataValueField: "TestId",
            dataSource: objType,
            suggest: true,
            change: function () {

                var value = this.value();
                AjaxManager.isValidItem("cmbTestType", true);
            }
        });
    }


};