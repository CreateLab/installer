using System;
using ReactiveUI;

namespace Installer.ViewModels
{
    public class LicenceViewModel:ViewModelBase, IRoutableViewModel
    {
        public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);
        public IScreen HostScreen { get; }
        public Action Next;
        public LicenceViewModel(IScreen screen, IButtonAction action)
        {
            Next = action.Next;
            HostScreen = screen;
        }
    }
}