namespace Temperature.Domain
{
    public interface ITemperature
    {
        decimal ToKelvin();
        decimal GetTemperatureFromKelvin(decimal fromTemperature);
    }
}
