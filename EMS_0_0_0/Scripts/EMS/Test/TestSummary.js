
var TestSummaryManager = {
    GenerateTestGrid: function () {
        $("#gridTest").kendoGrid({
            dataSource: TestSummaryManager.gridDataSource(),
            pageable: {
                refresh: true,
                serverPaging: true,
                serverFiltering: true,
                serverSorting: true
            },
            filterable: true,
            sortable: true,
            columns: TestSummaryHelper.GenerateTestColumns(),
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
                    url: '../Test/GetTestSummary/',

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

var TestSummaryHelper = {
    GenerateTestColumns: function () {
        return columns = [
               { field: "TestCode", title: "TestCode", width: 80 },
               { field: "TestName", title: "Test Name", width: 100 },
               { field: "TestDescription", title: "Description", width: 100 },
               { field: "TestId", hidden: true },
            { field: "Edit", title: "Edit", filterable: false, width: 60, template: '<button type="button" value="Edit" id="btnEdit" onClick="TestSummaryHelper.clickEventForEditButton()" ><span class="k-icon k-i-search"></span></button>', sortable: false }
        ];
    },
    clickEventForEditButton: function () {

        //var entityGrid = $("#gridTest").data("kendoGrid");
        //var selectedItem = entityGrid.dataItem(entityGrid.select());
        //if (selectedItem != null) {
        //    TestHelper.FillTestDetailsInForm(selectedItem);
        //}

    }
};