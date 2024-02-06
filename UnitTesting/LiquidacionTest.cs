using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class LiquidacionTest
    {
        [TestMethod]
        public void VerificarExcepcionNumerosNegativos()
        {
            Liquidacion objLiquidacion = new Liquidacion();

            Assert.ThrowsException<Exception>(() => objLiquidacion.CalcularLiquidacion(50,-100,70));
        }
    }
}
