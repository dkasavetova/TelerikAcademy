using System;

class SplitURI
{
    static void Main()
    {
        string uri = "http://www.devbg.org/forum/index.php";

        int protocolStartIndex = 0;
        int protocolEndIndex = uri.IndexOf(':') + 2;
        int protocolLength = protocolEndIndex - protocolStartIndex + 1;
        string protocol = uri.Substring(protocolStartIndex, protocolLength);

        int serverStartIndex = protocolEndIndex + 1;
        int serverEndIndex = uri.IndexOf('/', serverStartIndex) - 1;
        int serverLength = serverEndIndex - serverStartIndex + 1;
        //expecting valid input - must have resource
        string server = uri.Substring(serverStartIndex, serverLength);

        int resourceStartIndex = serverEndIndex + 1;
        int resourceEndIndex = uri.Length - 1;
        int resourceLength = resourceEndIndex - resourceStartIndex + 1;
        string resource = uri.Substring(resourceStartIndex, resourceLength);

        Console.WriteLine("[protocol] = \"{0}\"", protocol);
        Console.WriteLine("[server] = \"{0}\"", server);
        Console.WriteLine("[resource] = \"{0}\"", resource);
    }
}

