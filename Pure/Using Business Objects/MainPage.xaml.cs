using System;
using System.Windows;
using System.Windows.Controls;
using System.IO;

using Stimulsoft.Report;
using Stimulsoft.Report.SL.Helpers;
using Stimulsoft.Controls.SL.Helpers;

namespace UsingBusinessObjects
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            if (StiOptions.Silverlight.Themes.UseDefaultTheme && StiOptions.Silverlight.Themes.CurrentTheme == null)
                StiOptions.Silverlight.Themes.CurrentTheme = (StiSilverlightThemes)StiSettings.Get("StimulsoftApplication", "Theme", StiOptions.Silverlight.Themes.DefaultTheme);
            StiThemesHelper.LoadTheme();

            InitializeComponent();
        }

        private void btDesign_Click(object sender, RoutedEventArgs e)
        {
            var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("UsingBusinessObjects.SimpleList.mrt");

            StiReport report = new StiReport();
            report.Load(stream);

            stream.Close();
            stream.Dispose();
            stream = null;
            report.CalculationMode = StiCalculationMode.Interpretation;
            report.RegBusinessObject("Data", "Data", new Data());

            report.Design();
        }

        private void btPreview_Click(object sender, RoutedEventArgs e)
        {
            var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("UsingBusinessObjects.SimpleList.mrt");

            StiReport report = new StiReport();
            report.Load(stream);

            stream.Close();
            stream.Dispose();
            stream = null;

            report.CalculationMode = StiCalculationMode.Interpretation;
            report.RegBusinessObject("Data", "Data", new Data());
            report.Render();

            report.Show();
        }
    }
}