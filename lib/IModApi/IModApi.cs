using System;

[AttributeUsage(AttributeTargets.Assembly)]
public sealed class ModInfoAttribute : Attribute
{
    public ModInfoAttribute(string name, string author)
    {
        Name = name;
        Author = author;
        Version = "1.0.0.0";
    }

    public string Name { get; }
    public string Author { get; }
    public string Version { get; set; }
    public string Description { get; set; }
}

[AttributeUsage(AttributeTargets.Assembly)]
public sealed class ModPriorityAttribute : Attribute
{
    public ModPriorityAttribute(ModPriority priority)
    {
        Priority = priority;
    }

    public ModPriority Priority { get; }
}

public enum ModPriority
{
    Low,
    Medium,
    High
}
