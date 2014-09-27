using System;

class URL
{
    static string GetProtocol(string url)
    {
        string protocol = url.Substring(0, url.IndexOf(':'));
        return protocol;
    }

    static string GetServer(string url)
    {
        int startIndex = url.IndexOf("//") + 2;
        string server =  url.Substring(startIndex, url.IndexOf('/', startIndex) - startIndex);
        return server;
    }

    static string GetResources(string url)
    {
        int startIndex = url.IndexOf('/', url.IndexOf("//") + 2);
        return url.Substring(startIndex);
    }

    static void Main()
    {
        Console.WriteLine("Input the URL");
        string url = Console.ReadLine();
        string protocol = GetProtocol(url);
        string server = GetServer(url);
        string resources = GetResources(url);

        Console.WriteLine("Protocol: {0}", protocol);
        Console.WriteLine("Server: {0}", server);
        Console.WriteLine("Resources: {0}", resources);
    }
}

