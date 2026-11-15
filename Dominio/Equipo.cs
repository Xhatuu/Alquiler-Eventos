namespace Alquiler_Eventos.Dominio
{
    public class Equipo
    {
        private int aId;
        private string aNombre;
        private string aTipo;
        private string aEstado;
        private string aDeposito;

        public int Id { get { return aId; } set { aId = value; } }
        public string Nombre { get { return aNombre; } set { aNombre = value; } }
        public string Tipo { get { return aTipo; } set { aTipo = value; } }
        public string Estado { get { return aEstado; } set { aEstado = value; } }
        public string Deposito { get { return aDeposito; } set { aDeposito = value; } }

        public Equipo(int pId, string pNombre, string pTipo, string pEstado, string pDeposito)
        {
            aId = pId;
            aNombre = pNombre;
            aTipo = pTipo;
            aEstado = pEstado;
            aDeposito = pDeposito;
        }
        public Equipo()
        {
            aId = 0;
            aNombre = "";
            aTipo = "";
            aEstado = "";
            aDeposito = "";
        }
    }
}
