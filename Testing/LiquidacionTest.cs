using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class LiquidacionTest
    {
        [TestMethod]
        public void VerificarExcepcionNumerosNegativos()
        {
            Liquidacion objLiquidacion = new Liquidacion();

            Assert.ThrowsException<Exception>(() => objLiquidacion.CalcularLiquidacion(1,2,3));
        }
    }
}
