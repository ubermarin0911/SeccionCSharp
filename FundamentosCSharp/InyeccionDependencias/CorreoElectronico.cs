

namespace FundamentosCSharp.InyeccionDependencias
{
    public class CorreoElectronico : INotificacion
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine($"Se envía correo electrónico: {mensaje}");
        }
    }
}
