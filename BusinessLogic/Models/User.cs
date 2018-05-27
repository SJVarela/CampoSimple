using DataAccess.DataModel;
using Security.Authorization;
using System.Collections.Generic;

namespace BusinessLogic.Models
{
    public class User
    {
        public User()
        {
            Data = new UserDO();
        }
        public User(UserDO data)
        {
            this.Data = data;
        }

        public UserDO Data { get; }
        public long Id
        {
            get { return Data.Id; }
            set { Data.Id = value; }
        }
        public string Alias
        {
            get { return Data.Alias; }
            set { Data.Alias = value; }
        }
        public string Password
        {
            get { return Data.Password; }
            set { Data.Password = value; }
        }
        public string Nombre
        {
            get { return Data.Nombre; }
            set { Data.Nombre = value; }
        }
        public string Apellido
        {
            get { return Data.Apellido; }
            set { Data.Apellido = value; }
        }
        public string Email
        {
            get { return Data.Email; }
            set { Data.Email = value; }
        }

        public List<Patente> Patentes { get; set; } = new List<Patente>();
    }
}
