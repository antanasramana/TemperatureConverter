namespace Temperature.Domain
{
    public static class TemperatureConverter
    {
        public static decimal Convert<TFrom, TResult>(decimal temperature) 
            where TFrom : ITemperature, new()
            where TResult : ITemperature, new()
        {
            var fromTemperature = new TFrom();
            var resultTemperature = new TResult();
            
            var fromTemperatureInKelvin = fromTemperature.ToKelvin();

            return resultTemperature.GetTemperatureFromKelvin(fromTemperatureInKelvin);
        }
    }
}
