using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data
{

    public class EstudianteData
    {
        Connection _connection = new Connection();
        SqlDataReader _readerRows;
        SqlCommand _sqlcommand = new SqlCommand();
        DataTable estudianteTable = new DataTable();
    
        public DataTable getAllEstudiantes()
        {
            _sqlcommand.Connection = _connection.OpenConnection();
            _sqlcommand.CommandText = "SELECT * FROM estudiantes";
            _sqlcommand.CommandType = CommandType.Text;
            _readerRows = _sqlcommand.ExecuteReader();
            estudianteTable.Load(_readerRows);
            _sqlcommand.Connection = _connection.CloseConnection();
            return estudianteTable;
        }

        public void addEstudiantes(string nombreEstudiante, string apellidoEstudiante, string telefonoEstudiante, string ciudadEstuiante)
        {
            _sqlcommand.Connection = _connection.OpenConnection();
            _sqlcommand.CommandText = "INSERT INTO estudiantes (nombreEstudiante, apellidoEstudiante, telefonoEstudiante, ciudadEstuiante)"+
                "VALUES(@nombreEstudiante, @apellidoEstudiante, @telefonoEstudiante, @ciudadEstuiante)";

            _sqlcommand.Parameters.AddWithValue("@nombreEstudiante", nombreEstudiante);
            _sqlcommand.Parameters.AddWithValue("@apellidoEstudiante", apellidoEstudiante);
            _sqlcommand.Parameters.AddWithValue("@telefonoEstudiante", telefonoEstudiante);
            _sqlcommand.Parameters.AddWithValue("@ciudadEstuiante", ciudadEstuiante);

            _sqlcommand.ExecuteNonQuery();
            _sqlcommand.Parameters.Clear();
            _sqlcommand.Connection = _connection.CloseConnection();
        }

        public void updateEstudiantes(int codigoEstudiante, string nombreEstudiante, string apellidoEstudiante, string telefonoEstudiante, string ciudadEstuiante)
        {
            _sqlcommand.Connection = _connection.OpenConnection();
            _sqlcommand.CommandText = "UPDATE estudiantes SET nombreEstudiante = @nombreEstudiante, apellidoEstudiante = @apellidoEstudiante,telefonoEstudiante = @telefonoEstudiante, ciudadEstuiante = @ciudadEstuiante WHERE codigoEstudiante = @codigoEstudiante";

            _sqlcommand.Parameters.AddWithValue("@codigoEstudiante", codigoEstudiante);
            _sqlcommand.Parameters.AddWithValue("@nombreEstudiante", nombreEstudiante);
            _sqlcommand.Parameters.AddWithValue("@apellidoEstudiante", apellidoEstudiante);
            _sqlcommand.Parameters.AddWithValue("@telefonoEstudiante", telefonoEstudiante);
            _sqlcommand.Parameters.AddWithValue("@ciudadEstuiante", ciudadEstuiante);

            _sqlcommand.ExecuteNonQuery();
            _sqlcommand.Parameters.Clear();
            _sqlcommand.Connection = _connection.CloseConnection();
        }

        public void deleteEstudiantes(int codigoEstudiante)
        {
            _sqlcommand.Connection = _connection.OpenConnection();
            _sqlcommand.CommandText = "Delete from Estudiantes  WHERE codigoEstudiante = @codigoEstudiante";

            _sqlcommand.Parameters.AddWithValue("@codigoEstudiante", codigoEstudiante);

            _sqlcommand.ExecuteNonQuery();
            _sqlcommand.Parameters.Clear();
            _sqlcommand.Connection = _connection.CloseConnection();
        }
    }
}
