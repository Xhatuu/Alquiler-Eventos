using System.Reflection.PortableExecutable;

namespace Alquiler_Eventos.Dominio
{
    public class Evento
    {
        private int aId;
        private string aNombre;
        private DateTime aFecha;
        private string aUbicacion;
        private TimeSpan aHoraInicio;
        private TimeSpan aHoraFin;
        private int aCantAsistentes;

        public int Id { get { return aId; } set { aId = value; } }
        public string Nombre { get { return aNombre; } set { aNombre = value; } }
        public DateTime Fecha { get { return aFecha; } set { aFecha = value; } }
        public string Ubicacion { get { return aUbicacion; } set { aUbicacion = value; } }
        public TimeSpan HoraInicio { get { return aHoraInicio; } set { aHoraInicio = value; } }
        public TimeSpan HoraFin { get { return aHoraFin; } set { aHoraFin = value; } }
        private int CantAsistentes { get { return aCantAsistentes; } set { aCantAsistentes = value; } }

        public Evento(int pId, string pNombre, DateTime pFecha, string pUbicacion, TimeSpan pHoraInicio,  TimeSpan pHoraFin, int pCantAsistentes)
        {
            aId = pId;
            aNombre = pNombre;
            aFecha = pFecha;
            aUbicacion = pUbicacion;
            aHoraInicio = pHoraInicio;
            aHoraFin = pHoraFin;
            aCantAsistentes = pCantAsistentes;
        }

        public Evento()
        {
            aId = 0;
            aNombre = "";
            aFecha = DateTime.Now;
            aUbicacion = "";
            aHoraInicio = TimeSpan.Zero;
            aHoraFin = TimeSpan.Zero;
            aCantAsistentes = 0;
        }

    }
}
