<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register Assembly="Stimulsoft.Report.WebSL" Namespace="Stimulsoft.Report.WebSL" TagPrefix="cc1" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Stimulsoft Reports.Silverlight Demo</title>
    <link rel="stylesheet" type="text/css" href="Styles/webviewersl.css" />
    <link rel="stylesheet" type="text/css" href="Styles/dtree.css" />
    <script type="text/javascript" src="Scripts/dtree.js"></script>
    <script type="text/javascript" src="Scripts/webviewersl_reports.js"></script>
    <script type="text/javascript" src="Scripts/SplashScreen.js"></script>
    <LINK href="logo.ico" rel="SHORTCUT ICON">
</head>
<body style="background-color: #e8e8e8">
    <form id="form1" runat="server">
        <table style="height: 100%; width: 100%;">
            <tr>            
                <td style="height: 100%;">
                    <div style="width: 270px; height: 100%;">
                        <table cellpadding="0" cellspacing="0" style="font-size: 1px; height: 100%;">
                            <tr>
                                <td style="background-image: url(Images/WebViewerSL/line-left-top.png)"><div class="table-side" /></td>
                                <td style="background-image: url(Images/WebViewerSL/line-top.png)"><div class="table-side" /></td>
                                <td style="background-image: url(Images/WebViewerSL/line-right-top.png)"><div class="table-side" /></td>
                            </tr>
                            <tr>
                            
                                <td style="background-image: url(Images/WebViewerSL/line-left.png)"><div class="table-side" /></td>
                                <td style="width: 100%; height: 100%; padding: 2px; background-color: White; vertical-align: top;">
                                    <table cellpadding="1" cellspacing="1" style="width: 100%;">
                                        <tr><td style="font-family: Arial; font-weight: bold; font-size: 16px; color: #406090; text-align: center;">Stimulsoft Reports.Silverlight</td></tr>
                                        <tr><td style="font-size: 1px; height: 2px;"><div style="height: 2px; border-top: Solid 1px #b0c0e0;" /></td></tr>
                                        <tr>
                                            <td style="height: 100%; vertical-align: top;">
                                                <div style="width: 230px; max-width: 230px; overflow: hidden;">
                                                    <script type="text/javascript">buildReportTree();</script><br />
                                                </div>
                                            </td>
                                        </tr>
                                        <tr><td style="font-size: 10px;">&nbsp</td></tr>
                                    </table>
                                </td>
                                <td style="background-image: url(Images/WebViewerSL/line-right.png)"><div class="table-side" /></td>
                            </tr>
                            <tr>
                                <td style="background-image: url(Images/WebViewerSL/line-left.png)"><div class="table-side" /></td>
                                <td style="text-align: center; background-color: White; padding: 0px 0px 5px 0px;"><a class="link" href="http://www.stimulsoft.com" target="_blank">http://www.stimulsoft.com</a></td>
                                <td style="background-image: url(Images/WebViewerSL/line-right.png)"><div class="table-side" /></td>
                            </tr>
                            <tr>
                                <td style="background-image: url(Images/WebViewerSL/line-left-bottom.png)"><div class="table-side" /></td>
                                <td style="background-image: url(Images/WebViewerSL/line-bottom.png)"></td>
                                <td style="background-image: url(Images/WebViewerSL/line-right-bottom.png)"><div class="table-side" /></td>
                            </tr>
                        </table>
                    </div>
                </td>
                <td style="width: 100%; height: 100%;">
                    <table cellpadding="0" cellspacing="0" style="font-family: Arial; font-size: 12px; width: 100%; height: 100%;">
                        <tr>
                            <td style="height: 50px;">
                                <table cellpadding="0" cellspacing="0" style="font-size: 1px; width: 100%; height: 100%;">
                                    <tr>
                                        <td style="background-image: url(Images/WebViewerSL/line-left-top.png)"><div class="table-side" /></td>
                                        <td style="background-image: url(Images/WebViewerSL/line-top.png)"><div class="table-side" /></td>
                                        <td style="background-image: url(Images/WebViewerSL/line-right-top.png)"><div class="table-side" /></td>
                                    </tr>
                                    <tr>
                                        <td style="background-image: url(Images/WebViewerSL/line-left.png)"><div class="table-side" /></td>
                                        <td style="width: 100%; height: 100%; padding: 2px; background-color: White;">
                                            <table cellpadding="0" cellspacing="0" style="width: 100%;">
                                                <tr>
                                                    <td style="width: 100%; padding-left: 5px;"><asp:Label ID="LabelText" runat="server" ForeColor="#406090" Font-Size="12px" /></td>
                                                    <td style="padding-right: 5px;"><asp:Button ID="ButtonDesign" runat="server" Text="Design Report" OnClick="ButtonDesign_Click" /></td>
                                                </tr>
                                            </table>
                                        </td>
                                        <td style="background-image: url(Images/WebViewerSL/line-right.png)"><div class="table-side" /></td>
                                    </tr>
                                    <tr>
                                        <td style="background-image: url(Images/WebViewerSL/line-left-bottom.png)"><div class="table-side" /></td>
                                        <td style="background-image: url(Images/WebViewerSL/line-bottom.png)"></td>
                                        <td style="background-image: url(Images/WebViewerSL/line-right-bottom.png)"><div class="table-side" /></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 100%; padding: 4px 3px 3px 2px;">
                                <cc1:StiWebViewerSL Width="100%" Height="100%" ID="StiWebViewerSL1" OnGetPreviewDataSet="StiWebViewerSL_GetPreviewDataSet" runat="server"/>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
