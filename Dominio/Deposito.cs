using System.Reflection.PortableExecutable;

namespace Alquiler_Eventos.Dominio
{
    public class Deposito
    {
        private int aId;
        private string aNombre;
        private string aDireccion;
        private string aDescripcion;

        public int Id { get { return aId; } set { aId = value; } }
        public string Nombre { get { return aNombre; } set { aNombre = value; } }
        public string Direccion { get { return aDireccion; } set { aDireccion = value; } }
        public string Descripcion { get {return aDescripcion; } set {aDescripcion = value; } }

        public Deposito(int pId, string pNombre, string pDireccion, string pDescripcion)
        {
            aId = pId;
            aNombre = pNombre;
            aDireccion = pDireccion;
            aDescripcion= pDescripcion;
        }

        public Deposito()
        {
            aId = 0;
            aNombre = "";
            aDireccion = "";
            aDescripcion = "";
        }
    }
}
