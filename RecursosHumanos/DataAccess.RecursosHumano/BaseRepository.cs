using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataAccess.RecursosHumanos.BaseRepository
{
    public class BaseRepository
    {
        private string prueba = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        //private string ConnectionString = @"Data Source=DESKTOP-3H8L7N1\SQLEXPRESS;Initial Catalog=Propietaria1; Integrated Security=true;";
        private static System.Data.SqlClient.SqlConnection cnn = null;


        private void OpenConnection()
        {
            cnn = new System.Data.SqlClient.SqlConnection(prueba);
            cnn.Open();

        }





        public DataTable ToDataTable<T>(List<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }


        public void CloseConnection()
        {
            if (cnn != null)
            {
                cnn.Close();
                cnn.Dispose();
                cnn = null;
            }
        }



        public List<T> Query<T>(string query, object parametros = null)
        {
            OpenConnection();
            if (query == null) return default(List<T>);
            var paramsList = new DynamicParameters();
            if (parametros != null) paramsList.AddDynamicParams(parametros);
            return (cnn.Query<T>(query, parametros).ToList());

        }


    }
}
