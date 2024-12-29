public class ExampleClass{
    public int MyProperty { get; set; } = 0; // Explicit initialization

    public ExampleClass(int initialValue) // Constructor initialization
    {
        MyProperty = initialValue;
    }

    public void MyMethod() {
        Console.WriteLine(MyProperty); // Now guaranteed to have a value
    }
}