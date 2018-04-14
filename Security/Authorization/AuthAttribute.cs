using System;

namespace Security.Authorization
{
    public class AuthAttribute : Attribute
    {
        public string NombreActividad { get; set; }
    }
}
