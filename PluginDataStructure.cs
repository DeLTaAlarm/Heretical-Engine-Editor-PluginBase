using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginBase;

public struct PluginDataStructure
{
    public string displayName;
    public string description;
    public string iconPath;
    public string fileExtension;
    public string fileExtensionDisplayName;
    public string fileExtensionDescription;

    public PluginDataStructure(string _displayName, string _description, string _iconPath, string _fileExtension, string _fileExtensionDisplayName, string _fileExtensionDescription)
    {
        displayName = _displayName;
        description = _description;
        iconPath = _iconPath;
        fileExtension = _fileExtension;
        fileExtensionDisplayName = _fileExtensionDisplayName;
        fileExtensionDescription = _fileExtensionDescription;
    }
}
