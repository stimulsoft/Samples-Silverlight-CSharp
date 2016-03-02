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
using System.IO;

namespace EditableReport
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();

            // Custom Color
            Stimulsoft.Report.StiOptions.Viewer.HighlightShowBorderColor = Colors.Orange;
            Stimulsoft.Report.StiOptions.Viewer.HighlightActiveBorderColor = Colors.Green;

            var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("EditableReport.EditableReport.mdc");
            if (stream != null)
            {
                Stimulsoft.Report.StiReport report = new Stimulsoft.Report.StiReport();
                report.LoadDocument(stream);

                stream.Close();
                stream.Dispose();
                stream = null;

                viewer.Report = report;
            }
        }

        #region Handlers
        private void btLoad_Click(object sender, RoutedEventArgs e)
        {
            if (viewer.Report != null)
            {
                OpenFileDialog fileDilalog = new OpenFileDialog();
                fileDilalog.Filter = "*.xml|*.xml";

                if (fileDilalog.ShowDialog() == true)
                {
                    Stimulsoft.Report.StiReport report = viewer.Report;
                    viewer.Report = null;

                    var stream = fileDilalog.File.OpenRead();
                    report.LoadEditableFields(stream);

                    stream.Close();
                    stream.Dispose();
                    stream = null;

                    viewer.Report = report;
                }
            }
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            if (viewer.Report != null)
            {
                SaveFileDialog fileDilalog = new SaveFileDialog();
                fileDilalog.Filter = "*.xml|*.xml";

                if (fileDilalog.ShowDialog() == true)
                {
                    var stream = fileDilalog.OpenFile();
                    viewer.Report.SaveEditableFields(stream);

                    stream.Flush();
                    stream.Close();
                    stream.Dispose();
                    stream = null;
                }
            }
        }
        #endregion
    }
}