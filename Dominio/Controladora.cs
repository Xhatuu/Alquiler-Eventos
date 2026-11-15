namespace Alquiler_Eventos.Dominio
{
    public class Controladora
    {
        private static List<Equipo> aListaEquipos = new List<Equipo>();
        private static List<Cliente> aListaClientes = new List<Cliente>();

        #region Equipos

        public List<Equipo> ListarEquipos()
        {
            return aListaEquipos;
        }
        public Equipo BuscarEquipo(int pId)
        {
            foreach (Equipo unEquipo in aListaEquipos)
            {
                if(unEquipo.Id == pId)
                {
                    return unEquipo;
                }
            }
            return null;
        }
        public bool AltaEquipo(Equipo pEquipo)
        {
            Equipo ComparoEquipo = BuscarEquipo(pEquipo.Id);
            if(ComparoEquipo == null)
            {
                aListaEquipos.Add(pEquipo);
                return true;
            }
            return false;
        }
        public bool BajaEquipo(int pId)
        {
            Equipo EquipoAEliminar = BuscarEquipo(pId);
            if(EquipoAEliminar != null)
            {
                aListaEquipos.Remove(EquipoAEliminar);
                return true;
            }
            return false;
        }
        public bool ModificarEquipo(int pId, string pNombre, string pTipo, string pEstado, string pDeposito)
        {
            Equipo EquipoAModificar = BuscarEquipo(pId);
            if(EquipoAModificar != null)
            {
                EquipoAModificar.Nombre = pNombre;
                EquipoAModificar.Tipo = pTipo;
                EquipoAModificar.Estado = pEstado;
                EquipoAModificar.Deposito = pDeposito;
                return true;
            }
            return false;
        }
        #endregion

        #region Clientes

        public List<Cliente> ListarClientes()
        {
            return aListaClientes;
        }
        public Cliente BuscarCliente(int pId)
        {
            foreach (Cliente unCliente in aListaClientes)
            {
                if (unCliente.Id == pId)
                {
                    return unCliente;
                }
            }
            return null;
        }
        public bool AltaCliente(Cliente pCliente)
        {
            Cliente ComparoCliente = BuscarCliente(pCliente.Id);
            if (ComparoCliente == null)
            {
                aListaClientes.Add(pCliente);
                return true;
            }
            return false;
        }
        public bool BajaCliente(int pId)
        {
            Cliente ClienteAEliminar = BuscarCliente(pId);
            if (ClienteAEliminar != null)
            {
                aListaClientes.Remove(ClienteAEliminar);
                return true;
            }
            return false;
        }
        public bool ModificarCliente(int pId, string pNombre, string pApellido, string pDireccion, string pTelefono)
        {
            Cliente ClienteAModificar = BuscarCliente(pId);
            if (ClienteAModificar != null)
            {
                ClienteAModificar.Nombre = pNombre;
                ClienteAModificar.Apellido = pApellido;
                ClienteAModificar.Direccion = pDireccion;
                ClienteAModificar.Telefono = pTelefono;
                return true;
            }
            return false;
        }
        #endregion
    }
}
