using Xunit;

namespace Bricelam.EntityFrameworkCore.Design
{
    public class PluralizerTests
    {
        [Fact]
        public void Pluralize_works()
            => Assert.Equal("Tests", new Pluralizer().Pluralize("Test"));

        [Fact]
        public void Singularize_works()
            => Assert.Equal("Test", new Pluralizer().Singularize("Tests"));

        [Fact]
        public void Signularize_with_numeral_works()
            => Assert.Equal("Just1Test", new Pluralizer().Singularize("Just1Tests"));
    }
}
