using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for clsDados
/// </summary>
public class clsDados
{
    public static clsDados Instance
    {
        get
        {
            return new clsDados();
        }
    }

    public string StringConexao
    {
        get
        {
            //Web.config
            return ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        }
    }

    public SqlConnection Connection;

    private clsDados()
    {
        Connection = new SqlConnection(StringConexao);
    }

    public bool OpenConnection()
    {
        if (Connection.State == ConnectionState.Closed)
        {
            Connection.Open();
            return true;
        }
        else return false;
    }

    public bool CloseConnection()
    {
        if (Connection.State == ConnectionState.Open)
        {
            Connection.Close();

            return true;
        }
        else return false;
    }

    public DataTable Query(string sql, List<SqlParameter> Parametros)
    {
        if (OpenConnection())
        {
            SqlCommand comando = new SqlCommand(sql, Connection);
            comando.CommandType = CommandType.Text;

            foreach (var parametro in Parametros)
                comando.Parameters.Add(parametro);
            


            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet ds = new DataSet();
            da.Fill(ds);
            CloseConnection();
            return ds.Tables[0];
        }
        else return new DataTable();
    }

    public DataTable Query(string sql, SqlParameter parametro = null)
    {
        if (OpenConnection())
        {
            SqlCommand comando = new SqlCommand(sql, Connection);
            comando.CommandType = CommandType.Text;

            if (parametro != null)
                comando.Parameters.Add(parametro);



            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet ds = new DataSet();
            da.Fill(ds);
            CloseConnection();
            return ds.Tables[0];
        }
        else return new DataTable();
    }
}