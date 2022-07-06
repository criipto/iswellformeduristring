// See https://aka.ms/new-console-template for more information
Console.WriteLine("Core 6.0");
Console.WriteLine("Uri.IsWellFormedUriString(\"https://example.com?a=%3a&b=%c3%b8\", UriKind.Absolute) ? {0}", Uri.IsWellFormedUriString("https://example.com?a=%3a&b=%c3%b8", UriKind.Absolute));
Console.WriteLine("Uri.IsWellFormedUriString(\"https://example.com?a=%3a\", UriKind.Absolute) ? {0}", Uri.IsWellFormedUriString("https://example.com?a=%3a", UriKind.Absolute));
Console.WriteLine("Uri.IsWellFormedUriString(\"https://example.com?b=%c3%b8\", UriKind.Absolute) ? {0}", Uri.IsWellFormedUriString("https://example.com?b=%c3%b8", UriKind.Absolute));
