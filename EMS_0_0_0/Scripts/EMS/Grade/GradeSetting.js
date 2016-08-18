$(document).ready(function () {
    GradeSummaryManager.GenerateGradeGrid();
    $("#btnSave").click(function () {
        GradeDetailsManager.SaveGradeDate();
    });
    $("#btnClear").click(function () {
        GradeDetailsHelper.ClearAllGrade();
    });

});