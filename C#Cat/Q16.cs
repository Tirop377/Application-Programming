//16.Predict the output of the following code:

int[] array = { 1, 2, 3, 4, 5 };

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

/*Output:
 * 1
 * 2
 * 3
 * 4
 * 5
 */


//a Predict the output of the following code:

string str1 = "Hello";
string str2 = "hello";

Console.WriteLine(str1.Equals(str2, StringComparison.OrdinalIgnoreCase));
//Output:True

//b Predict the output of the following code:
object obj1 = new object();
object obj2 = new object();
Console.WriteLine(obj1 == obj2);
//Output:false

//c Predict the output of the following code:
int a = 5;
int b = 10;
Console.WriteLine(a += b);

//Ouptput: 15


