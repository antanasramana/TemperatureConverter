using FluentAssertions;
using Temperature.Domain;
using Xunit;

namespace Temperature.Tests
{
    public class KelvinTemperatureTests
    {
        [Theory]
        [InlineData(274.15, 274.15)]
        [InlineData(100, 100)]
        public void GetFromKelvin_WhenKelvinIsSpecified_ReturnsExpectedKelvinTemperature(decimal kelvin, decimal expectedKelvin)
        {
            var kelvinTemperature = new KelvinTemperature();

            var actualCelsius = kelvinTemperature.GetFromKelvin(kelvin);

            actualCelsius.Should().Be(expectedKelvin);
        }

        [Theory]
        [InlineData(274.15, 274.15)]
        [InlineData(100, 100)]
        public void ToKelvin_WhenCelsiusSpecified_ReturnsExpectedKelvinTemperature(decimal kelvin, decimal expectedKelvin)
        {
            var kelvinTemperature = new KelvinTemperature();

            var actualKelvin = kelvinTemperature.ToKelvin(kelvin);

            actualKelvin.Should().Be(expectedKelvin);
        }
    }
}
