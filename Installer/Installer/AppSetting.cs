using System.IO;
using System.Reflection;
using System.Text.Json;
using Installer.Models;

namespace Installer
{
    public class AppSetting
    {
        private static AppSetting _appSetting;
        public static AppSetting Instance => _appSetting ??= new AppSetting();

        private AppSetting()
        {
            var executingAssembly = Assembly.GetExecutingAssembly();
            var manifestResourceNames = executingAssembly.GetManifestResourceNames();
            using (Stream stream = executingAssembly.GetManifestResourceStream("Installer.appSetting.json"))
            using (StreamReader reader = new StreamReader(stream))
            {
                
                var appSettingModel = JsonSerializer.Deserialize<AppSettingModel>(reader.ReadToEnd());
                IsLicence = appSettingModel.LicenceStatus;
                LicenceText = appSettingModel.LicenceText;
                Os = appSettingModel.OS;
                Description = appSettingModel.Description;
                Name = appSettingModel.Name;
            }
        }

        public bool IsLicence { get; }

        public string LicenceText { get; }

        public string Os { get; }

        public string Name { get; }

        public string Description { get; }
    }
}