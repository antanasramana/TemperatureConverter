namespace Temperature.Domain
{
    public interface ITemperature
    {
        decimal ToKelvin(decimal temperature);
        decimal GetFromKelvin(decimal temperature);
    }
}
