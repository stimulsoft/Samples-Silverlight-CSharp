using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Stimulsoft.Report;

public partial class Designer : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        StiWebDesignerSL1.DesignerSource = "Source/DesignerSL.xap";
        StiWebDesignerSL1.DesignerSplashScreenSource = "Source/SilverlightLogo.xaml";
        StiWebDesignerSL1.DesignerSplashScreenProgressChangedMethodName = "onSourceDownloadProgressChanged";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        string keyValue = Page.Request.QueryString.Get("reportname");
        StiReport report = new StiReport();
        
        string appDirectory = HttpContext.Current.Server.MapPath(string.Empty);
        if (keyValue != null) report.Load(string.Format("{0}\\Reports\\{1}.mrt", appDirectory, keyValue));

        StiWebDesignerSL1.Report = report;
    }

    protected void StiWebDesignerSL1_GetPreviewDataSet(object sender, Stimulsoft.Report.WebDesignSL.StiWebDesignerSL.StiPreviewDataSetEventArgs e)
    {
        string appDirectory = HttpContext.Current.Server.MapPath(string.Empty);

        DataSet data = new DataSet();
        data.ReadXmlSchema(appDirectory + "\\Data\\Demo.xsd");
        data.ReadXml(appDirectory + "\\Data\\Demo.xml");

        e.PreviewDataSet = data;
    }
}
