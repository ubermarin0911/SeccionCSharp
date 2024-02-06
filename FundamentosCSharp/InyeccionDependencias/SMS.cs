
namespace FundamentosCSharp.InyeccionDependencias
{
    public class SMS : INotificacion
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine($"Se envía SMS: {mensaje}");
        }
    }
}
