using System;

namespace Security.Bitacora
{
    public class EventoBitacora
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public Criticidad Criticidad { get; set; }
        public string Accion { get; set; }
        public DateTime Fecha { get; set; }
        public string DVH { get; set; }
    }
}