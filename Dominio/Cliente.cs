namespace Alquiler_Eventos.Dominio
{
    public class Cliente
    {
        private int aId;
        private string aNombre;
        private string aTipo;
        private string aDocumento;
        private string aDireccion;
        private string aTelefono;
        private string aEmail;
        private bool aActivo;

        public int Id { get { return aId; } set { aId = value; } }
        public string Nombre { get { return aNombre; } set { aNombre = value; } }
        public string Tipo { get { return aTipo; } set { aTipo = value; } }
        public string Documento { get { return aDocumento; } set { aDocumento = value; } }
        public string Direccion { get { return aDireccion; } set { aDireccion = value; } }
        public string Telefono { get { return aTelefono; } set { aTelefono = value; } }
        public string Email { get { return aEmail; } set { aEmail = value; } }
        public bool Activo { get { return aActivo; } set { aActivo = value; } }

        public Cliente(int pId, string pNombre, string pTipo, string pDocumento, string pDireccion, string pTelefono, string pEmail, bool pActivo)
        {
            aId = pId;
            aNombre = pNombre;
            aTipo = pTipo;
            aDocumento = pDocumento;
            aDireccion = pDireccion;
            aTelefono = pTelefono;
            aEmail = pEmail;
            aActivo = pActivo;
        }
        public Cliente()
        {
            aId = 0;
            aNombre = "";
            aTipo = "";
            aDocumento = "";
            aDireccion = "";
            aTelefono = "";
            aEmail = "";
            aActivo = false;
        }
    }
}
