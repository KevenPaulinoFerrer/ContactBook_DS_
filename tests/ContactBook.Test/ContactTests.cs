using Xunit;
using ContactBookApp;


namespace ContactBook.Tests
{
    public class ContactTests
    {
        // ----------------------------
        // Constructor Tests
        // ----------------------------
        [Fact]
        public void DefaultConstructor_ShouldInitializeEmptyStrings()
        {
            var contact = new Contact();

            Assert.Equal("", contact.GetFName());
            Assert.Equal("", contact.GetLName());
            Assert.Equal("", contact.GetPhone());
            Assert.Equal("", contact.GetEmail());
        }

        [Fact]
        public void ParameterizedConstructor_ShouldSetValuesCorrectly()
        {
            var contact = new Contact("John", "Doe", "123", "john@test.com");

            Assert.Equal("John", contact.GetFName());
            Assert.Equal("Doe", contact.GetLName());
            Assert.Equal("123", contact.GetPhone());
            Assert.Equal("john@test.com", contact.GetEmail());
        }

        // ----------------------------
        // Setter & Getter Tests
        // ----------------------------
        [Fact]
        public void Setters_ShouldUpdateValues()
        {
            var contact = new Contact();

            contact.SetFName("Jane");
            contact.SetLName("Smith");
            contact.SetPhone("456");
            contact.SetEmail("jane@test.com");

            Assert.Equal("Jane", contact.GetFName());
            Assert.Equal("Smith", contact.GetLName());
            Assert.Equal("456", contact.GetPhone());
            Assert.Equal("jane@test.com", contact.GetEmail());
        }

        // ----------------------------
        // ToString Test
        // ----------------------------
        [Fact]
        public void ToString_ShouldReturnFormattedString()
        {
            var contact = new Contact("John", "Doe", "123", "john@test.com");

            var expected = "Contact[fname =John, lname=Doe, phone=123, email=john@test.com]";
            Assert.Equal(expected, contact.ToString());
        }

        // ----------------------------
        // Equality Tests
        // ----------------------------
        [Fact]
        public void Equals_SameValues_ShouldBeTrue()
        {
            var c1 = new Contact("John", "Doe", "123", "john@test.com");
            var c2 = new Contact("John", "Doe", "123", "john@test.com");

            Assert.True(c1.Equals(c2));
            Assert.True(c1 == c2);
            Assert.False(c1 != c2);
        }

        [Fact]
        public void Equals_DifferentValues_ShouldBeFalse()
        {
            var c1 = new Contact("John", "Doe", "123", "john@test.com");
            var c2 = new Contact("Jane", "Doe", "123", "john@test.com");

            Assert.False(c1.Equals(c2));
            Assert.False(c1 == c2);
            Assert.True(c1 != c2);
        }

        [Fact]
        public void Equals_Null_ShouldBeFalse()
        {
            var c1 = new Contact("John", "Doe", "123", "john@test.com");

            Assert.False(c1.Equals(null));
            Assert.False(c1 == null);
            Assert.True(c1 != null);
        }

        [Fact]
        public void Equals_SameReference_ShouldBeTrue()
        {
            var c1 = new Contact("John", "Doe", "123", "john@test.com");

            Assert.True(c1.Equals(c1));
        }

        [Fact]
        public void Equals_ObjectOverride_ShouldWork()
        {
            object c1 = new Contact("John", "Doe", "123", "john@test.com");
            object c2 = new Contact("John", "Doe", "123", "john@test.com");

            Assert.True(c1.Equals(c2));
        }

        // ----------------------------
        // HashCode Tests
        // ----------------------------
        [Fact]
        public void GetHashCode_SameValues_ShouldBeEqual()
        {
            var c1 = new Contact("John", "Doe", "123", "john@test.com");
            var c2 = new Contact("John", "Doe", "123", "john@test.com");

            Assert.Equal(c1.GetHashCode(), c2.GetHashCode());
        }

        [Fact]
        public void GetHashCode_DifferentValues_ShouldBeDifferent()
        {
            var c1 = new Contact("John", "Doe", "123", "john@test.com");
            var c2 = new Contact("Jane", "Doe", "123", "john@test.com");

            Assert.NotEqual(c1.GetHashCode(), c2.GetHashCode());
        }

        // ----------------------------
        // Edge Cases
        // ----------------------------
        [Fact]
        public void Allows_EmptyStrings()
        {
            var contact = new Contact("", "", "", "");

            Assert.Equal("", contact.GetFName());
            Assert.Equal("", contact.GetLName());
            Assert.Equal("", contact.GetPhone());
            Assert.Equal("", contact.GetEmail());
        }

        [Fact]
        public void Changing_OneField_ShouldAffectEquality()
        {
            var c1 = new Contact("John", "Doe", "123", "john@test.com");
            var c2 = new Contact("John", "Doe", "123", "john@test.com");

            c2.SetEmail("different@test.com");

            Assert.False(c1.Equals(c2));
        }
    }
}