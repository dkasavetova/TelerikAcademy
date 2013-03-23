using System;

[AttributeUsage(
    AttributeTargets.Struct | 
    AttributeTargets.Class | 
    AttributeTargets.Interface | 
    AttributeTargets.Enum | 
    AttributeTargets.Method)]
public class VersionAttribute : Attribute
{
    //Fields
    private int majorVersion;
    private int minorVersion;

    //Properties
    public string Version
    {
        get
        {
            return string.Format("{0}.{1}", this.majorVersion, this.minorVersion);
        }
        private set { }
    }

    //Constructors
    public VersionAttribute(int major, int minor)
    {
        this.majorVersion = major;
        this.minorVersion = minor;
    }
}

