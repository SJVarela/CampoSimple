namespace DataAccess.Schemas
{
    public class UserTableSchema
    {
        public string Table { get; } = "Users";
        public string Id { get; } = "IdUsuario";
        public string Alias { get; } = "Alias";
        public string Password { get; } = "Password";
        public string Nombre { get; } = "Nombre";
        public string Apellido { get; } = "Apellido";
        public string Email { get; } = "Email";

        public string ListColumns()
        {
            return $"{Alias}, {Password}, {Nombre}, {Apellido}, {Email}";
        }
    }
}
