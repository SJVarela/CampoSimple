using BusinessLogic.Models;
using DataAccess.Schemas;
using DataAccess.TableGateways;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Controller
{
    public class UserFormController
    {
        public void AddUser(User user)
        {
            var gateway = new UserGateway();
            gateway.Insert(user.Name, user.Password);
        }
        public List<User> GetUsers()
        {
            var result = new List<User>();
            var gateway = new UserGateway();
            using (var reader = gateway.GetAll())
            {
                while (reader.Read())
                {
                    result.Add(new User() { Id = (long)reader[DbSchema.Users.Id], Name = (string)reader[DbSchema.Users.Name], Password = (string)reader[DbSchema.Users.Password] });
                }
            }
            return result;
        }
        public User GetUser(long id)
        {
            throw new NotImplementedException();
        }
    }
}
