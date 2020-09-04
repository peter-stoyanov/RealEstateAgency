namespace RealEstateAgency.Domain
{
    using FluentAssertions;
    using Models;
    using RealEstateAgency.Models;
    using Xunit;

    public class ValueObjectSpecs
    {
        [Fact]
        public void ValueObjectsWithEqualPropertiesShouldBeEqual()
        {
            // Arrange
            var first = new Features(2);
            var second = new Features(2);

            // Act
            var result = first == second;

            // Arrange
            result.Should().BeTrue();
        }

        [Fact]
        public void ValueObjectsWithDifferentPropertiesShouldNotBeEqual()
        {
            // Arrange
            var first = new Features(3);
            var second = new Features(5);

            // Act
            var result = first == second;

            // Arrange
            result.Should().BeFalse();
        }
    }
}
