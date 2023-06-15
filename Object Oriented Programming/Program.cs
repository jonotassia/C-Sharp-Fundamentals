using Object_Oriented_Programming;

Book b1 = new Book("Jono's Diary", 10, 0, "Jono");

Console.WriteLine(b1.Description);

// The two belows are the same since we have overwritten ToString
Console.WriteLine(b1);
Console.WriteLine(b1.ToString());

Console.WriteLine(b1.ToString('B'));
Console.WriteLine(b1.ToString('F'));
