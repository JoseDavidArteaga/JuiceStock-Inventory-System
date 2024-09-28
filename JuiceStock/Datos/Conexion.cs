using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuiceStock.Datos
{
    public class Conexion
    {
        private static Conexion Con = null;

        public Conexion() 
        { 

        }
        public OracleConnection CreaConexion()
        {
            OracleConnection Cadena = new OracleConnection();
            try
            {
                Cadena.ConnectionString = "Data Source=localhost;Persist Security Info=True;User ID=juicestock;Password=oracle";
            }
            catch (Exception ex) 
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if(Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
