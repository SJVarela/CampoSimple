using BusinessLogic.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Controller
{
    public class UserFormController
    {
        private Repository repository = new Repository();
        public void AltaUsuario(User user)
        {
            repository.Users.Insert(user.Data);
        }
        public List<User> ListarUsuarios()
        {
            throw new NotImplementedException();
        }
        public User BuscarUsuario(long id)
        {
            throw new NotImplementedException();
        }
    }
}
