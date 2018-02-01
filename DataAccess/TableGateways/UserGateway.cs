using DataAccess.Connection;
using DataAccess.Schemas;
using Security.Encription;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.TableGateways
{
    //Deferred data materialization
    public class UserGateway : ITableGateway
    {
        public IDataReader GetAll()
        {
            using (var connection = SQLDbConnection.GetConnection())
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = $"SELECT * FROM {DbSchema.Usuarios.Table}";
                var result = command.ExecuteReader();
                return result;
            }
        }
        public IDataReader GetById(long id)
        {
            using (var connection = SQLDbConnection.GetConnection())
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = $"SELECT * FROM {DbSchema.Usuarios.Table} WHERE {DbSchema.Usuarios.Id} = @id";
                command.Parameters.Add(new SqlParameter("@id", id));
                var result = command.ExecuteReader();
                return result;
            }
        }
        public IDataReader GetByName(string name)
        {
            using (var connection = SQLDbConnection.GetConnection())
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = $"SELECT * FROM {DbSchema.Usuarios.Table} WHERE {DbSchema.Usuarios.Name} = @name";
                command.Parameters.Add(new SqlParameter("@name", name));
                var result = command.ExecuteReader();
                return result;
            }
        }
        public void Insert(string name, string password)
        {
            string hashedPassword = SecurePasswordHasher.Hash(password);
            using (var connection = SQLDbConnection.GetConnection())
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = $"INSERT INTO {DbSchema.Usuarios.Table}({DbSchema.Usuarios.Name}, {DbSchema.Usuarios.Password}) VALUES(\"{name}\", {hashedPassword})";
                command.ExecuteNonQuery();
            }
        }
        public void Delete(long id)
        {
            using (var connection = SQLDbConnection.GetConnection())
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = $"DELETE FROM {DbSchema.Usuarios.Table} WHERE {DbSchema.Usuarios.Id} = @id";
                command.Parameters.Add(new SqlParameter("@id", id));
                command.ExecuteNonQuery();
            }
        }
        public void Update(long id, string name, string password)
        {
            string hashedPassword = SecurePasswordHasher.Hash(password);
            using (var connection = SQLDbConnection.GetConnection())
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = $"UPDATE {DbSchema.Usuarios.Table} SET {DbSchema.Usuarios.Name} = @name, {DbSchema.Usuarios.Password} = @password WHERE {DbSchema.Usuarios.Id} = @id";
                command.Parameters.Add(new SqlParameter("@name", name));
                command.Parameters.Add(new SqlParameter("@password", hashedPassword));
                command.Parameters.Add(new SqlParameter("@id", id));
                command.ExecuteNonQuery();
            }
        }

    }
}
