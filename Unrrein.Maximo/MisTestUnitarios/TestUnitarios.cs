using Biblioteca;

namespace MisTestUnitarios
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]        //GIVEN - WHEN - THEN
        public void TesteoNombreYApellido()
        {
            //ARRANGE (preparacion)
            bool valorEsperado = false;
            bool resutaldo;

            //ACT (Invocacion de los metodos a probar)

            resutaldo = Validaciones.NombreYApellido("Pedro2322");

            //ASSERT (Evaluacion de los resultados)
            Assert.AreEqual(valorEsperado, resutaldo);
        }


        [TestMethod]
        public void TesteoDNI()
        {
            //ARRANGE (preparacion)
            bool valorEsperado = false;
            bool resutaldo;

            //ACT (Invocacion de los metodos a probar)

            resutaldo = Validaciones.DNI("123456789");

            //ASSERT (Evaluacion de los resultados)
            Assert.AreEqual(valorEsperado, resutaldo);
        }



        [TestMethod]
        public void TesteoMail()
        {
            //ARRANGE (preparacion)
            bool valorEsperado = false;
            bool resutaldo;

            //ACT (Invocacion de los metodos a probar)

            resutaldo = Validaciones.Mail("@gmail.com");

            //ASSERT (Evaluacion de los resultados)
            Assert.AreEqual(valorEsperado, resutaldo);
        }
    }
}