using FundamentosCSharp.OrientacionObjetos;

List<Cotizante> lstObjCotizantes = new List<Cotizante>
{
    new Cotizante{ Nombre = "Uber", Apellido = "Marin", TipoCotizante = 1 },
    new Cotizante { Nombre = "Antonio", Apellido = "Arboleda", TipoCotizante = 59 },
    new Cotizante { Nombre = "Prueba 1", Apellido = "Prueba 1", TipoCotizante = 2 },
    new Cotizante { Nombre = "Prueba 2", Apellido = "Perez", TipoCotizante = 1 },
    new Cotizante { Nombre = "Prueba 3", Apellido = "Gomez", TipoCotizante = 59 },
    new Cotizante { Nombre = "Prueba 4", Apellido = "Prueba 4", TipoCotizante = 5 },
    new Cotizante { Nombre = "Prueba 5", Apellido = "Prueba 5", TipoCotizante = 3 },
    new Cotizante { Nombre = "Prueba 6", Apellido = "Prueba 6", TipoCotizante = 7 },
    new Cotizante { Nombre = "Prueba 7", Apellido = "Prueba 7", TipoCotizante = 9 },
    new Cotizante { Nombre = "Prueba 8", Apellido = "Prueba 8", TipoCotizante = 15 }
};

var lstObjCotizantesFiltrados = lstObjCotizantes
    .Where(c => c.TipoCotizante == 1 || c.TipoCotizante == 59)
    .OrderBy(c => c.Apellido);

foreach (var item in lstObjCotizantesFiltrados)
{
    item.ImprimirDatosBasicos();
}