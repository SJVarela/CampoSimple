namespace DataAccess.Schemas
{
    public class UserTableSchema
    {
        public string Table { get; } = "Users";
        public string Id { get; } = "IdUsuario";
        public string Username { get; } = "Username";
        public string Password { get; } = "Password";
        public string Name { get; } = "Nombre";
        public string LastName { get; } = "Lastname";
        public string PhoneNo { get; } = "Phonenumber";
        public string Adress { get; } = "Adress";
        public string Email { get; } = "Email";

        public string ListColumns()
        {
            return $"{Username}, {Password}, {Name}, {LastName}, {PhoneNo}, {Adress}, {Email}";
        }
    }
}
