using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccess.RecursosHumanos.BaseRepository
{
    public class GestionCompetencias
    {
        BaseRepository bs = new BaseRepository();
        public List<int> GetCompetencias()
        {
            try
            {
                string query = "select * from GCompetencias";
                var result = bs.getAll<int>(query);
                bs.CloseConnection();
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
    }
}
