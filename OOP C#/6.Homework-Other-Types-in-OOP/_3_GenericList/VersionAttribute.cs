using System;

[AttributeUsage(AttributeTargets.Struct | 
    AttributeTargets.Class | 
    AttributeTargets.Interface |
    AttributeTargets.Enum |
    AttributeTargets.Method)]

class VersionAttribute : Attribute
{
    public int Minor { get; set; }

    public int Major { get; set; }

    public VersionAttribute(int major, int minor)
    {
        this.Major = major;
        this.Minor = minor;
    }
}

