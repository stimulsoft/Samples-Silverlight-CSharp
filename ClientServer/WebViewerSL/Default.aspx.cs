using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Stimulsoft.Report;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        StiReport report = new StiReport();

        string applicationDirectory = HttpContext.Current.Server.MapPath(String.Empty);

        DataSet data = new DataSet();
        data.ReadXmlSchema(applicationDirectory + "\\App_Data\\Demo.xsd");
        data.ReadXml(applicationDirectory + "\\App_Data\\Demo.xml");

        //Register dataset in report
        report.RegData("Demo", data);

        //Load report from file
        report.Load(applicationDirectory + "\\App_Data\\SimpleList.mrt");

        //Assign report to web viewer
        StiWebViewerSL1.Report = report;
    }
}
