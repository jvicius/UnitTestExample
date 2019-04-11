using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestConversor
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFahrenheitToCelsius()
        {
            var number = 32.0;
            var service = new ConversorLib.ConversorLib();
            Assert.AreEqual(service.FahrenheitToCelsius(number), 0, 0.1);
        }

        [TestMethod]
        public void TestFahrenheitToKelvin()
        {
            var number = 32.0;
            var service = new ConversorLib.ConversorLib();
            Assert.AreEqual(service.FahrenheitToKelvin(number), 273.15, 0.1);
        }

        [TestMethod]
        public void TestCelsiusToFahrenheit()
        {
            var number = 32.0;
            var service = new ConversorLib.ConversorLib();
            Assert.AreEqual(service.CelsiusToFahrenheit(number), 89.6, 0.1);
        }

        [TestMethod]
        public void TestCelsiusToKelvin()
        {
            var number = 32.0;
            var service = new ConversorLib.ConversorLib();
            Assert.AreEqual(service.CelsiusToKelvin(number), 305.15, 0.1);
        }

        [TestMethod]
        public void TestKelvinToCelsius()
        {
            var number = 32.0;
            var service = new ConversorLib.ConversorLib();;
            Assert.AreEqual(service.KelvinToCelsius(number), -241.15,0.1);
        }

        [TestMethod]
        public void TestKelvinToFahrenheit()
        {
            var number = 32.0;
            var service = new ConversorLib.ConversorLib();
            Assert.AreEqual(service.KelvinToFahrenheit(number), -402.07, 0.1);
        }
    }
}