using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace DataAccess.RecursosHumanos.BaseRepository
{
    public class BaseRepository
    {
        private string prueba = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        private string ConnectionString = @"Data Source=DESKTOP-3H8L7N1\SQLEXPRESS;Initial Catalog=Propietaria1; Integrated Security=true;";
        private static System.Data.SqlClient.SqlConnection cnn = null;
      

        private  void OpenConnection()
        {
            cnn = new System.Data.SqlClient.SqlConnection(prueba);
            cnn.Open();

        }


        public  void CloseConnection()
        {
            if(cnn != null)
            {
                cnn.Close();
                cnn.Dispose();
                cnn = null;
            }
        }



        public List<T> getAll<T>(string query, object parametros = null)
        {
            OpenConnection();
            if (query == null) return default(List<T>);
            var paramsList = new DynamicParameters();
            if (parametros != null) paramsList.AddDynamicParams(parametros);
                return (cnn.Query<T>(query, parametros).ToList());
           
        }


       

    
    
    }
}
