using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace bishe
{
    class DataAccess
    {
        SqlConnection conn;
        //static string Str = "Data Source=IIZ;Initial Catalog=HRManBeifen;Integrated Security=SSPI;";

        //连接名为schedule的数据库
        static string Str = "Data Source=LAPTOP-K6V82768;Initial Catalog=schedule;Integrated Security=True";
        public DataAccess()
        {
            conn = new SqlConnection(Str);
            conn.Open();
        }
        public int ExeSQL(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, this.conn);
            try
            {
                cmd.ExecuteNonQuery();
                return 0;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return -1;
            }
            finally
            {
                cmd.Dispose();
                this.conn.Close();
            }
        }
        // 判断数据库是否有记录,有记录则返回真，无则返回假
        public bool IsRead(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, this.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
            finally
            {
                dr.Close();
                cmd.Dispose();
                this.conn.Close();
            }
        }

        public void ExeSQLs(string[] sql)
        {
            SqlCommand cmd = new SqlCommand();// OleDbCommand();
            int j = sql.Length;
            SqlTransaction transaction = this.conn.BeginTransaction();
            try
            {
                cmd.Connection = this.conn;
                cmd.Transaction = transaction;
                foreach (string str in sql)
                {
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                cmd.Dispose();
                this.conn.Close();
            }
        }

        public DataTable ExeSQLdt(string sql)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
            finally
            {
                this.conn.Close();
            }
        }
    }
}
