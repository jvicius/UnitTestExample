namespace ConversorLib
{
    public class ConversorLib : IConversorLib
    {
        public double FahrenheitToCelsius(double number)
        {
            return (number - 32) / 1.8;
        }

        public double FahrenheitToKelvin(double number)
        {
            return CelsiusToKelvin(FahrenheitToCelsius(number));
        }

        public double KelvinToCelsius(double number)
        {
            return number + 273.15;
        }

        public double KelvinToFahrenheit(double number)
        {
            return CelsiusToFahrenheit(KelvinToCelsius(number));
        }

        public double CelsiusToFahrenheit(double number)
        {
            return (number * 1.8) + 32;
        }

        public double CelsiusToKelvin(double number)
        {
            return number + 273.15;
        }
    }
}
