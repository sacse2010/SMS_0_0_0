﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using AUtilities;

namespace DBManager
{
    public static class Kendo<T>
    {

        public class Grid
        {

            public static GridEntity<T> DataSource(GridOptions options, string query, string orderBy, string condition)
            {
                //string sql = "SELECT * FROM " + tableName;
                var _connection = new CommonConnection();
                try
                {
                    query = query.Replace(';', ' ');

                    string sqlQuery = options != null ? GridQueryBuilder<T>.Query(options, query, orderBy, condition) : query;

                    if (!string.IsNullOrEmpty(condition))
                    {
                        condition = " WHERE " + condition;
                    }

                    var condition1 = options != null ? GridQueryBuilder<T>.FilterCondition(options.filter) : "";
                    if (!string.IsNullOrEmpty(condition1))
                    {
                        if (!string.IsNullOrEmpty(condition))
                        {
                            condition += " And " + condition1;
                        }
                        else
                        {
                            condition = " WHERE " + condition1;
                        }

                    }

                    DataTable dataTable = _connection.GetDataTable(sqlQuery);

                    var sqlCount = "SELECT COUNT(*) FROM (" + query + " ) As tbl " + condition;


                    int totalCount = Convert.ToInt32(new CommonConnection().ExecuteScalar(sqlCount));

                    var dataList = (List<T>)ListConversion.ConvertTo<T>(dataTable);
                    var result = new GridResult<T>().Data(dataList, totalCount);

                    return result;
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }

            public static GridEntity<T> DataSourceWithDateQuary(GridOptions options, string query, string orderBy, string condition, string withDateQuary)
            {
                //string sql = "SELECT * FROM " + tableName;
                var _connection = new CommonConnection();
                try
                {


                    query = query.Replace(';', ' ');

                    string sqlQuery = options != null ? GridQueryBuilder<T>.Query(options, query, orderBy, condition) : query;

                    if (!string.IsNullOrEmpty(condition))
                    {
                        condition = " WHERE " + condition;
                    }

                    var condition1 = options != null ? GridQueryBuilder<T>.FilterCondition(options.filter) : "";
                    if (!string.IsNullOrEmpty(condition1))
                    {
                        if (!string.IsNullOrEmpty(condition))
                        {
                            condition += " And " + condition1;
                        }
                        else
                        {
                            condition = " WHERE " + condition1;
                        }

                    }

                    if (withDateQuary != "")
                    {
                        sqlQuery = withDateQuary + sqlQuery;
                    }

                    DataTable dataTable = _connection.GetDataTable(sqlQuery);

                    var sqlCount = withDateQuary + " SELECT COUNT(*) FROM (" + query + " ) As tbl " + condition;


                    int totalCount = Convert.ToInt32(_connection.ExecuteScalar(sqlCount));

                    var dataList = (List<T>)ListConversion.ConvertTo<T>(dataTable);
                    var result = new GridResult<T>().Data(dataList, totalCount);

                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }


            }

            public static DataSet GetDataSet(GridOptions options, string query, string orderBy)
            {
                //string sql = "SELECT * FROM " + tableName;
                DataSet gridDataSet = new DataSet();
                var _connection = new CommonConnection();
                string condition = "";
                try
                {
                    query = query.Replace(';', ' ');

                    string sqlQuery = options != null ? GridQueryBuilder<T>.Query(options, query, orderBy, condition) : query;

                    if (!string.IsNullOrEmpty(condition))
                    {
                        condition = " WHERE " + condition;
                    }

                    var condition1 = options != null ? GridQueryBuilder<T>.FilterCondition(options.filter) : "";
                    if (!string.IsNullOrEmpty(condition1))
                    {
                        if (!string.IsNullOrEmpty(condition))
                        {
                            condition += " And " + condition1;
                        }
                        else
                        {
                            condition = " WHERE " + condition1;
                        }

                    }

                    DataTable dataTable = _connection.GetDataTable(sqlQuery);
                    gridDataSet.Tables.Add(dataTable);

                    var sqlCount = "SELECT COUNT(*) FROM (" + query + " ) As tbl " + condition;

                    int totalCount = Convert.ToInt32(_connection.ExecuteScalar(sqlCount));
                    DataTable totalCountDt = new DataTable("TotalCount");
                    DataColumn col = new DataColumn("totalCount");
                    col.DataType = Type.GetType("System.Int32");
                    totalCountDt.Columns.Add(col);
                    DataRow dr = totalCountDt.NewRow();
                    dr["totalCount"] = totalCount;
                    totalCountDt.Rows.Add(dr);
                    gridDataSet.Tables.Add(totalCountDt);


                    return gridDataSet;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

            public static GridEntity<T> DataSource(GridOptions options, string query, string orderBy)
            {
                return DataSource(options, query, orderBy, "");
            }
            public static GridEntity<T> DataSourceWithDateQuary(GridOptions options, string query, string orderBy, string withQuary)
            {
                return DataSourceWithDateQuary(options, query, orderBy, "", withQuary);
            }


            public static GridEntity<T> GenericDataSource(GridOptions options, string query, string orderBy, string condition)
            {
                var _connection = new CommonConnection();
                StringBuilder gridQuery;
                StringBuilder totalQuery;
                GetGridPagingQuery(options, query, orderBy, condition, out gridQuery, out totalQuery, _connection.DatabaseType);
                DataTable dataTable = _connection.GetDataTable(gridQuery.ToString());
                int totalCount = Convert.ToInt32(_connection.ExecuteScalar(totalQuery.ToString()));
                var dataList = (List<T>)GenericListGenerator.GetList<T>(dataTable);
                var result = new GridResult<T>().Data(dataList, totalCount);
                return result;
            }
            public static GridEntity<T> GenericDataSource(GridOptions options, string query, string orderBy)
            {
                return GenericDataSource(options, query, orderBy, "");
            }

            private static void GetGridPagingQuery(GridOptions options, string query, string orderBy, string condition, out StringBuilder gridQuery, out StringBuilder totalQuery, DatabaseType databaseType)
            {

                try
                {
                    gridQuery = new StringBuilder();
                    totalQuery = new StringBuilder();

                    query = query.Replace(';', ' ');

                    string strQuery = options != null ? GridQueryBuilder<T>.Query(options, query, orderBy, condition) : query;

                    if (!string.IsNullOrEmpty(condition))
                    {
                        condition = " WHERE " + condition;
                    }

                    var condition1 = options != null ? GridQueryBuilder<T>.FilterCondition(options.filter) : "";
                    if (!string.IsNullOrEmpty(condition1))
                    {
                        if (!string.IsNullOrEmpty(condition))
                        {
                            condition += " And " + condition1;
                        }
                        else
                        {
                            condition = " WHERE " + condition1;
                        }

                    }
                    string tQuery = "";
                    if (databaseType == DatabaseType.SQL)
                    {
                        tQuery = "SELECT COUNT(*) FROM (" + query + " ) As tbl " + condition;
                    }
                    else if (databaseType == DatabaseType.Oracle)
                    {
                        tQuery = "SELECT COUNT(*) FROM (" + query + " )" + condition;
                    }

                    gridQuery.Append(strQuery);
                    totalQuery.Append(tQuery);



                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
        }

        public class Combo
        {
            public static List<T> DataSource(string query)
            {
                var returnList = new List<T>();

                try
                {
                    CommonConnection connection = new CommonConnection();
                    DataTable dataTable = connection.GetDataTable(query);

                    var data = (List<T>)ListConversion.ConvertTo<T>(dataTable);
                    if (data != null)
                    {
                        return data;
                    }

                }
                catch (Exception ex)
                {

                    throw ex;
                }

                return returnList;
            }

        }

        //public class AutoComplete
        //{
        //    public static dynamic DataSource(AutoCompOptions options, string query, string orderBy)
        //    {
        //        var connection = new DbConnectionManager();
        //        try
        //        {


        //            query = query.Replace(';', ' ');

        //            string sqlQuery = GridQueryBuilder<T>.Query(options, query, orderBy, "");


        //            DataTable dataTable = connection.GetDataTable(sqlQuery);

        //            var dataList = (List<T>)ListConversion.ConvertTo<T>(dataTable);


        //            return dataList;
        //        }
        //        catch (Exception ex)
        //        {

        //            throw;
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }
        //    }
        //}

        //public class Scheduler
        //{
        //    public static dynamic DataSource(string query)
        //    {
        //        return Data<T>.SchedulerDataSource(query);
        //    }
        //}



    }

    public class Data<T>
    {

        public static List<T> DataSource(string query)
        {
            var connection = new CommonConnection();
            try
            {

                DataTable dataTable = connection.GetDataTable(query);

                var objData = (List<T>)ListConversion.ConvertTo<T>(dataTable);
                return objData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }

        public static List<T> GenericDataSource(string query)
        {
            var connection = new CommonConnection();
            try
            {

                DataTable dataTable = connection.GetDataTable(query);

                var objData = (List<T>)GenericListGenerator.GetList<T>(dataTable);
                if (objData.Count == 0)
                {
                    return new List<T>();
                }
                return objData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }

        public static List<T> SchedulerDataSource(string query)
        {
            return GenericDataSource(query);

        }


    }
}
