using FluentAssertions;
using Temperature.Domain;
using Xunit;

namespace Temperature.Tests
{
    public class FarenheitTemperatureTests
    {
        [Theory]
        [InlineData(334.26, 141.998)]
        [InlineData(262.33, 12.524)]
        [InlineData(1, -457.87)]
        public void GetFromKelvin_WhenKelvinIsSpecified_ReturnsExpectedFarenheitTemperature(decimal kelvin, decimal expectedFarenheit)
        {
            var farenheitTemperature = new FarenheitTemperature();

            var actualFarenheit = farenheitTemperature.GetFromKelvin(kelvin);

            actualFarenheit.Should().Be(expectedFarenheit);
        }

        [Theory]
        [InlineData(141.998, 334.26)]
        [InlineData(12.524, 262.33)]
        [InlineData(-457.87, 1)]
        public void ToKelvin_WhenFarenheitSpecified_ReturnsExpectedKelvinTemperature(decimal farenheit, decimal expectedKelvin)
        {
            var farenheitTemperature = new FarenheitTemperature();

            var actualKelvin = farenheitTemperature.ToKelvin(farenheit);

            actualKelvin.Should().Be(expectedKelvin);
        }
    }
}
