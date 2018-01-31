namespace DataAccess.Schemas
{
    public class UserTableSchema
    {
        public string Table { get; } = "Users";
        public string Id { get; } = "IdUsuario";
        public string Name { get; } = "Nombre";
        public string Password { get; } = "Password";

    }
}
