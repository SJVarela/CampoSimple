using DataAccess.Connection;
using DataAccess.DataModel;
using DataAccess.Schemas;
using Security.Encription;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.TableGateways
{
    public class UserGateway : BaseGateway<UserDO>
    {
        public List<UserDO> GetAll()
        {
            using (var connection = SQLDbConnection.GetConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = $"SELECT * FROM {DbSchema.Users.Table}";
                var result = ExecuteRead(command);
                connection.Close();
                return result;
            }
        }
        public List<UserDO> GetById(long id)
        {
            using (var connection = SQLDbConnection.GetConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = $"SELECT * FROM {DbSchema.Users.Table} WHERE {DbSchema.Users.Id} = @id";
                command.Parameters.Add(new SqlParameter("@id", id));
                var result = ExecuteRead(command);
                connection.Close();
                return result;
            }
        }
        public List<UserDO> GetByUsername(string usrname)
        {
            using (var connection = SQLDbConnection.GetConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = $"SELECT * FROM {DbSchema.Users.Table} WHERE {DbSchema.Users.Alias} = @usrname";
                command.Parameters.Add(new SqlParameter("@usrname", usrname));
                var result = ExecuteRead(command);
                connection.Close();
                return result;
            }
        }
        public void Insert(UserDO user)
        {
            string hashedPassword = SecurePasswordHasher.Hash(user.Password);
            using (var connection = SQLDbConnection.GetConnection())
            {
                var command = connection.CreateCommand();
                command.Parameters.Add(new SqlParameter("@username", user.Alias));
                command.Parameters.Add(new SqlParameter("@password", hashedPassword));
                command.Parameters.Add(new SqlParameter("@name", user.Nombre));
                command.Parameters.Add(new SqlParameter("@lastname", user.Apellido));
                command.Parameters.Add(new SqlParameter("@email", user.Email));
                command.CommandText = $"INSERT INTO {DbSchema.Users.Table} ({DbSchema.Users.ListColumns()}) " +
                    $"VALUES(@username, @password, @name, @lastname, @email)";
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void Delete(UserDO user)
        {
            using (var connection = SQLDbConnection.GetConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = $"DELETE FROM {DbSchema.Users.Table} WHERE {DbSchema.Users.Id} = @id";
                command.Parameters.Add(new SqlParameter("@id", user.Id));
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void Update(UserDO user)
        {
            string hashedPassword = SecurePasswordHasher.Hash(user.Password);
            using (var connection = SQLDbConnection.GetConnection())
            {
                var command = connection.CreateCommand();
                command.Parameters.Add(new SqlParameter("@id", user.Id));
                command.Parameters.Add(new SqlParameter("username", user.Alias));
                command.Parameters.Add(new SqlParameter("@password", hashedPassword));
                command.Parameters.Add(new SqlParameter("@name", user.Nombre));
                command.Parameters.Add(new SqlParameter("@lastname", user.Apellido));
                command.Parameters.Add(new SqlParameter("@email", user.Email));
                command.CommandText = $"UPDATE {DbSchema.Users.Table} " +
                    $"SET {DbSchema.Users.Nombre} = @username, {DbSchema.Users.Password} = @password, " +
                    $"{DbSchema.Users.Nombre} = @name, {DbSchema.Users.Apellido} = @lastname, " +
                    $"{DbSchema.Users.Email} = @email " +
                    $"WHERE {DbSchema.Users.Id} = @id";
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public override UserDO Map(IDataRecord record)
        {
            var user = new UserDO
            {
                Id = (long)record[DbSchema.Users.Id],
                Alias = (string)record[DbSchema.Users.Alias],
                Password = (string)record[DbSchema.Users.Password],
                Nombre = (string)record[DbSchema.Users.Nombre],
                Apellido = (string)record[DbSchema.Users.Apellido],
                Email = (string)record[DbSchema.Users.Email]
            };
            return user;
        }
    }
}
