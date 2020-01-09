namespace Installer.ViewModels
{
    public interface IButtonAction
    {
        void Next();
        void Cancel();
        void Finish();
    }
}