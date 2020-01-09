using System;
using System.Reactive;
using ReactiveUI;

namespace Installer.ViewModels
{
    public class LicenceViewModel:ViewModelBase, IRoutableViewModel
    {
        public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);
        public string Licence => AppSetting.Instance.LicenceText;
        public IScreen HostScreen { get; }
        public void Lol(){}
        
        public ReactiveCommand<Unit, Unit> GoNext { get; }
        public LicenceViewModel(IScreen screen, IButtonAction action)
        {
            GoNext = ReactiveCommand.Create(action.Next);
            HostScreen = screen;
        }
    }
}