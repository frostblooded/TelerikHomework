using System;
using System.Net;

class Program
{
    static void Main()
    {
        try
        {
            WebClient client = new WebClient();
            client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "file.jpg");
            client.Dispose();
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Error: The specified adress is invalid.");
        }
        catch (WebException)
        {
            Console.WriteLine("Error: An error occured while getting the file downloaded. Check if the provided address is corect.");
        }
    }
}
