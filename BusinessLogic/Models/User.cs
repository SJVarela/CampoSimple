using DataAccess.DataModel;

namespace BusinessLogic.Models
{
    public class User
    {
        private UserDO data;
        public User()
        {
            data = new UserDO();
        }
        public User(UserDO data)
        {
            this.data = data;
        }

        public long Id
        {
            get { return data.Id; }
            set { data.Id = value; }
        }
        public string Username
        {
            get { return data.Username; }
            set { data.Username = value; }
        }
        public string Password
        {
            get { return data.Password; }
            set { data.Password = value; }
        }
        public string Name
        {
            get { return data.Name; }
            set { data.Name = value; }
        }
        public string LastName
        {
            get { return data.LastName; }
            set { data.LastName = value; }
        }
        public string PhoneNo
        {
            get { return data.PhoneNo; }
            set { data.PhoneNo = value; }
        }
        public string Adress
        {
            get { return data.Adress; }
            set { data.Adress = value; }
        }
        public string Email
        {
            get { return data.Email; }
            set { data.Email = value; }
        }
    }
}
