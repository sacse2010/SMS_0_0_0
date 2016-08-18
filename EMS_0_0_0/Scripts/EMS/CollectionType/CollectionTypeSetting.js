$(document).ready(function () {
    CollectionTypeSummaryManager.GenerateCollectionTypeGrid();
    $("#btnSave").click(function () {
        CollectionTypeDetailsManager.SaveCollectionTypeData();
    });
    $("#btnClear").click(function () {
        CollectionTypeDetailsHelper.ClearAllCottectionType();
    });
});