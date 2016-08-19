var GradeDetailsManager = {
    SaveGradeDate: function () {
        var validator = $("#GradeForm").kendoValidator().data("kendoValidator"), status = $(".status");
        if (validator.validate()) {
            var obj = GradeDetailsHelper.CreateGradeObject();
            var objGrade = JSON.stringify(obj).replace(/&/g, "^");
            var jsonParam = 'objGrade:' + objGrade;
            var serviceUrl = "../Grade/GradeDataSave/";
            AjaxManager.SendJson2(serviceUrl, jsonParam, onSuccess, onFailed);
        }

        function onSuccess(jsonData) {
            if (jsonData == "Success") {
                if (obj.GradeId > 0) {
                    AjaxManager.MsgBox('success', 'center', 'Success:', 'Grade Update Successfully',
                    [
                        {
                            addClass: 'btn btn-primary',
                            text: 'Ok',
                            onClick: function ($noty) {
                                $noty.close();
                                $("#gridGrade").data("kendoGrid").dataSource.read();
                            }
                        }
                    ]);
                } else {
                    AjaxManager.MsgBox('success', 'center', 'Success:', 'Grade Saved Successfully',
                  [{
                      addClass: 'btn btn-primary', text: 'Ok', onClick: function ($noty) {
                          $noty.close();
                          $("#gridGrade").data("kendoGrid").dataSource.read();
                      }
                  }]);
                }

            }

            else if (jsonData == "Exists") {

                AjaxManager.MsgBox('warning', 'center', 'Already Exists:', 'Grade Name Already Exist !',
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
    }
};
var GradeDetailsHelper = {
    CreateGradeObject: function () {
        var obj = new Object();
        obj.GradeId = $("#hdnGradeId").val();
        obj.GradeName = $("#txtGradeName").val();
        obj.GradePoint = $("#txtGradePoint").val();
        obj.MarkForm = $("#txtMarkForm").val();
        obj.MarkUpto = $("#txtMarkUpto").val();
        obj.Description = $("#txtDescription").val();
        obj.IsActive = $("#chkIsActive").is(":checked") == true ? 1 : 0;
        return obj;
    },
    FillGradeDetailsInForm: function (obj) {
        $("#hdnGradeId").val(obj.GradeId);
        $("#txtGradeName").val(obj.GradeName);
        $("#txtGradePoint").val(obj.GradePoint);
        $("#txtMarkForm").val(obj.MarkForm);
        $("#txtMarkUpto").val(obj.MarkUpto);
        $("#txtDescription").val(obj.Description);
        if (obj.IsActive == 1) {
            $("#chkIsActive").prop('checked', 'checked');
        } else {
            $("#chkIsActive").removeAttr('checked', 'checked');
        }
    },
    ClearAllGrade: function () {
        $("#hdnGradeId").val(0);
        $("#txtGradeName").val("");
        $("#txtGradePoint").val("");
        $("#txtMarkForm").val("");
        $("#txtMarkUpto").val("");
        $("#txtDescription").val("");
        $("#chkIsActive").prop('checked', 'checked');
    },

};