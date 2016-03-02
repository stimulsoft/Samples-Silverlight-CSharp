using System;
using System.Windows;
using System.Windows.Controls;
using System.IO;

namespace CustomMessageBox
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            Stimulsoft.Report.StiOptions.Silverlight.MessageBoxType = typeof(StiMessageBox);
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Stimulsoft.Report.StiReport report = new Stimulsoft.Report.StiReport();
            var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("CustomMessageBox.Report.SimpleList.mdc");
            report.LoadDocument(stream);

            stream.Close();
            stream.Dispose();
            stream = null;

            viewer.Report = report;            
        }
    }
}