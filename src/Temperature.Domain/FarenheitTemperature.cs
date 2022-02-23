using System;

namespace Temperature.Domain
{
    public class FarenheitTemperature : ITemperature
    {
        public decimal GetFromKelvin(decimal kelvinTemperature)
        {
            return Decimal.Round(kelvinTemperature * 9m / 5m - 459.67m, 3);
        }

        public decimal ToKelvin(decimal farenheitTemperature)
        {
            return Decimal.Round(5m / 9m * (farenheitTemperature + 459.67m), 3);
        }
    }
}
