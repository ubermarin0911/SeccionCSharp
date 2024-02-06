
namespace Testing
{
    public class Liquidacion
    {
        public int CalcularLiquidacion(int prmIntNumero1, int prmIntNumero2, int prmIntNumero3)
        {
            if (prmIntNumero1 < 0 || prmIntNumero2 < 0 || prmIntNumero3 < 0)
            {
                throw new Exception("Los números no pueden ser negativos.");
            }

            return prmIntNumero1 + prmIntNumero2 + prmIntNumero3;
        }
    }
}
