namespace Temperature.Domain
{
    public class FarenheitTemperature : ITemperature
    {
        public decimal GetFromKelvin(decimal kelvinTemperature)
        {
            var farenheitTemperature = kelvinTemperature * 9m / 5m - 459.67m;
            return decimal.Round(farenheitTemperature, 3);
        }

        public decimal ToKelvin(decimal farenheitTemperature)
        {
            var kelvinTemperature = 5m / 9m * (farenheitTemperature + 459.67m);
            return decimal.Round(kelvinTemperature, 3);
        }
    }
}
