using System;

public class MyClass : ICloneable
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public object Clone()
    {
        return this.MemberwiseClone();
    }

    public static void Main(string[] args)
    {
        MyClass obj1 = new MyClass(10);
        MyClass obj2 = (MyClass)obj1.Clone(); // Create a copy using MemberwiseClone

        obj2.MyProperty = 20; // Modify obj2

        Console.WriteLine(obj1.MyProperty); // Output: 10
        Console.WriteLine(obj2.MyProperty); // Output: 20
    }
}