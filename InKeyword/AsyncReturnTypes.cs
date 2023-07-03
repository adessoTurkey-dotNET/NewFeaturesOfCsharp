using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InKeyword
{
    public static class AsyncReturnTypes
    {
        public static async Task<long> GetDirSize(string dir)
        {
            if (!Directory.EnumerateFileSystemEntries(dir).Any()) return 0;//Creates Task unnecessary
            return await Task.Run(() => Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories).Sum(f=> new FileInfo(f).Length));
        }

        public static async ValueTask<long> GetDirSize2(string dir)
        {
            if (!Directory.EnumerateFileSystemEntries(dir).Any()) return 0;//Creates Task unnecessary
            return await Task.Run(() => Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories).Sum(f => new FileInfo(f).Length));
        }
        public static void Test()
        {
            Console.WriteLine(GetDirSize2(@"c:\temp").Result);
        }
    }
}
