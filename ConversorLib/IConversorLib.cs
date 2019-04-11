namespace ConversorLib
{
    public interface IConversorLib
    {
        double FahrenheitToCelsius(double number);
        double FahrenheitToKelvin(double number);
        double KelvinToCelsius(double number);
        double KelvinToFahrenheit(double number);
        double CelsiusToFahrenheit(double number);
        double CelsiusToKelvin(double number);
    }
}
