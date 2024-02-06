namespace FundamentosCSharp.OrientacionObjetos
{
    public class Cotizante
    {
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (value.Length > 30)
                {
                    throw new ArgumentException("El nombre no puede tener más de 30 caracteres.");
                }
                _nombre = value;
            }
        }

        private string _apellido;
        public string Apellido
        {
            get { return _apellido; }
            set
            {
                if (value.Length > 30)
                {
                    throw new ArgumentException("El apellido no puede tener más de 30 caracteres.");
                }
                _apellido = value;
            }
        }

        private short _tipoCotizante;
        public short TipoCotizante
        {
            get { return _tipoCotizante; }
            set
            {
                if (value.ToString().Length > 2)
                {
                    throw new ArgumentException("El tipo de cotizante no puede tener más de 2 dígitos.");
                }
                _tipoCotizante = value;
            }
        }

        public void ImprimirDatosBasicos()
        {
            Console.WriteLine($"Nombre: {Nombre}, Apellido: {Apellido}, Tipo de cotizante: {TipoCotizante}");
        }
    }
}
