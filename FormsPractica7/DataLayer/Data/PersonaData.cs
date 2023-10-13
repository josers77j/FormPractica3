using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data
{
    public class PersonaData
    {
        Connection _Connection = new Connection();
        SqlDataReader _readerRows;
        SqlCommand _sqlcommand = new SqlCommand();
        DataTable personasTable = new DataTable();

        public DataTable GetAllPersonas()
        {
            _sqlcommand.Connection = _Connection.OpenConnection();
            _sqlcommand.CommandText = "SELECT * FROM persona";
            _sqlcommand.CommandType = CommandType.Text;
            _readerRows= _sqlcommand.ExecuteReader();
            personasTable.Load( _readerRows );
            _sqlcommand.Connection.Close();
            return personasTable;
        }
    }
}
