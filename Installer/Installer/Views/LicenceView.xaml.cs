using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Installer.ViewModels;
using ReactiveUI;

namespace Installer.Views
{
    public class LicenceView :  ReactiveUserControl<LicenceViewModel>
    {
        public LicenceView()
        {
            this.WhenActivated(disposables => { });
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}