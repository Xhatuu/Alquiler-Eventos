namespace Alquiler_Eventos.Dominio
{
    public class Controladora
    {
        private static List<Equipamiento> aListaEquipamientos = new List<Equipamiento>();
        private static List<Cliente> aListaClientes = new List<Cliente>();

        private static List<Solicitud> aListaSolicitudes = new List<Solicitud>();

        #region Equipos

        public List<Equipamiento> ListarEquipamientos()
        {
            return aListaEquipamientos;
        }
        public Equipamiento BuscarEquipamiento(int pId)
        {
            foreach (Equipamiento unEquipamiento in aListaEquipamientos)
            {
                if(unEquipamiento.Id == pId)
                {
                    return unEquipamiento;
                }
            }
            return null;
        }
        public bool AltaEquipamiento(Equipamiento pEquipamiento)
        {
            Equipamiento ComparoEquipamiento = BuscarEquipamiento(pEquipamiento.Id);
            if(ComparoEquipamiento == null)
            {
                aListaEquipamientos.Add(pEquipamiento);
                return true;
            }
            return false;
        }
        public bool BajaEquipamiento(int pId)
        {
            Equipamiento EquipamientoAEliminar = BuscarEquipamiento(pId);
            if(EquipamientoAEliminar != null)
            {
                aListaEquipamientos.Remove(EquipamientoAEliminar);
                return true;
            }
            return false;
        }
        public bool ModificarEquipamiento(int pId, string pCodigo, string pEstado, Deposito pDeposito, TipoEquipamiento pTipoEquipamiento, string pObservaciones)
        {
            Equipamiento EquipamientoAModificar = BuscarEquipamiento(pId);
            if(EquipamientoAModificar != null)
            {
                EquipamientoAModificar.Codigo = pCodigo;
                EquipamientoAModificar.Estado = pEstado;
                EquipamientoAModificar.Deposito = pDeposito;
                EquipamientoAModificar.TipoEquipamiento = pTipoEquipamiento;
                EquipamientoAModificar.Observaciones = pObservaciones;
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
        public bool ModificarCliente(int pId, string pNombre, string pTipo, string pDocumento, string pDireccion, string pTelefono, string pEmail, bool pActivo)
        {
            Cliente ClienteAModificar = BuscarCliente(pId);
            if (ClienteAModificar != null)
            {
                ClienteAModificar.Nombre = pNombre;
                ClienteAModificar.Tipo = pTipo;
                ClienteAModificar.Documento = pDocumento;
                ClienteAModificar.Direccion = pDireccion;
                ClienteAModificar.Telefono = pTelefono;
                ClienteAModificar.Email = pEmail;
                ClienteAModificar.Activo = pActivo;
                return true;
            }
            return false;
        }
        #endregion

        #region Solicitudes

        public List<Solicitud> ListarSolicitudes()
        {
            return aListaSolicitudes;
        }
        public Solicitud BuscarSolicitud(int pId)
        {
            foreach (Solicitud unaSolicitud in aListaSolicitudes)
            {
                if (unaSolicitud.Id == pId)
                {
                    return unaSolicitud;
                }
            }
            return null;
        }
        public bool AltaSolicitud(Solicitud pSolicitud)
        {
            Solicitud ComparoSolicitud = BuscarSolicitud(pSolicitud.Id);
            if (ComparoSolicitud == null)
            {
                aListaSolicitudes.Add(pSolicitud);
                return true;
            }
            return false;
        }
        public bool BajaSolicitud(int pId)
        {
            Solicitud SolicitudAEliminar = BuscarSolicitud(pId);
            if (SolicitudAEliminar != null)
            {
                aListaSolicitudes.Remove(SolicitudAEliminar);
                return true;
            }
            return false;
        }
        public bool ModificarSolicitud(int pId, DateTime pFecha, string pEstado, Cliente pCliente, Evento pEvento, string pObservaciones)
        {
            Solicitud SolicitudAModificar = BuscarSolicitud(pId);
            if (SolicitudAModificar != null)
            {
                SolicitudAModificar.Fecha = pFecha;
                SolicitudAModificar.Estado = pEstado;
                SolicitudAModificar.Cliente = pCliente;
                SolicitudAModificar.Evento = pEvento;
                SolicitudAModificar.Observaciones = pObservaciones;
                return true;
            }
            return false;
        }
        #endregion
    }
}
