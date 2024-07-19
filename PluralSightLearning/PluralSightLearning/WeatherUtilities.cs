using System;

namespace MyUtilities
{
     class WeatherUtilities
    {
        public static float FarenheitToCelsius(float temperatureFahrenheit)
        {
            return (temperatureFahrenheit - 32) / 1.8f;
        }

        public static float CelsiusToFahrenheit(float temperatureCelsius)
        {
            return (temperatureCelsius * 1.8f) + 32;
        }

        //Calcula o indice de conforto através de uma formula da internet, uma formula não muito confiável...
        private static float ComfortIndex(float temepreatureFahrenheit, float humidityPercent)
        {
            return (temepreatureFahrenheit + humidityPercent) / 4;
            //Quanto maior o retorno, pior o conforto.
        }

        public static void Report(string location, float temperatureCelsius, float humidity)
        {
            var temeperatureFahrenheit = CelsiusToFahrenheit(temperatureCelsius);
            Console.WriteLine($"Confort Index for {location}: {ComfortIndex(temeperatureFahrenheit, humidity)}");
        }
    }
}
