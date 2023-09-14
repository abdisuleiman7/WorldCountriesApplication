using Countries.API.Core;
using Countries.API.Infrastructure;
using Moq;

namespace Countries.API.Unittests
{
    public class CountryProviderTests
    {

        public CountryProviderTests()
        {
            
        }

        [Fact]
        public void GetCountry_WhenCalled_ReturnsCountry()
        {
            var country = new Country() { Name = new Name() { Common = "Denmark" } };   
            // Arrange
            var mockCountryProvider = new Mock<ICountryProvider>();
            mockCountryProvider.Setup(x => x.GetCountry("Denmark")).ReturnsAsync(new Country[] { new Country() { Name = new Name() { Common = "Denmark" } } });
            var countryProvider = mockCountryProvider.Object;
            // Act
            var result = countryProvider.GetCountry(country.Name.Common);
            // Assert
            Assert.Equal(country.Name.Common, result.Result[0].Name.Common);
        }
    }
}