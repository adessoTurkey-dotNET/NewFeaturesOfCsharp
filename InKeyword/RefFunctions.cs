using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InKeyword
{
    public static class RefFunctions
    {
        public static void Test()
        {
            int[] arr = { 1, 2, 3 };
            ref int varr = ref arr[1];

            var list = new List<int> { 1, 2, 3 };
            //ref int varr2 = ref list[1]; Compile error!!

            int[] arr2 = { 10, 20, 30 };
            ref int refto20 = ref Findval(20, arr2);
            refto20 = 40;
            Findval(10, arr2) = 50;
            Console.WriteLine(string.Join(", ", arr2));

            int a=21; int b=22;
            var min = FindMin(ref a, ref b);//Byvalue
            ref var min2 =  ref FindMin(ref a, ref b);//Byreference

        }

        public static ref int Findval(int val, int[] arr)
        {

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] == val) return ref arr[i];
            }

            throw new Exception("value ccan't be find");
        }

        public static ref int FindMin(ref int val1, ref int val2)
        {

            //return val1 < val2 ? ref val1 : ref val2;
            //return ref (val1 < val2 ? val1 : val2);

            if (val1 < val2) return ref val1;
            return ref val2;
        }
    }
}
