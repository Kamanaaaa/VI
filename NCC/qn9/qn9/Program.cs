using System;
using System.IO;
class Program
{
    static void Main()
    {
        string inputFile = "input,txt";
        string outputFile = "output.txt";
        try
        {
            using (StreamReader reader = new StreamReader(inputFile)) using (StreamWriter writer = new StreamWriter(outputFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string processedLine = line.ToUpper();
                    writer.WriteLine(processedLine);
                }
            }
            Console.WriteLine("File processed successfully.");

        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: Input File was not found");

        }
        catch (IOException ex)
        {
            Console.WriteLine("File I/O error:" + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error:" + ex.Message);
        }
        finally
        {
            Console.WriteLine("file operation completed.");
        }
    }
}