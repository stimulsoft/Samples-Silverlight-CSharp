using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SaveSettingsByUser
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            Stimulsoft.Report.StiOptions.ApplicationSettings.SaveSettingsByUser = true;
            Stimulsoft.Report.StiOptions.Designer.DontSaveFormsSettings = true;
            Stimulsoft.Report.StiOptions.ApplicationSettings.LoadingApplicationSettings += new Stimulsoft.Report.Events.StiApplicationSettingsEventHandler(ApplicationSettings_LoadingApplicationSettings);
            Stimulsoft.Report.StiOptions.ApplicationSettings.SavingApplicationSettings += new Stimulsoft.Report.Events.StiApplicationSettingsEventHandler(ApplicationSettings_SavingApplicationSettings);

            InitializeComponent();
        }

        #region Handlers
        private void ApplicationSettings_SavingApplicationSettings(object sender, Stimulsoft.Report.Events.StiApplicationSettingsEventArgs e)
        {
            Dictionary<string, object> settings = e.Settings;
            if (settings != null)
            {
                //Process Settings and Save Them Wherever You Want
            }
        }

        private void ApplicationSettings_LoadingApplicationSettings(object sender, Stimulsoft.Report.Events.StiApplicationSettingsEventArgs e)
        {
            Dictionary<string, object> settings = new Dictionary<string, object>();
            settings.Add("test1", "value1");
            settings.Add("test2", true);
            settings.Add("test3", 1.0f);

            e.Settings = settings;
        }
        #endregion
    }
}