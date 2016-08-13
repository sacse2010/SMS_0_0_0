$(document).ready(function () {
    SubjectSummaryManager.GenerateSubjectGrid();
    $("#btnSave").click(function () {
        subjectDetailsManager.SaveSubjectDate();
    });
});