using System;
public   class PointerDemo
{
    public static unsafe void Run()
    {
        
        int number=10;

        Console.WriteLine(number);

        int* ptr =&number;

        Console.WriteLine("address:" +(IntPtr)ptr);

        *ptr=50;

        Console.WriteLine("after value:"+ number);
        Console.WriteLine("pointer value"+ *ptr);

    }
}