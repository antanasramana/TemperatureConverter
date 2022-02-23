using FluentAssertions;
using Temperature.Domain;
using Xunit;

namespace Temperature.Tests
{
    public class CelsiusTemperatureTests
    {
        [Theory]
        [InlineData(274.15, 1)]
        [InlineData(100, -173.15)]
        [InlineData(334.153, 61.003)]
        public void GetFromKelvin_WhenKelvinIsSpecified_ReturnsExpectedCelsiusTemperature(decimal kelvin, decimal expectedCelsius)
        {
            var celsiusTemperature = new CelsiusTemperature();

            var actualCelsius = celsiusTemperature.GetFromKelvin(kelvin);

            actualCelsius.Should().Be(expectedCelsius);
        }

        [Theory]
        [InlineData(1, 274.15)]
        [InlineData(-173.15, 100)]
        [InlineData(61.003, 334.153)]
        public void ToKelvin_WhenCelsiusSpecified_ReturnsExpectedKelvinTemperature(decimal celsius, decimal expectedKelvin)
        {
            var celsiusTemperature = new CelsiusTemperature();

            var actualKelvin = celsiusTemperature.ToKelvin(celsius);

            actualKelvin.Should().Be(expectedKelvin);
        }
    }
}
