#region Copyright (C) 2003-2011 Stimulsoft
/*
{*******************************************************************}
{																	}
{	Stimulsoft Reports.SL											}
{	                         										}
{																	}
{	Copyright (C) 2003-2011 Stimulsoft     							}
{	ALL RIGHTS RESERVED												}
{																	}
{	The entire contents of this file is protected by U.S. and		}
{	International Copyright Laws. Unauthorized reproduction,		}
{	reverse-engineering, and distribution of all or any portion of	}
{	the code contained in this file is strictly prohibited and may	}
{	result in severe civil and criminal penalties and will be		}
{	prosecuted to the maximum extent possible under the law.		}
{																	}
{	RESTRICTIONS													}
{																	}
{	THIS SOURCE CODE AND ALL RESULTING INTERMEDIATE FILES			}
{	ARE CONFIDENTIAL AND PROPRIETARY								}
{	TRADE SECRETS OF Stimulsoft										}
{																	}
{	CONSULT THE END USER LICENSE AGREEMENT FOR INFORMATION ON		}
{	ADDITIONAL RESTRICTIONS.										}
{																	}
{*******************************************************************}
*/
#endregion Copyright (C) 2003-2011 Stimulsoft

using System;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Stimulsoft.Controls.SL;
using Stimulsoft.Report;
using Stimulsoft.Report.SLDesign;

namespace System.Data
{
    
}

namespace Demo
{
    public partial class MainPage : UserControl
    {
        #region Fields
        private System.Collections.StiHashtable reportsDescription = new System.Collections.StiHashtable();
        #endregion

        #region Methods
        private void ReadReportsInfo()
        {
            var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Demo.Reports.xml");

            System.Xml.XmlReader tr = System.Xml.XmlReader.Create(stream);

            StiTreeViewItem categoryNode = null;
            BitmapImage browserCategory = new BitmapImage(new Uri("/Demo;component/Images/browserCategory.png", UriKind.RelativeOrAbsolute));
            BitmapImage browserReport = new BitmapImage(new Uri("/Demo;component/Images/browserReport.png", UriKind.RelativeOrAbsolute));

            tr.Read();
            while (!tr.EOF)
            {
                if (tr.IsStartElement())
                {
                    if (tr.Name == "Category")
                    {
                        categoryNode = new StiTreeViewItem();
                        Image img = new Image();
                        img.Width = 16;
                        img.Height = 16;
                        img.Source = browserCategory;
                        categoryNode.Header = GetTreeViewContent(tr.GetAttribute("name"), img);
                        categoryNode.Tag = tr.GetAttribute("name");
                        reportsDescription[categoryNode.Tag] = tr.GetAttribute("description");
                        treeViewReports.Items.Add(categoryNode);
                    }
                    else if (tr.Name == "Report")
                    {
                        StiTreeViewItem reportNode = new StiTreeViewItem();
                        Image img = new Image();
                        img.Width = 16;
                        img.Height = 16;
                        img.Source = browserReport;
                        reportNode.Header = GetTreeViewContent(tr.GetAttribute("name"), img);
                        reportNode.Tag = tr.GetAttribute("file");
                        reportNode.Cursor = Cursors.Hand;
                        tr.Read();
                        reportsDescription[reportNode.Tag] = tr.Value;
                        categoryNode.Items.Add(reportNode);
                    }
                }
                tr.Read();
            }

            tr.Close();
            stream.Close();
            stream.Dispose();
            tr = null;
            stream = null;

            ((StiTreeViewItem)treeViewReports.Items[0]).IsExpanded = true;
        }

        private StackPanel GetTreeViewContent(string text, Image image)
        {
            TextBlock block = new TextBlock();
            block.VerticalAlignment = VerticalAlignment.Center;
            block.Margin = new Thickness(4, 0, 4, 0);
            block.Text = text;

            StackPanel panel = new StackPanel();
            panel.Orientation = Orientation.Horizontal;
            panel.Children.Add(image);
            panel.Children.Add(block);

            return panel;
        }

        private void RenderReport()
        {
            #region Show Description
            if (((StiTreeViewItem)treeViewReports.SelectedItem).Tag != null && reportsDescription[((StiTreeViewItem)treeViewReports.SelectedItem).Tag] != null)
            {
                labelInformation.Content = reportsDescription[((StiTreeViewItem)treeViewReports.SelectedItem).Tag] as string;
            }
            else
            {
                labelInformation.Content = "";
            }
            #endregion

            if (treeViewReports.SelectedItem != null && ((StiTreeViewItem)treeViewReports.SelectedItem).Parent != null)
            {
                if (((StiTreeViewItem)treeViewReports.SelectedItem).Parent is StiTreeView) return;
                string reportName = ((StiTreeViewItem)treeViewReports.SelectedItem).Tag as string;

                StiReport report = GetReport(reportName);

                if (report != null)
                {
                    RegData(report);
                    report.Render();
                    viewerControl.Report = report;
                }
            }
        }

        private StiReport GetMrtFile(string reportName)
        {
            var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Demo.Reports." + reportName + ".mrt");

            StiReport report = null;
            if (stream != null)
            {
                report = new StiReport();
                report.Load(stream);
                stream.Close();
                stream.Dispose();
                stream = null;
            }

            return report;
        }

        private StiReport GetReport(string reportName)
        {
            switch (reportName)
            {
                case "BarCodes":
                    return new Reports.BarCodes();
                case "Invoice":
                    return new Reports.Invoice();
                case "Labels":
                    return new Reports.Labels();
                case "MultiColumnList":
                    return new Reports.MultiColumnList();
                case "Shapes":
                    return new Reports.Shapes();
                case "SimpleGroup":
                    return new Reports.SimpleGroup();
                case "SimpleList":
                    return new Reports.SimpleList();
                case "TwoSimpleLists":
                    return new Reports.TwoSimpleLists();
                case "ChartAreas":
                    return new Reports.ChartAreas();
                case "ChartColumnsAndBars":
                    return new Reports.ChartColumnsAndBars();
                case "ChartLinesAndSplines":
                    return new Reports.ChartLinesAndSplines();
                case "ChartPieAndDoughnut":
                    return new Reports.ChartPieAndDoughnut();
                case "ChartStyles":
                    return new Reports.ChartStyles();
                case "DrillDownListOfProducts":
                    return new Reports.DrillDownListOfProducts();
                case "MultiColumnBandsAcrossThenDown":
                    return new Reports.MultiColumnBandsAcrossThenDown();
                case "MultiColumnBandsDownThenAcross":
                    return new Reports.MultiColumnBandsDownThenAcross();
                case "MultiColumnGroup":
                    return new Reports.MultiColumnGroup();
                case "GroupsWithRanges":
                    return new Reports.GroupsWithRanges();
                case "SimpleGroupWithColumns":
                    return new Reports.SimpleGroupWithColumns();
                case "SimpleListWithEmptyLines":
                    return new Reports.SimpleListWithEmptyLines();
                case "SideBySideListWithContainers":
                    return new Reports.SideBySideListWithContainers();
            }

            return null;
        }

        private void RegData(StiReport report)
        {
            report.RegBusinessObject("Data", "Data", new Data());
        }
        #endregion

        #region Handlers
        private void treeViewReports_SelectedItemChanged(object sender, StiTreeViewEventArgs e)
        {
            RenderReport();
        }

        private void buttonPreview_Click(object sender, RoutedEventArgs e)
        {
            RenderReport();
        }

        private void buttonDesign_Click(object sender, RoutedEventArgs e)
        {
            StiReport report = null;

            if (treeViewReports.SelectedItem != null && ((StiTreeViewItem)treeViewReports.SelectedItem).Parent != null)
            {
                if (((StiTreeViewItem)treeViewReports.SelectedItem).Parent is StiTreeView) return;
                string reportName = ((StiTreeViewItem)treeViewReports.SelectedItem).Tag as string;
                report = GetMrtFile(reportName);
            }

            if (report == null)
                report = new StiReport();
            RegData(report);
            report.Design();
        }
        #endregion

        public MainPage()
        {
            #region Load Localizations
            var asm = System.Reflection.Assembly.GetExecutingAssembly();

            StiConfig.LoadLocalization(asm, "Demo.Localization.ar.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.be.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.bg.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.cro.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.cz.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.de.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.en.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.es.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.fa.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.fr.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.hu.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.it.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.ka.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.lt.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.nl.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.pl.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.pt-BR.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.ro.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.ru.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.ser.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.sk.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.sv.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.tr.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.ua.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.zh-CHS.xml");
            StiConfig.LoadLocalization(asm, "Demo.Localization.zh-CHT.xml");
            #endregion

            InitializeComponent();
            ReadReportsInfo();
        }
    }
}