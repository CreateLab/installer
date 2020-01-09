using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;
using ReactiveUI;

namespace Installer.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, IButtonAction, IScreen
    {
        private int _status = 0;
        public RoutingState Router => new RoutingState();
        public string Header => AppSetting.Instance.Name;
        public string Description => AppSetting.Instance.Description;

        public ReactiveCommand<Unit, IRoutableViewModel> GoNext { get; }
        public MainWindowViewModel()
        {
            GoNext = ReactiveCommand.CreateFromObservable(
                () => Router.Navigate.Execute(new LicenceViewModel(this, this))
            );
        }
        public void Next()
        {
            Router.Navigate.Execute(new LicenceViewModel(this, this)).Subscribe();
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void Finish()
        {
            throw new NotImplementedException();
        }
        
    }


}