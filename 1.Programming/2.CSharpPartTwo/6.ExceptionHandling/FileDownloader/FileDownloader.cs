using System;
using System.Net;

class FileDownloader
{
    static void Main()
    {
        string uri = Console.ReadLine();
        string fileNameAndExtention = uri.Substring(uri.LastIndexOf("/") + 1);
        using (WebClient client = new WebClient())
        {
            try
            {
                client.DownloadFile(uri, fileNameAndExtention);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Please provide url string");
            }
            catch (WebException ex)
            {
                Console.WriteLine("Can't downdload the file");
                //Console.WriteLine(ex.Message);
            }
        }
    }
}

