using Xunit;

namespace Swvincent.EntityFrameworkCore.Design
{
    public class PluralizerTests
    {

        // Original tests

        [Fact]
        public void Pluralize_works()
            => Assert.Equal("Tests", new Pluralizer().Pluralize("Test"));

        [Fact]
        public void Singularize_works()
            => Assert.Equal("Test", new Pluralizer().Singularize("Tests"));

        // Tests with numeral in string

        [Fact]
        public void Pluralize_with_numeral_works()
            => Assert.Equal("Just1Tests", new Pluralizer().Pluralize("Just1Test"));

        [Fact]
        public void Pluralize_with_numeral_first_works()
            => Assert.Equal("1Tests", new Pluralizer().Pluralize("1Test"));

        [Fact]
        public void Pluralize_with_numeral_last_unchanged()
            => Assert.Equal("Test1", new Pluralizer().Pluralize("Test1"));

        [Fact]
        public void Singularize_with_numeral_works()
            => Assert.Equal("Just1Test", new Pluralizer().Singularize("Just1Tests"));

        [Fact]
        public void Singularize_with_numeral_first_works()
            => Assert.Equal("1Test", new Pluralizer().Singularize("1Tests"));

        [Fact]
        public void Singularize_with_numeral_last_unchanged()
            => Assert.Equal("Tests1", new Pluralizer().Singularize("Tests1"));

        // Non-alphanumeric should not change

        [Fact]
        public void Pluralarize_with_non_alphanumeric_unchanged()
            => Assert.NotEqual("Just_Tests", new Pluralizer().Singularize("Just_Test"));

        [Fact]
        public void Singularize_with_non_alphanumeric_unchanged()
            => Assert.NotEqual("Just_Test", new Pluralizer().Singularize("Just_Tests"));

        // Ensure empty strings don't cause exceptions

        [Fact]
        public void Pluralize_Empty_String()
             => Assert.Equal("", new Pluralizer().Pluralize(""));

        [Fact]
        public void Singularize_Empty_String()
             => Assert.Equal("", new Pluralizer().Singularize(""));
    }
}
