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
                command.CommandText = $"SELECT * FROM {DbSchema.Users.Table} WHERE {DbSchema.Users.Username} = @usrname";
                command.Parameters.Add(new SqlParameter("@usrname", usrname));
                var result = ExecuteRead(command);
                connection.Close();
                return result;
            }
        }
        public void Insert(string username, string password, string name, string lastName, string email, string adress, string phoneNo)
        {
            string hashedPassword = SecurePasswordHasher.Hash(password);
            using (var connection = SQLDbConnection.GetConnection())
            {
                var command = connection.CreateCommand();
                command.Parameters.Add(new SqlParameter("@username", username));
                command.Parameters.Add(new SqlParameter("@password", hashedPassword));
                command.Parameters.Add(new SqlParameter("@name", name));
                command.Parameters.Add(new SqlParameter("@lastname", lastName));
                command.Parameters.Add(new SqlParameter("@email", email));
                command.Parameters.Add(new SqlParameter("@adress", adress));
                command.Parameters.Add(new SqlParameter("@phoneno", phoneNo));
                command.CommandText = $"INSERT INTO {DbSchema.Users.Table} ({DbSchema.Users.ListColumns()}) " +
                    $"VALUES(@username, @password, @name, @lastname, @phoneno, @adress, @email)";
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void Delete(long id)
        {
            using (var connection = SQLDbConnection.GetConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = $"DELETE FROM {DbSchema.Users.Table} WHERE {DbSchema.Users.Id} = @id";
                command.Parameters.Add(new SqlParameter("@id", id));
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void Update(long id, string username, string password, string name, string lastname, string phoneno, string adress, string email)
        {
            string hashedPassword = SecurePasswordHasher.Hash(password);
            using (var connection = SQLDbConnection.GetConnection())
            {
                var command = connection.CreateCommand();
                command.Parameters.Add(new SqlParameter("@id", id));
                command.Parameters.Add(new SqlParameter("username", username));
                command.Parameters.Add(new SqlParameter("@password", hashedPassword));
                command.Parameters.Add(new SqlParameter("@name", name));
                command.Parameters.Add(new SqlParameter("@lastname", lastname));
                command.Parameters.Add(new SqlParameter("@phoneno", phoneno));
                command.Parameters.Add(new SqlParameter("@adress", adress));
                command.Parameters.Add(new SqlParameter("@email", email));
                command.CommandText = $"UPDATE {DbSchema.Users.Table} " +
                    $"SET {DbSchema.Users.Username} = @username, {DbSchema.Users.Password} = @password, " +
                    $"{DbSchema.Users.Name} = @name, {DbSchema.Users.LastName} = @lastname, {DbSchema.Users.PhoneNo} = @phoneno, " +
                    $"{DbSchema.Users.Adress} = @adress, {DbSchema.Users.Email} = @email " +
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
                Username = (string)record[DbSchema.Users.Username],
                Password = (string)record[DbSchema.Users.Password],
                Name = (string)record[DbSchema.Users.Name],
                LastName = (string)record[DbSchema.Users.LastName],
                PhoneNo = (string)record[DbSchema.Users.PhoneNo],
                Adress = (string)record[DbSchema.Users.Adress],
                Email = (string)record[DbSchema.Users.Email]
            };
            return user;
        }
    }
}
