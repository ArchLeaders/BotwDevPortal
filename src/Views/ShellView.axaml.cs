using Avalonia.Controls;
using BotwDevPortal.ViewModels;

namespace BotwDevPortal.Views
{
    public partial class ShellView : Window
    {
        public ShellViewModel ViewModel => DataContext as ShellViewModel ?? throw new Exception("Shell view data context was NULL");

        public ShellView()
        {
            InitializeComponent();
            DataContext = new ShellViewModel();
        }
    }
}
