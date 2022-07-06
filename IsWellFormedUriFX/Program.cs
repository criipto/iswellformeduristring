using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsWellFormedUriFX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FX 4.8");
            Console.WriteLine("Uri.IsWellFormedUriString(\"https://example.com?a=%3a&b=%c3%b8\", UriKind.Absolute) ? {0}", Uri.IsWellFormedUriString("https://example.com?a=%3a&b=%c3%b8", UriKind.Absolute));
            Console.WriteLine("Uri.IsWellFormedUriString(\"https://example.com?a=%3a\", UriKind.Absolute) ? {0}", Uri.IsWellFormedUriString("https://example.com?a=%3a", UriKind.Absolute));
            Console.WriteLine("Uri.IsWellFormedUriString(\"https://example.com?b=%c3%b8\", UriKind.Absolute) ? {0}", Uri.IsWellFormedUriString("https://example.com?b=%c3%b8", UriKind.Absolute));
        }
    }
}
