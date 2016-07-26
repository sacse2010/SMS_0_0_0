﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManager
{
    public class CommonConnection
    {
        public string constring = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ToString();
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader rd;
        public SqlDataAdapter adpt;
        public DataTable dt;
        public string ConnectionType = "";
        public DatabaseType DatabaseType { get; set; }

        public CommonConnection()
        {
            con= new SqlConnection(constring);
            if (ConfigurationSettings.AppSettings != null)
            {
               // var connectionType = ConfigurationSettings.AppSettings["DataBaseType"];
                var connectionType = "SQL";
                if (!string.IsNullOrEmpty(connectionType))
                {
                    ConnectionType = connectionType.Trim();
                }

            }
        }
        public void ExecuteNonQuery(string sql)
        {
            cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable ExecuteReader(string sql)
        {
            dt = new DataTable();
            con.Open();
            cmd = new SqlCommand(sql, con);
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;

        }
        public DataTable GetDataTable(string sql)
        {
            try
            {
                con.Open();
                dt = new DataTable();
                cmd = new SqlCommand(sql, con);
                adpt = new SqlDataAdapter(cmd);

                adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                if (con != null)
                {
                    con.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }
        public object ExecuteScalar(string commandText)
        {
            object result = null;
            cmd = new SqlCommand();

            try
            {
                cmd.CommandText = commandText;
                cmd.Connection = con;
                con.Open();
                result = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                if (con != null)
                {
                    con.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }

            return result;
        }

    }


}
