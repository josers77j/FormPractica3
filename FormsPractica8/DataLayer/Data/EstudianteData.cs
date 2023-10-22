using CommonLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
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
        public DataTable SearchStudents(string search)
        {
            _sqlcommand.Connection = _connection.OpenConnection();
            _sqlcommand.CommandText = "SELECT * FROM estudiantes WHERE nombreEstudiante LIKE '%' + @search + '%'";
            _sqlcommand.CommandType = CommandType.Text;
            _sqlcommand.Parameters.AddWithValue("@search", search);

            _readerRows = _sqlcommand.ExecuteReader();
            estudianteTable.Load(_readerRows);

            _connection.CloseConnection();

            return estudianteTable;
        }
        public void addEstudiantes(Students students)
        {
            _sqlcommand.Connection = _connection.OpenConnection();
            _sqlcommand.CommandText = "INSERT INTO estudiantes (nombreEstudiante, apellidoEstudiante, telefonoEstudiante, ciudadEstudiante)" +
                "VALUES(@nombreEstudiante, @apellidoEstudiante, @telefonoEstudiante, @ciudadEstudiante)";

            _sqlcommand.Parameters.AddWithValue("@nombreEstudiante", students.nombreEstudiante);
            _sqlcommand.Parameters.AddWithValue("@apellidoEstudiante", students.apellidoEstudiante);
            _sqlcommand.Parameters.AddWithValue("@telefonoEstudiante", students.telefonoEstudiante);
            _sqlcommand.Parameters.AddWithValue("@ciudadEstudiante", students.ciudadEstudiante);

            _sqlcommand.ExecuteNonQuery();
            _sqlcommand.Parameters.Clear();
            _sqlcommand.Connection = _connection.CloseConnection();
        }

        public void updateEstudiantes(Students students)
        {
            _sqlcommand.Connection = _connection.OpenConnection();
            _sqlcommand.CommandText = "UPDATE estudiantes SET nombreEstudiante = @nombreEstudiante, apellidoEstudiante = @apellidoEstudiante,telefonoEstudiante = @telefonoEstudiante, ciudadEstudiante = @ciudadEstudiante WHERE codigoEstudiante = @codigoEstudiante";

            _sqlcommand.Parameters.AddWithValue("@codigoEstudiante", students.codigoEstudiante);
            _sqlcommand.Parameters.AddWithValue("@nombreEstudiante", students.nombreEstudiante);
            _sqlcommand.Parameters.AddWithValue("@apellidoEstudiante", students.apellidoEstudiante);
            _sqlcommand.Parameters.AddWithValue("@telefonoEstudiante", students.telefonoEstudiante);
            _sqlcommand.Parameters.AddWithValue("@ciudadEstudiante", students.ciudadEstudiante);

            _sqlcommand.ExecuteNonQuery();
            _sqlcommand.Parameters.Clear();
            _sqlcommand.Connection = _connection.CloseConnection();
        }

        public void deleteEstudiantes(Students students)
        {
            _sqlcommand.Connection = _connection.OpenConnection();
            _sqlcommand.CommandText = "Delete from Estudiantes  WHERE codigoEstudiante = @codigoEstudiante";

            _sqlcommand.Parameters.AddWithValue("@codigoEstudiante", students.codigoEstudiante);

            _sqlcommand.ExecuteNonQuery();
            _sqlcommand.Parameters.Clear();
            _sqlcommand.Connection = _connection.CloseConnection();
        }
    }
}
