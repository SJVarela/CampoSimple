﻿namespace DataAccess.DataModel
{
    public class UserDO : IDataObject
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public string Adress { get; set; }
    }
}
