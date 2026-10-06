Dictionary<string, int> phones = new();
Stack<PhoneAction> history = new();
Stack<PhoneAction> redoHistory = new();

phones["Mark"] = 100;
history.Push(new PhoneAction("Mark", 100));

phones["Jeremy"] = 135;
history.Push(new PhoneAction("Jeremy", 135));

phones["Vanessa"] = 340;
history.Push(new PhoneAction("Vanessa", 340));

if (phones.TryGetValue("Mark", out int n))
    Console.WriteLine(n);

if (phones.TryGetValue("Vanessa", out int i))
    Console.WriteLine(i);

// Undo
PhoneAction lastAction = history.Pop();
Console.WriteLine(lastAction);
Console.WriteLine(lastAction.Name);
Console.WriteLine(lastAction.Phone);

phones.Remove(lastAction.Name);
redoHistory.Push(lastAction);

Console.WriteLine("\nПiсля Undo:");

foreach (var phone in phones)
{
    Console.WriteLine($"{phone.Key} - {phone.Value}");
}

// Redo
PhoneAction redoAction = redoHistory.Pop();

phones[redoAction.Name] = redoAction.Phone;
history.Push(redoAction);

Console.WriteLine("\nПiсля Redo:");

foreach (var phone in phones)
{
    Console.WriteLine($"{phone.Key} - {phone.Value}");
}

record PhoneAction(string Name, int Phone);
