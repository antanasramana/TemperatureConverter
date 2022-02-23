using FluentAssertions;
using System;
using System.Collections.Generic;
using Temperature.Domain;
using Xunit;

namespace Temperature.Tests
{
    public class TemperatureConverterTests
    {
        [Theory]
        [MemberData(nameof(FarenheitToCelsiusTestCases))]
        [MemberData(nameof(FarenheitToKelvinTestCases))]
        [MemberData(nameof(CelsiusToKelvinTestCases))]
        public void ConvertFromSpecifiedTemperatureToResultingTemperature_ReturnsExpectedConvertedTemperature(Func<decimal, decimal> convertMethodToUse, decimal temperatureFrom, decimal expectedConvertedTemperature)
        {
            var actualTemperature = convertMethodToUse(temperatureFrom);

            actualTemperature.Should().Be(expectedConvertedTemperature);
        }

        public static IEnumerable<object[]> FarenheitToCelsiusTestCases()
        {
            var convertMethodToUse = new Func<decimal, decimal>(TemperatureConverter.Convert<FarenheitTemperature, CelsiusTemperature>);
            yield return new object[] { convertMethodToUse, 17, -8.333 };
            yield return new object[] { convertMethodToUse, 101.3, 38.5 };
        }

        public static IEnumerable<object[]> FarenheitToKelvinTestCases()
        {
            var convertMethodToUse = new Func<decimal, decimal>(TemperatureConverter.Convert<FarenheitTemperature, KelvinTemperature>);
            yield return new object[] { convertMethodToUse, 28, 270.928 };
            yield return new object[] { convertMethodToUse, 150.74, 339.117 };
        }

        public static IEnumerable<object[]> CelsiusToKelvinTestCases()
        {
            var convertMethodToUse = new Func<decimal, decimal>(TemperatureConverter.Convert<CelsiusTemperature, KelvinTemperature>);
            yield return new object[] { convertMethodToUse, 1, 274.15 };
            yield return new object[] { convertMethodToUse, 101.3, 374.45 };
        }
    }
}
