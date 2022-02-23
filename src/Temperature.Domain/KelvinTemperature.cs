namespace Temperature.Domain
{
    public class KelvinTemperature : ITemperature
    {
        public KelvinTemperature()
        {

        }

        public decimal GetFromKelvin(decimal kelvinTemperature)
        {
            return kelvinTemperature;
        }

        public decimal ToKelvin(decimal kelvinTemperature)
        {
            return kelvinTemperature;
        }
    }
}
