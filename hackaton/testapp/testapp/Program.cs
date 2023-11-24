using System.Text;
using System.Text.Unicode;

Console.WriteLine("Hello, World!");


class sus
{
    static void Main()
    {
        string mypath ="сотрудники.txt";
        string text = "";
        using (StreamReader sr = new(mypath, System.Text.Encoding.Default))
        {
            text = sr.ReadToEnd();
        }

        Console.WriteLine(text);
    }
}