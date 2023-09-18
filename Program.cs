// See https://aka.ms/new-console-template for more information

string myStr = "kkllmmnnoo";
Console.WriteLine("Initial String: " + myStr);
var unique = new HashSet<char>(myStr);
Console.Write("New String after removing duplicates: ");
foreach (char c in unique)
    Console.Write(c);
