

//1. Manejo de tareas asíncronas

string resultado = await SimularValidacionAsync();

Console.WriteLine(resultado);

async Task<string> SimularValidacionAsync()
{
    Console.WriteLine("Empezó la validación del archivo de texto.");

    await Task.Delay(10000);

    bool resultadoExitoso = new Random().Next(2) == 1;

    if (resultadoExitoso)
        return "Exitoso";
    else
        return "Fallido";
}

Console.WriteLine("\n");
//2. Manejo de tareas paralelas


int[] arrNumeros = { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90 };
int intSuma = 0;

CancellationTokenSource cts = new CancellationTokenSource();
CancellationToken token = cts.Token;

Task tareaSuma = Task.Run(() =>
{
    foreach (int numero in arrNumeros)
    {
        intSuma += numero;
        if (intSuma >= 200)
        {
            cts.Cancel();
            break;
        }
    }
}, token);

Task tareaValidacion = Task.Run(() =>
{
    while (!token.IsCancellationRequested)
    {
        Console.WriteLine("El valor aún no llega a 200.");
    }

    Console.WriteLine("El valor es igual o mayor a 200.");
}, token);

await Task.WhenAll(tareaSuma, tareaValidacion);

Console.WriteLine("\n");