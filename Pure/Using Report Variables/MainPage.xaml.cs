using System;
using System.Windows.Controls;
using Stimulsoft.Controls.SL.Helpers;
using Stimulsoft.Report;
using System.IO;
using Stimulsoft.Report.SL.Helpers;

namespace UsingReportVariables
{
    public partial class MainPage : UserControl
    {
        #region Fields
        private Stimulsoft.Report.StiReport stiReport1;
        #endregion

        #region Handlers
        private void btDesign_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("UsingReportVariables.Variables.mrt");
            stiReport1.Load(stream);
            stream.Close();
            stream.Dispose();
            stream = null;
            stiReport1.Design();
        }

        private void btPreview_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            viewer.Visibility = System.Windows.Visibility.Visible;
            viewer.Report = null;

            var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("UsingReportVariables.Variables.mrt");
            stiReport1.Load(stream);
            stream.Close();
            stream.Dispose();
            stream = null;

            //Set Variables
            stiReport1["Name"] = tbName.Text;
            stiReport1["Surname"] = tbSurname.Text;
            stiReport1["Email"] = tbEmail.Text;
            stiReport1["Address"] = tbAddress.Text;
            stiReport1["Sex"] = rbMale.IsChecked;
            stiReport1["BirthDay"] = dtBirthDay.DisplayDate;

            stiReport1.Render();
            viewer.Report = stiReport1;
        }
        #endregion

        public MainPage()
        {
            StiOptions.Viewer.Elements.ShowReportOpenButton = false;
            if (StiOptions.Silverlight.Themes.CurrentTheme == null)
                StiOptions.Silverlight.Themes.CurrentTheme = (StiSilverlightThemes)StiSettings.Get("StimulsoftApplication", "Theme", StiSilverlightThemes.Office2010Silver);
            StiThemesHelper.LoadTheme();

            InitializeComponent();

            stiReport1 = new StiReport();
        }
    }
}