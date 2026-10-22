using Lab5_Baronin;

namespace UnitTests_Lab5
{
    public class UnitTest1
    {
        [Fact]
        public void ToString_ReturnsCorrectText()
        {
            User user = new User(
                1,
                "Олександр",
                "alex@example.com");

            string result = user.ToString();

            Assert.Equal(
                "User: ID=1, Name=Олександр, Email=alex@example.com",
                result);
        }


        [Fact]
        public void Constructor_ThrowsException_WhenIdIsInvalid()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                new User(0, "Олександр", "alex@example.com"));
        }



        [Fact]
        public void Name_ThrowsException_WhenValueIsEmpty()
        {
            User user = new User(
                1, "Олександр", "alex@example.com");

            Assert.Throws<ArgumentException>(() =>
                user.Name = "");
        }


        [Fact]
        public void Email_ThrowsException_WhenValueIsEmpty()
        {
            User user = new User(
                1, "Олександр", "alex@example.com");

            Assert.Throws<ArgumentException>(() =>
                user.Email = "");
        }


        [Fact]
        public void Equals_ReturnsTrue_WhenIdsAreEqual()
        {
            User user1 = new User(
                1, "Олександр", "alex@example.com");

            User user2 = new User(
                1, "Андрій", "andrii@example.com");

            Assert.True(user1.Equals(user2));
        }



        [Fact]
        public void Equals_ReturnsFalse_WhenIdsAreDifferent()
        {
            User user1 = new User(
                1, "Олександр", "alex@example.com");

            User user2 = new User(
                7, "Андрій", "andrii@example.com");

            Assert.False(user1.Equals(user2));
        }

        [Fact]
        public void Equals_ReturnsFalse_WhenObjectIsNull()
        {
            User user1 = new User(
                1, "Олександр", "alex@example.com");

            Assert.False(user1.Equals(null));
        }
    }
}
