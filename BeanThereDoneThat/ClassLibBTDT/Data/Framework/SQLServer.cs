using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ClassLibBTDT.Data.Framework
{
    public class SqlServer<T>
    {
        public SqlConnection conn;

        public SqlServer()
        {
            conn = new SqlConnection(LocalSettings.ConnString);
        }

        #region SELECT

        public SelectResult<T> Select(SqlCommand select)
        {
            SelectResult<T> result = new SelectResult<T>();
            try
            {
                using (conn)
                {
                    select.Connection = conn;
                    conn.Open();
                    result.Results = new List<T>();
                    conn.Close();
                }
                result.Succeeded = true;
            }
            catch (Exception e)
            {
                result.AddError(e.Message);
            }
            return result;
        }

        #endregion SELECT

        #region INSERT

        public InsertResult Insert(SqlCommand insert)
        {
            InsertResult result = new InsertResult();
            try
            {
                using (conn)
                {
                    insert.Connection = conn;
                    conn.Open();
                    insert.ExecuteNonQuery();
                    conn.Close();
                }
                result.Succeeded = true;
            }
            catch (Exception e)
            {
                result.AddError(e.Message);
            }
            return result;
        }

        #endregion INSERT
    }
}