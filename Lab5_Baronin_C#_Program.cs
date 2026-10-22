using Lab5_Baronin;

User user = new User(1, "Олександр", "alex@example.com");

Console.WriteLine(user.ToString());
Console.WriteLine(user);

User user1 = new User(1, "Олександр", "alex@example.com");
User user2 = new User(1, "Олександр", "alex@example.com");
User user3 = new User(2, "Андрій", "andrii@example.com");

Console.WriteLine(user1.Equals(user2));
Console.WriteLine(user1.Equals(user3));
Console.WriteLine(user1.Equals(null));
