using System;

namespace Temperature.Domain
{
    public class FarenheitTemperature : ITemperature
    {
        public FarenheitTemperature()
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
