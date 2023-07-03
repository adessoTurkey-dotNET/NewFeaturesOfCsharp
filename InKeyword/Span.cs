using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InKeyword
{
    

    static public class SpanFunc
    {
        
        static public void Test()
        {
            unsafe
            {
                byte* ptr = stackalloc byte[100];
                Span<byte> memory = new(ptr, 100); 

                IntPtr unmanagedPtr = Marshal.AllocHGlobal(123);
                Span<byte> unmanagedMemory = new(unmanagedPtr.ToPointer(), 123);
                Marshal.FreeHGlobal(unmanagedPtr);
            }

            char[] stuff = "Hello".ToCharArray();
            Span<char> chars = new Span<char>(stuff);
            Console.WriteLine(stuff);
            chars.Fill('x');
            Console.WriteLine(stuff);
            chars.Clear();
            Console.WriteLine(stuff);

            ReadOnlySpan<char> chars1 = chars;
            //chars1.Clear(); CTE!!
            Console.WriteLine(chars1.Length);
        }
    }

}
