using System;

namespace Temperature.Domain
{
    public class CelsiusTemperature : ITemperature
    {
        public CelsiusTemperature()
        {

        }

        public decimal GetTemperatureFromKelvin(decimal fromTemperature)
        {
            throw new NotImplementedException();
        }

        public decimal ToKelvin()
        {
            throw new NotImplementedException();
        }
    }
}
