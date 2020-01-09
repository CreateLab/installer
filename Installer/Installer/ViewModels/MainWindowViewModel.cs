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
        public RoutingState Router { get; } = new RoutingState();
        public string Header => AppSetting.Instance.Name;
        public string Description => AppSetting.Instance.Description;
        
        public MainWindowViewModel()
        {
           
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