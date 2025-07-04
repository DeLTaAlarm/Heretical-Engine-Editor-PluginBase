using System;
using System.Collections.Generic;

namespace PluginBase;

abstract public class PluginBaseClass
{

    public abstract void OnCompile(string path, object parameters);

    public abstract void OnCreate(string path, object parameters);

    public abstract void OnDelete(string path, object parameters);

    public abstract void OnOpen(string path, object parameters);

    public abstract void OnSave(string path, object parameters);

    public abstract void OnRename(string oldPath, string newPath, object parameters);

    public abstract void OnMove(string oldPath, string newPath, object parameters);
}
