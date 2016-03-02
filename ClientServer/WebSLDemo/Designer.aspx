<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Designer.aspx.cs" Inherits="Designer" %>
<%@ Register Assembly="Stimulsoft.Report.WebDesignSL" Namespace="Stimulsoft.Report.WebDesignSL" TagPrefix="cc2" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Stimulsoft Reports.Silverlight Demo</title>
    <link rel="stylesheet" type="text/css" href="Styles/webviewersl.css" />
    <script type="text/javascript" src="Scripts/SplashScreen.js"></script>
    <LINK href="logo.ico" rel="SHORTCUT ICON">
</head>
<body>
    <cc2:StiWebDesignerSL ExitUrl="http:\\websl.stimulsoft.com" AutoMaximize="true" 
        ID="StiWebDesignerSL1" runat="server"
        OnGetPreviewDataSet="StiWebDesignerSL1_GetPreviewDataSet" />
</body>
</html>
