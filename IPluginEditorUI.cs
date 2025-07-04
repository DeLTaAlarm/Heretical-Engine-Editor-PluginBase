using Avalonia.Controls;

namespace PluginBase;

public interface IPluginEditorUI
{
    public Control GetEditorUI(string path, Action<object> onSave);
    public Task ShowCreationDialogAsync(Window parentWindow, string path, Action<object> onCreated);
}
