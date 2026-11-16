namespace Alquiler_Eventos.Dominio
{
    public class Equipamiento
    {
        private int aId;
        private string aCodigo;
        private string aEstado;
        private Deposito aDeposito;
        private TipoEquipamiento aTipoEquipamiento;
        private string aObservaciones;

        public int Id { get { return aId; } set { aId = value; } }
        public string Codigo { get { return aCodigo; } set { aCodigo = value; } }
        public string Estado { get { return aEstado; } set { aEstado = value; } }
        public Deposito Deposito { get { return aDeposito; } set { aDeposito = value; } }
        public TipoEquipamiento TipoEquipamiento { get { return aTipoEquipamiento; } set { aTipoEquipamiento = value; } }
        public string Observaciones { get { return aObservaciones; } set { aObservaciones = value; } }

        public Equipamiento(int pId, string pCodigo, string pEstado, Deposito pDeposito, TipoEquipamiento pTipoEquipamiento, string pObservaciones)
        {
            aId = pId;
            aCodigo = pCodigo;
            aEstado = pEstado;
            aDeposito = pDeposito;
            aTipoEquipamiento = pTipoEquipamiento;
            aObservaciones = pObservaciones;
        }
        public Equipamiento()
        {
            aId = 0;
            aCodigo = "";
            aEstado = "";
            aDeposito = new Deposito();
            aTipoEquipamiento = new TipoEquipamiento();
            aObservaciones = "";
        }
    }
}
