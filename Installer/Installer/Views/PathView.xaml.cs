using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Installer.Views
{
    public class PathView : UserControl
    {
        public PathView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}