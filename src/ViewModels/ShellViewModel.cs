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
}
