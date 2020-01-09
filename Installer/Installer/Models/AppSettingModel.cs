namespace Installer.Models
{
    public class AppSettingModel
    {
        public string Name { get; set; }
        public string Description{ get; set; }
        public bool LicenceStatus { get; set; }
        public string LicenceText { get; set; }
        public string OS { get; set; } 
    }
}