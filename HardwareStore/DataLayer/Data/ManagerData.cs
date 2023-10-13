using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data
{
    public class ManagerData
    {
        Connection _connection = new Connection();
        SqlDataReader _readerRows;
        SqlCommand _sqlcommand = new SqlCommand();

        DataTable managersTable = new DataTable();

        public DataTable GetAllManagers()
        {
            _sqlcommand.Connection.Open();
            _sqlcommand.CommandText = "SELECT * FROM Gerentes";
            _sqlcommand.CommandType = CommandType.Text;

            _readerRows = _sqlcommand.ExecuteReader();

            managersTable.Load(_readerRows);

            _sqlcommand.Connection.Close();
            return managersTable;
        }

        public void AddManager(string firstName, string lastName)
        {
            _sqlcommand.Connection.Open();
            _sqlcommand.CommandText = "INSERT INTO Gerentes (FirstName, LastName)" + "Values(@FirstName, @LastName)";

            _sqlcommand.Parameters.AddWithValue("@FirstName", firstName);
            _sqlcommand.Parameters.AddWithValue("@LastName", lastName);
            _sqlcommand.ExecuteNonQuery();
            _sqlcommand.Parameters.Clear();
            _sqlcommand.Connection.Close();
        }
        public void UpdateManager(int id, string firstName, string lastName )
        {
            _sqlcommand.Connection.Open();
            _sqlcommand.CommandText = "UPDATE Gerentes " + "SET FirstName = @FirstName, LastName = @LastName" + "WHERE Id = @Id";

            _sqlcommand.Parameters.AddWithValue("@FirstName", firstName);
            _sqlcommand.Parameters.AddWithValue("@LastName", lastName);
            _sqlcommand.Parameters.AddWithValue("@Id", id);
            _sqlcommand.ExecuteNonQuery();
            _sqlcommand.Parameters.Clear();
            _sqlcommand.Connection.Close();
        }
        public void DeleteManager(int id)
        {
            _sqlcommand.Connection.Open();
            _sqlcommand.CommandText = "DELETE FROM Gerentes WHERE Id = @Id";

            _sqlcommand.Parameters.AddWithValue("@Id", id);
            _sqlcommand.Parameters.Clear();
            _sqlcommand.ExecuteNonQuery();
            _sqlcommand.Connection.Close();

        }
    }
}
