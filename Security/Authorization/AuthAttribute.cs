using System;

namespace Security.Authorization
{
    [AttributeUsage(AttributeTargets.Field)]
    public class AuthAttribute : Attribute
    {
        public AuthAttribute(Patente patente)
        {
            Patente = patente;
        }
        public Patente Patente { get; }
    }
}
