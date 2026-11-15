namespace Alquiler_Eventos.Dominio
{
    public class Solicitud
    {
        private int aId;
        private Cliente aCliente;
        private string aTipoEvento;
        private DateTime aFechaEvento;
        private string aUbicacion;
        private DateTime aHorarioInicio;
        private DateTime aHorarioFin;
        private int aCantidadAsistentes;
        private string aEstado;
        private List<Equipo> aEquipos;

        public int Id { get { return aId; } set { aId = value; } }
        public Cliente Cliente { get { return aCliente; } set { aCliente = value; } }
        public string TipoEvento { get { return aTipoEvento; } set { aTipoEvento = value; } }
        public DateTime FechaEvento { get { return aFechaEvento; } set { aFechaEvento = value; } }
        public string Ubicacion { get { return aUbicacion; } set { aUbicacion = value; } }
        public DateTime HorarioInicio { get { return aHorarioInicio; } set { aHorarioInicio = value; } }
        public DateTime HorarioFin { get { return aHorarioFin; } set { aHorarioFin = value; } }
        public int CantidadAsistentes { get { return aCantidadAsistentes; } set { aCantidadAsistentes = value; } }
        public string Estado { get { return aEstado; } set { aEstado = value; } }
        public List<Equipo> Equipos { get { return aEquipos; } set { aEquipos = value; } }

        public Solicitud(int pId, Cliente pCliente, string pTipoEvento, DateTime pFechaEvento, string pUbicacion, DateTime pHorarioInicio, DateTime pHorarioFin, int pCantidadAsistentes, string pEstado, List<Equipo> pEquipos)
        {
            aId = pId;
            aCliente = pCliente;
            aTipoEvento = pTipoEvento;
            aFechaEvento = pFechaEvento;
            aUbicacion = pUbicacion;
            aHorarioInicio = pHorarioInicio;
            aHorarioFin = pHorarioFin;
            aCantidadAsistentes = pCantidadAsistentes;
            aEstado = pEstado;
            aEquipos = pEquipos;
        }
        public Solicitud()
        {
            aId = 0;
            aCliente = new Cliente();
            aTipoEvento = "";
            aFechaEvento = DateTime.Now;
            aUbicacion = "";
            aHorarioInicio = DateTime.Now;
            aHorarioFin = DateTime.Now;
            aCantidadAsistentes = 0;
            aEstado = "";
            aEquipos = new List<Equipo>();
        }
    }
}
