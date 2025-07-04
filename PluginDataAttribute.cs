using Avalonia;

namespace PluginBase;

[AttributeUsage(AttributeTargets.Class)]
public class PluginDataAttribute : Attribute
{
    public PluginDataStructure data;

    public PluginDataAttribute(string displayName, string description, string iconPath, string fileExtension, string fileExtensionDisplayName, string fileExtensionDescription)
    {
        data = new PluginDataStructure
        {
            displayName = displayName,
            description = description,
            iconPath = iconPath,
            fileExtension = fileExtension,
            fileExtensionDisplayName = fileExtensionDisplayName,
            fileExtensionDescription = fileExtensionDescription
        };
    }
}