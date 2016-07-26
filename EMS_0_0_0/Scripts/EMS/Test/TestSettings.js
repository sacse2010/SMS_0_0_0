$(document).ready(function () {

    TestDetailsHelper.PopulateTestTypeCombo();
    TestDetailsHelper.PopulateTestTypeDropDown();
    TestSummaryManager.GenerateTestGrid();

    $("#btnSave").click(function () {
        TestDetailsManager.SaveTestData();
    });

});



