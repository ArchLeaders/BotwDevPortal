using Avalonia.Generics.Dialogs;

namespace BotwDevPortal.ViewModels;

public class ShellViewModel : ReactiveObject
{

    private string _status = "Ready";
    public string Status {
        get => _status;
        set => this.RaiseAndSetIfChanged(ref _status, value);
    }


    private string _mod = string.Empty;
    public string Mod {
        get => _mod;
        set => this.RaiseAndSetIfChanged(ref _mod, value);
    }

    public async Task CreateMod()
    {
        var result = await InputDialog.ShowDialog(new() {
            { "Name", string.Empty }
        }, "Create New Mod");

        if (result != null) {
            // Create Mod
        }
    }
}
