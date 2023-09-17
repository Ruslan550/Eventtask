using System;


delegate void Func(string str);

class MyClass
{
    public void Space(string str)
    {
        
        string result = string.Join("_", str.ToCharArray());
        Console.WriteLine("Space: " + result);
    }

    public void Reverse(string str)
    {
      
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string result = new string(charArray);
        Console.WriteLine("Reverse: " + result);
    }
}


class Run
{
    public void runFunc(Func func, string str)
    {
        func(str);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the List :");
        string str = Console.ReadLine();

        MyClass cls = new MyClass();
        Run run = new Run();

       
        run.runFunc(cls.Space, str);
        run.runFunc(cls.Reverse, str);
    }
}
