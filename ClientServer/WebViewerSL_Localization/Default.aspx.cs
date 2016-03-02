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
        //Add to your project Localization folder. 
        //In Localization folder place localization xml files.
        //After then set name of localization file in the Localization property of viewer. For example: de

        StiReport report = new StiReport();

        string applicationDirectory = HttpContext.Current.Server.MapPath(String.Empty);

        //Load already rendered report from file
        report.LoadDocument(applicationDirectory + "\\App_Data\\SimpleList.mdc");

        //Assign report to web viewer
        StiWebViewerSL1.Report = report;
    }
}
