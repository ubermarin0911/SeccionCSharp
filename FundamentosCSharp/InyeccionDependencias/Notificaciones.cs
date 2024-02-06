
namespace FundamentosCSharp.InyeccionDependencias
{
    public class Notificaciones
    {
        private INotificacion _INotificacion;

        public Notificaciones(INotificacion INotificacion)
        {
            this._INotificacion = INotificacion;
        }

        public void EnviarNotificacion(string mensaje)
        {
            _INotificacion.Enviar(mensaje);
        }

    }
}
