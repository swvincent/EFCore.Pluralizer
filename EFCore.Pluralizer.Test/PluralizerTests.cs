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
        public void Pluralize_with_numeral_works()
            => Assert.Equal("Just1Tests", new Pluralizer().Pluralize("Just1Test"));

        [Fact]
        public void Pluralize_with_numeral_first_works()
            => Assert.Equal("1Tests", new Pluralizer().Pluralize("1Test"));

        [Fact]
        public void Singularize_with_numeral_works()
            => Assert.Equal("Just1Test", new Pluralizer().Singularize("Just1Tests"));

        [Fact]
        public void Singularize_with_numeral_first_works()
            => Assert.Equal("1Test", new Pluralizer().Singularize("1Tests"));

        [Fact]
        public void Pluralarize_with_non_alphanumeric_fails()
            => Assert.NotEqual("Just_Tests", new Pluralizer().Singularize("Just_Test"));

        [Fact]
        public void Singularize_with_non_alphanumeric_fails()
            => Assert.NotEqual("Just_Test", new Pluralizer().Singularize("Just_Tests"));
    }
}
