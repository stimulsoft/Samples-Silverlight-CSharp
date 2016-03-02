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
        //Open web designer without report
    }

    /// <summary>
    /// This event occurs when user click on OpenReport menu item in web designer.
    /// </summary>
    protected void StiWebDesignerSL1_OpenReport(object sender, Stimulsoft.Report.WebDesignSL.StiWebDesignerSL.StiOpenReportEventArgs e)
    {
        StiReport report = new StiReport();

        string applicationDirectory = HttpContext.Current.Server.MapPath(String.Empty);

        //Load report from file
        report.Load(applicationDirectory + "\\App_Data\\SimpleList.mrt");

        //Assign report to web designer. This report will be opened in web designer.
        e.Report = report;
    }

    /// <summary>
    /// This event occurs when user click on SaveReport menu item in web designer.
    /// </summary>
    protected void StiWebDesignerSL1_SaveReport(object sender, Stimulsoft.Report.WebDesignSL.StiWebDesignerSL.StiSaveReportEventArgs e)
    {        
        //Save report to string. reportStr variable can be stored in database
        string reportStr = e.Report.SaveToString();
    }

    /// <summary>
    /// This event occurs when user click on SaveReportAs menu item in web designer.
    /// </summary>
    protected void StiWebDesignerSL1_SaveReportAs(object sender, Stimulsoft.Report.WebDesignSL.StiWebDesignerSL.StiSaveReportEventArgs e)
    {
        //Save report to string. reportStr variable can be stored in database.
        string reportStr = e.Report.SaveToString();
    }
}
