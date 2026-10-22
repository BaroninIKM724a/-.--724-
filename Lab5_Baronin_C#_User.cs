namespace Lab5_Baronin
{
    public class User
    {
        private int id;
        private string name = string.Empty;
        private string email = string.Empty;

        public User(int id, string name, string email)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id),
                    "ID must be greater than zero.");

            this.id = id;
            Name = name;
            Email = email;
        }

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(
                        "Name cannot be empty.", nameof(value));

                name = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) ||
                    !value.Contains('@'))
                    throw new ArgumentException(
                        "Email must be valid.", nameof(value));

                email = value;
            }
        }

        public override string ToString()
        {
            return $"User: ID={Id}, Name={Name}, Email={Email}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is not User other)
                return false;

            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
