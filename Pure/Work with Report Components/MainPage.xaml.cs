using System;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using Stimulsoft.Controls.SL.Helpers;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.SL.Helpers;
using Stimulsoft.Report;

namespace WorkWithReportComponents
{
    public partial class MainPage : UserControl
    {
        #region Fields
        private Stimulsoft.Report.StiReport stiReport1;
        #endregion

        #region Handlers
        private void btDesign_Click(object sender, RoutedEventArgs e)
        {
            var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("WorkWithReportComponents.Work_with_Components.mrt");
            stiReport1.Load(stream);
            stream.Close();
            stream.Dispose();
            stream = null;
            stiReport1.Design();
        }

        private void btPreview_Click(object sender, RoutedEventArgs e)
        {
            viewer.Report = null;

            var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("WorkWithReportComponents.Work_with_Components.mrt");
            stiReport1.Load(stream);
            stream.Close();
            stream.Dispose();
            stream = null;

            ((StiText)stiReport1.Pages["Page1"].Components["Text1"]).Text.Value = textBox1.Text;

            viewer.Visibility = System.Windows.Visibility.Visible;
            stiReport1.Render();
            viewer.Report = stiReport1;
        }
        #endregion

        public MainPage()
        {
            if (StiOptions.Silverlight.Themes.CurrentTheme == null)
                StiOptions.Silverlight.Themes.CurrentTheme = (StiSilverlightThemes)StiSettings.Get("StimulsoftApplication", "Theme", StiSilverlightThemes.Office2010Silver);
            StiThemesHelper.LoadTheme();

            InitializeComponent();
            stiReport1 = new Stimulsoft.Report.StiReport();
        }
    }
}