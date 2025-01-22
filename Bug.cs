public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static void Main(string[] args)
    {
        MyClass obj1 = new MyClass(10);
        MyClass obj2 = obj1;

        obj2.MyProperty = 20; // Modify obj2

        Console.WriteLine(obj1.MyProperty); // Output: 20
    }
}