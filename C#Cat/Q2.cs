
//Q2
/*
 * == is used when comparing value types or checking if two references point to the same object.
 * Equals() is used when comparing the content of two objects, especially if the class overrides Equals() to provide custom equality logic.
 */

string str1 = "Hello";
string str2 = "Hello";
string str3 = new string(new char[] { 'H', 'e', 'l', 'l', 'o' });
Console.WriteLine(str1 == str2);
// Result true
Console.WriteLine(str1 == str3);
//Result true
Console.WriteLine(str1.Equals(str3));
//Result false


