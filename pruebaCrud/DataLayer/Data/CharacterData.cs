using CommonLayer.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data
{
    public class CharacterData
    {
        Connection _connection = new Connection();
        SqlCommand _sqlCommand = new SqlCommand();
        DataTable characterTable = new DataTable();
        SqlDataReader _rowReader;

        public DataTable getAllCharacters()
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "select * from personajes";
            _sqlCommand.CommandType = CommandType.Text;
            _rowReader = _sqlCommand.ExecuteReader();
            characterTable.Load(_rowReader);
            _sqlCommand.Connection = _connection.CloseConnection();
            return characterTable;
        }

        public void addCharacter(Character character)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "INSERT into personajes (nombre, ataque, defensa, ki) VALUES (@nombre, @ataque, @defensa, @ki)";
            _sqlCommand.Parameters.AddWithValue("@nombre", character.nombre);
            _sqlCommand.Parameters.AddWithValue("@ataque", character.ataque);
            _sqlCommand.Parameters.AddWithValue("@defensa", character.defensa);
            _sqlCommand.Parameters.AddWithValue("@ki", character.ki);
            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _sqlCommand.Connection = _connection.CloseConnection();
        }
        public void updateCharacter(Character character)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "UPDATE personajes nombre = @nombre, ataque = @ataque, defensa = @defensa, ki = @ki WHERE id = @id";
            _sqlCommand.Parameters.AddWithValue("@id", character.id);
            _sqlCommand.Parameters.AddWithValue("@nombre", character.nombre);
            _sqlCommand.Parameters.AddWithValue("@ataque", character.ataque);
            _sqlCommand.Parameters.AddWithValue("@defensa", character.defensa);
            _sqlCommand.Parameters.AddWithValue("@ki", character.ki);
            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _sqlCommand.Connection = _connection.CloseConnection();
        }

        public void deleteCharacter(Character character)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "DELETE FROM personajes where id = @id";
            _sqlCommand.Parameters.AddWithValue("@id", character.id);
            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _sqlCommand.Connection = _connection.CloseConnection();

        }

    }
}
