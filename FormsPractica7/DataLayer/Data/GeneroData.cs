using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data
{
    public class GeneroData
    {
        Connection _Connection = new Connection();
        SqlDataReader _readerRows;
        SqlCommand _sqlcommand = new SqlCommand();
        DataTable generoTable = new DataTable();

        public DataTable GetAllgenero()
        {
            _sqlcommand.Connection = _Connection.OpenConnection();
            _sqlcommand.CommandText = "SELECT * FROM genero";
            _sqlcommand.CommandType = CommandType.Text;
            _readerRows = _sqlcommand.ExecuteReader();
            generoTable.Load(_readerRows);
            _sqlcommand.Connection.Close();
            return generoTable;
        }
    }
}
