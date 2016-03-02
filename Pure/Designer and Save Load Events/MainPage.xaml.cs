using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Stimulsoft.Report;
using Stimulsoft.Report.SLDesign;
using Stimulsoft.Report.SaveLoad;

namespace DesignerSaveLoad
{
    public partial class MainPage : UserControl
    {
        #region Fields
        private MessageBoxWindow messageBox;
        #endregion

        #region Handlers
        private void GlobalEvents_SavingReportInDesigner(object sender, Stimulsoft.Report.Design.StiSavingObjectEventArgs e)
        {
            if (designer.Report == null) return;
            e.Processed = true;
            messageBox = new MessageBoxWindow();
            messageBox.Closed += delegate
            {
                if (messageBox.Result == MessageBoxResult.Yes)
                {
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Report Files (*.mrt) | *.mrt";
                    if (saveDialog.ShowDialog() == true)
                    {
                        var stream = saveDialog.OpenFile();
                        StiXmlReportSLService saveService = new StiXmlReportSLService();
                        saveService.Save(designer.Report, stream);

                        stream.Flush();
                        stream.Close();
                        stream.Dispose();
                        stream = null;
                    }
                }

                messageBox = null;
            };

            messageBox.Show();
        }

        private void btLoadReport_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (cbReports.SelectedItem != null)
            {
                System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
                var stream = a.GetManifestResourceStream(string.Format("DesignerSaveLoad.ReportFiles.{0}.mrt", ((ComboBoxItem)cbReports.SelectedItem).Content.ToString()));

                StiReport report = new StiReport();
                report.Load(stream);
                stream.Close();
                stream.Dispose();
                stream = null;

                report.CalculationMode = StiCalculationMode.Interpretation;
                report.RegBusinessObject("Data", "Data", new Data());

                designer.Report = report;
            }
        }
        #endregion

        public MainPage()
        {
            Stimulsoft.Report.StiOptions.Silverlight.Themes.CurrentTheme = Stimulsoft.Report.StiSilverlightThemes.Office2007Blue;
            Stimulsoft.Report.StiOptions.Silverlight.Themes.UseDefaultTheme = false;

            StiDesignerSLOptions.MainMenu.NewEnabled = false;
            StiDesignerSLOptions.MainMenu.DeletePageEnabled = false;
            StiDesignerSLOptions.MainMenu.DesignerEnabled = false;
            StiDesignerSLOptions.MainMenu.OpenPageEnabled = false;
            StiDesignerSLOptions.MainMenu.OpenReportEnabled = false;
            StiDesignerSLOptions.MainMenu.OptionsEnabled = false;
            StiDesignerSLOptions.MainMenu.PageEnabled = false;
            StiDesignerSLOptions.MainMenu.ReportEnabled = false;
            StiDesignerSLOptions.MainMenu.SavePageAsEnabled = false;
            StiDesignerSLOptions.MainMenu.ReportSetup = false;
            StiOptions.Designer.AllowUseDragDrop = false;

            InitializeComponent();
            StiOptions.Engine.GlobalEvents.SavingReportInDesigner += new Stimulsoft.Report.Design.StiSavingObjectEventHandler(GlobalEvents_SavingReportInDesigner);
        }
    }
}