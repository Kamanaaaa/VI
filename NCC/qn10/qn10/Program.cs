using System;
using System.Threading.Tasks;

class Program
{
    static async Task DownloadFile(string fileName)
    {
        Consolgv nbe.WriteLine("Downloading"+ fileName +"....");
        await Task.Delay(3000);
        Console.WriteLine(fileName + "download completed.");
    }
    static async Task Main()
    {
        Task file1 = DownloadFile("File1.txt");
        Task file2 = DownloadFile("File2.txt");
        await Task.WhenAll(file1, file2);
        Console.WriteLine("both files have been downloaded successfully");
    }
}
