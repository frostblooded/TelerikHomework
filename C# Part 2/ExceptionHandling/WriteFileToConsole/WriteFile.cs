﻿using System;
using System.IO;
using System.Security;

class WriteFile
{
    static void Main()
    {
        Console.WriteLine("What is the full path of the file?");
        string filePath = Console.ReadLine();

        try
        {
            string contents = File.ReadAllText(filePath);
            Console.WriteLine(contents);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The specified path is invalid.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path was too long.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified directory was not found.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("The file couldn't be accessed.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The specified file could not be found.");
        }
        catch (SecurityException)
        {
            Console.WriteLine("The program doesn't have the required permitions to access the file.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The specified path is in an invalid format.");
        }
    }
}