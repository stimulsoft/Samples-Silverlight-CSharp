<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="Stimulsoft.Report.WebDesignSL" Namespace="Stimulsoft.Report.WebDesignSL" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>WebDesignerSL Demo</title>
    <link rel="stylesheet" type="text/css" href="styles.css" />
    <link href="logo.ico" rel="SHORTCUT ICON" />
</head>
<body>
    <cc1:StiWebDesignerSL id="StiWebDesignerSL1" runat="server" OnGetPreviewDataSet="StiWebDesignerSL1_GetPreviewDataSet"></cc1:StiWebDesignerSL>
</body>
</html>
