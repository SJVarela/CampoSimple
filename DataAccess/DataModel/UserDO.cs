namespace DataAccess.DataModel
{
    public class UserDO : IDataObject
    {
        public long Id { get; set; }
        public string Alias { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
    }
}
