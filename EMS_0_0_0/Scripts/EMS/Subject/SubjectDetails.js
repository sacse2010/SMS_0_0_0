var subjectDetailsManager = {

    SaveSubjectDate: function () {
        var validator = $("#SubjectForm").kendoValidator().data("kendoValidator"), status = $(".status");
        if (validator.validate()) {
            var obj = subjectDetailsHelper.CreateSubjectObject();
            var objSubject = JSON.stringify(obj).replace(/&/g, "^");
            var jsonParam = 'objSubject:' + objSubject;
            var serviceUrl = "../Subject/SaveSubjectData/";
            AjaxManager.SendJson2(serviceUrl, jsonParam, onSuccess, onFailed);
        }

        function onSuccess(jsonData) {
            if (jsonData == "Success") {
                if (obj.SubjectId > 0) {
                    AjaxManager.MsgBox('success', 'center', 'Success:', 'Subject Update Successfully',
                    [
                        {
                            addClass: 'btn btn-primary',
                            text: 'Ok',
                            onClick: function ($noty) {
                                $noty.close();
                                $("#gridSubject").data("kendoGrid").dataSource.read();
                            }
                        }
                    ]);
                } else {
                    AjaxManager.MsgBox('success', 'center', 'Success:', 'Subject Saved Successfully',
                  [{
                      addClass: 'btn btn-primary', text: 'Ok', onClick: function ($noty) {
                          $noty.close();
                          $("#gridSubject").data("kendoGrid").dataSource.read();
                      }
                  }]);
                }

            }

            else if (jsonData == "Exists") {

                AjaxManager.MsgBox('warning', 'center', 'Already Exists:', 'Subject Code Already Exist !',
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
};
var subjectDetailsHelper = {
    CreateSubjectObject: function () {
        var obj = new Object();
        obj.SubjectId = $("#hdnSubjectId").val();
        obj.SubjectCode = $("#txtSubjectCode").val();
        obj.Name = $("#txtSubjectName").val();
        obj.Description = $("#txtDescription").val();
        obj.IsActive = $("#chkIsActive").is(":checked") == true ? "1" : "0";
        return obj;
    },
    FillSubjectDetailsInForm: function (obj) {
        $("#hdnSubjectId").val(obj.SubjectId);
        $("#txtSubjectCode").val(obj.SubjectCode);
        $("#txtSubjectName").val(obj.Name);
        $("#txtDescription").val(obj.Description);
        if (obj.IsActive == 1) {
            $("#chkIsActive").prop('checked', 'checked');
        } else {
            $("#chkIsActive").removeAttr('checked', 'checked');
        }
    },

};