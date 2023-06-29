
var str = "HelloWorld";

for (int i = 1; i <= str.Length; i++)
{
    for (int j = 0; j <= str.Length - i; j++)
    {
        var substr = str.Substring(j, i);
        Console.WriteLine(substr);

    }

}
