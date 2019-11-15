using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace VeterinariaMenu
{
    class AccesoDatos
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        private string cadenaConexion;

        public SqlDataReader pDr
        {
            set { dr = value; }
            get { return dr; }
        }
        public string pCadenaConexio
        {
            set { cadenaConexion = value; }
            get { return cadenaConexion; }
        }
        public AccesoDatos()
        {
            cmd = new SqlCommand();
            cn = new SqlConnection();
            dr = null;
            cadenaConexion = "";
        }
        public AccesoDatos(string stringConexion)
        {
            cmd = new SqlCommand();
            cn = new SqlConnection();
            dr = null;
            cadenaConexion = stringConexion;
        }
        public void conectar()
        {
            cn.ConnectionString = cadenaConexion;
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
        }
        public void desconectar()
        {
            cn.Close();
            cn.Dispose();
        }
        public void nonQuery(string consultaSql)
        {
            conectar();
            cmd.CommandText = consultaSql;
            cmd.ExecuteNonQuery();
            desconectar();
        }
        public void leerTabla(string consultaSql)
        {
            conectar();
            cmd.CommandText = consultaSql;
            dr = cmd.ExecuteReader();
        }
        public DataTable guardarTabla(string consultaSql)
        {
            DataTable dt = new DataTable();
            conectar();
            cmd.CommandText = consultaSql;
            dt.Load(cmd.ExecuteReader());
            desconectar();
            return dt;
        }
    }


}
