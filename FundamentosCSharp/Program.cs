using FundamentosCSharp.InyeccionDependencias;
using FundamentosCSharp.OrientacionObjetos;

//1. Sintaxis y estructuras de control

int intNumeroEntero = 10;

if (intNumeroEntero > 0)
{
    Console.WriteLine("El número es positivo");
}
else
{
    Console.WriteLine("El número es cero o negativo");
}

Console.WriteLine("\n");
//2. Orientación a objetos

try
{
    Cotizante objCotizante = new Cotizante
    {
        Nombre = "Uber",
        Apellido = "Marin",
        TipoCotizante = 1
    };

    objCotizante.ImprimirDatosBasicos();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine("\n");

//3. Inyección de dependencias

Notificaciones objCorreoElectronico = new Notificaciones(new CorreoElectronico());
objCorreoElectronico.EnviarNotificacion("Mensaje desde el correo electrónico.");

Notificaciones objSMS = new Notificaciones(new SMS());
objSMS.EnviarNotificacion("Mensaje desde SMS.");


Console.WriteLine("\n");
