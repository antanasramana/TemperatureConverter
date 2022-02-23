namespace Temperature.Domain
{
    public class CelsiusTemperature : ITemperature
    {
        public decimal GetFromKelvin(decimal kelvinTemperature)
        {
            return kelvinTemperature - 273.15m;
        }

        public decimal ToKelvin(decimal celsiusTemperature)
        {
            return celsiusTemperature + 273.15m;
        }
    }
}
