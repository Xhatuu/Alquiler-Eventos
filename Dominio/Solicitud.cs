namespace Alquiler_Eventos.Dominio
{
    public class Solicitud
    {
        private int aId;
        private DateTime aFecha;
        private string aEstado;
        private Cliente aCliente;
        private Evento aEvento;
        private string aObservaciones;
        public int Id { get { return aId; } set { aId = value; } }
        public DateTime Fecha { get { return aFecha; } set { aFecha = value; } }
        public string Estado { get { return aEstado; } set { aEstado = value; } }
        public Cliente Cliente { get { return aCliente; } set { aCliente = value; } }
        public Evento Evento { get { return aEvento; } set { aEvento = value; } }
        public string Observaciones { get { return aObservaciones; } set { aObservaciones = value; } }

        public Solicitud(int pId, DateTime pFecha, string pEstado, Cliente pCliente, Evento pEvento, string pObservaciones)
        {
            aId = pId;
            aFecha = pFecha;
            aEstado = pEstado;
            aCliente = pCliente;
            aEvento = pEvento;
            aObservaciones = pObservaciones;
        }
        public Solicitud()
        {
            aId = 0;
            aFecha = DateTime.Now;
            aEstado = "";
            aCliente = new Cliente();
            aEvento = new Evento();
            aObservaciones = "";
        }
    }
}
