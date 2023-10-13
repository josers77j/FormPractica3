using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data
{
    public class NacionalidadData
    {
        Connection _Connection = new Connection();
        SqlDataReader _readerRows;
        SqlCommand _sqlcommand = new SqlCommand();
        DataTable nacionalidadTable = new DataTable();

        public DataTable GetAllNacionalidades()
        {
            _sqlcommand.Connection = _Connection.OpenConnection();
            _sqlcommand.CommandText = "SELECT * FROM nacionalidad";
            _sqlcommand.CommandType = CommandType.Text;
            _readerRows = _sqlcommand.ExecuteReader();
            nacionalidadTable.Load(_readerRows);
            _sqlcommand.Connection.Close();
            return nacionalidadTable;
        }
    }
}
