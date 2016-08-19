var GradeSummaryManager = {
    GenerateGradeGrid: function () {
        $("#gridGrade").kendoGrid({
            dataSource: GradeSummaryManager.gridDataSource(),
            pageable: {
                refresh: true,
                serverPaging: true,
                serverFiltering: true,
                serverSorting: true
            },
            filterable: true,
            sortable: true,
            columns: GradeSummaryHelper.GenerateGradeColumns(),
            editable: false,
            navigatable: true,
            selectable: "row",
        });
    },
    gridDataSource: function () {
        var gridDataSource = new kendo.data.DataSource({
            type: "json",
            serverPaging: true,
            serverSorting: true,
            serverFiltering: true,
            allowUnsort: true,
            pageSize: 5,
            transport: {
                read: {
                    url: '../Grade/GetGradeSummary/',
                    type: "POST",
                    dataType: "json",
                    contentType: "application/json; charset=utf-8"
                },
                //update: {
                //    url: '../Test/LoadAllCompanies/',
                //    dataType: "json"
                //},
                parameterMap: function (options) {
                    return JSON.stringify(options);
                }
            },
            schema: { data: "Items", total: "TotalCount" }
        });
        return gridDataSource;
    }
};
var GradeSummaryHelper = {
    GenerateGradeColumns: function () {
        return columns = [
            { field: "GradeName", title: "Grade", width: 60 },
            { field: "GradePoint", title: "Point", width: 50},
            { field: "MarkForm", title: "MarkForm", width: 50 },
            { field: "MarkUpto", title: "MarkUpto", width: 50 },
            { field: "Description", title: "Description", width: 150 },
            { field: "IsActive", title: "Status", width: 25 },
            { field: "GradeId", hidden: true },
            { field: "Edit", title: "Edit", filterable: false, width: 60, template: '<button type="button" class="btn btn-default btn-sm" value="Edit" id="btnEdit" onClick="GradeSummaryHelper.clickEventForEditButton()" ><span class="glyphicon glyphicon-edit"></span> Edit</button>', sortable: false }
        ];
    },
    clickEventForEditButton: function () {
        var entityGrid = $("#gridGrade").data("kendoGrid");
        var selectedItem = entityGrid.dataItem(entityGrid.select());
        if (selectedItem != null) {
            GradeDetailsHelper.FillGradeDetailsInForm(selectedItem);
        }


    },
};
