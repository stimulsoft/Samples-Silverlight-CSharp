using System;
using System.Windows.Controls;
using Stimulsoft.Report;
using System.Reflection;
using System.Data;

namespace UsingDataSetAsBusinessObject
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();

            StiReport report = new StiReport();
            var asm = Assembly.GetExecutingAssembly();
            using (var stream = asm.GetManifestResourceStream("UsingDataSetAsBusinessObject.MasterDetail.mrt"))
            {
                report.Load(stream);
            }

            DataSet dataSet = new DataSet();
            using (var stream = asm.GetManifestResourceStream("UsingDataSetAsBusinessObject.DemoNet.data"))
            {
                dataSet.Load(stream);
            }

            report.RegBusinessObject("Demo", dataSet);
            report.Dictionary.SynchronizeBusinessObjects(3);
            report.Render();

            viewerControl.Report = report;
        }
    }
}