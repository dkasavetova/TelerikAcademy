using System;

[Version(0, 2)]
class TestApp
{
    [Version(0, 1)]
    public static void Main()
    {
        Type type = typeof(TestApp);

        object[] attributes = type.GetCustomAttributes(false);
        Console.WriteLine("Class Version: " + ((VersionAttribute)attributes[0]).Version);
    }
}
