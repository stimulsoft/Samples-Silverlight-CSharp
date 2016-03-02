using System;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using Stimulsoft.Report;

namespace CustomViewer
{
    public partial class MainPage : UserControl
    {
        #region Fields
        private Stimulsoft.Report.StiReport Report;
        private bool Lock = false;
        #endregion

        #region Methods
        private void Init()
        {
            Lock = true;

            cbBookmarks.IsChecked = PreviewControl.IsBookmarksActivated;
            cbToolbar.IsChecked = StiOptions.Viewer.Elements.ShowMainToolBar;
            cbStatusBar.IsChecked = StiOptions.Viewer.Elements.ShowStatusBar;
            cbPrint.IsChecked = StiOptions.Viewer.Elements.ShowReportPrintButton;
            cbOpen.IsChecked = StiOptions.Viewer.Elements.ShowReportOpenButton;
            cbSave.IsChecked = StiOptions.Viewer.Elements.ShowReportSaveButton;
            cbPageNew.IsChecked = StiOptions.Viewer.Elements.ShowPageNewButton;
            cbPageDelete.IsChecked = StiOptions.Viewer.Elements.ShowPageDeleteButton;
            cbPageSize.IsChecked = StiOptions.Viewer.Elements.ShowPageSizeButton;
            cbBookmarksButton.IsChecked = StiOptions.Viewer.Elements.ShowBookmarksPanel;
            cbToolEditor.IsChecked = StiOptions.Viewer.Elements.ShowToolEditorButton;
            cbToolFind.IsChecked = PreviewControl.IsToolFindActivated;
            cbZoomOnePage.IsChecked = StiOptions.Viewer.Elements.ShowZoomOnePageButton;
            cbZoomTwoPages.IsChecked = StiOptions.Viewer.Elements.ShowZoomTwoPagesButton;
            cbZoomPageWidth.IsChecked = StiOptions.Viewer.Elements.ShowZoomPageWidthButton;
            cbFind.IsChecked = StiOptions.Viewer.Elements.ShowToolFindButton;
            cbFullScreen.IsChecked = StiOptions.Viewer.Elements.ShowFullScreenButton;

            Lock = false;
        }
        #endregion

        #region Handlers
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Report = new Stimulsoft.Report.StiReport();
            var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("CustomViewer.BarCodes.mrt");
            Report.Load(stream);

            stream.Close();
            stream.Dispose();
            stream = null;

            btRefresh_Click(null, null);
            PreviewControl.Report = Report;
            Init();
        }

        private void btRefresh_Click(object sender, RoutedEventArgs e)
        {
            Report.Render();
            PreviewControl.SaveConfig();
            PreviewControl.Refresh();
            PreviewControl.LoadConfig();
        }

        private void cbBookmarks_CheckedUnChecked(object sender, EventArgs e)
        {
            if (!Lock)
            {
                PreviewControl.IsBookmarksActivated = cbBookmarks.IsChecked;
                PreviewControl.UpdateControlsState();
            }
        }

        private void cbToolbar_CheckedUnchecked(object sender, EventArgs e)
        {
            if (!Lock)
            {
                StiOptions.Viewer.Elements.ShowMainToolBar = cbToolbar.IsChecked;
                PreviewControl.UpdateControlsState();
            }
        }

        private void cbStatusBar_CheckedUnchecked(object sender, EventArgs e)
        {
            if (!Lock)
            {
                StiOptions.Viewer.Elements.ShowStatusBar = cbStatusBar.IsChecked;
                PreviewControl.UpdateControlsState();
            }
        }

        private void cbPrint_CheckedUnchecked(object sender, EventArgs e)
        {
            if (!Lock)
            {
                StiOptions.Viewer.Elements.ShowReportPrintButton = cbPrint.IsChecked;
                PreviewControl.UpdateControlsState();
            }
        }

        private void cbOpen_CheckedUnchecked(object sender, EventArgs e)
        {
            if (!Lock)
            {
                StiOptions.Viewer.Elements.ShowReportOpenButton = cbOpen.IsChecked;
                PreviewControl.UpdateControlsState();
            }
        }

        private void cbSave_CheckedUnchecked(object sender, EventArgs e)
        {
            if (!Lock)
            {
                StiOptions.Viewer.Elements.ShowReportSaveButton = cbSave.IsChecked;
                PreviewControl.UpdateControlsState();
            }
        }

        private void cbPageNew_CheckedUnchecked(object sender, EventArgs e)
        {
            if (!Lock)
            {
                StiOptions.Viewer.Elements.ShowPageNewButton = cbPageNew.IsChecked;
                PreviewControl.UpdateControlsState();
            }
        }

        private void cbPageDelete_CheckedUnchecked(object sender, EventArgs e)
        {
            if (!Lock)
            {
                StiOptions.Viewer.Elements.ShowPageDeleteButton = cbPageDelete.IsChecked;
                PreviewControl.UpdateControlsState();
            }
        }

        private void cbPageSize_CheckedUnchecked(object sender, EventArgs e)
        {
            if (!Lock)
            {
                StiOptions.Viewer.Elements.ShowPageSizeButton = cbPageSize.IsChecked;
                PreviewControl.UpdateControlsState();
            }
        }

        private void cbBookmarksButton_CheckedUnchecked(object sender, EventArgs e)
        {
            if (!Lock)
            {
                StiOptions.Viewer.Elements.ShowBookmarksPanel = cbBookmarksButton.IsChecked;
                PreviewControl.UpdateControlsState();
            }
        }

        private void cbFind_CheckedUnchecked(object sender, EventArgs e)
        {
            if (!Lock)
            {
                StiOptions.Viewer.Elements.ShowToolFindButton = cbFind.IsChecked;
                PreviewControl.UpdateControlsState();
            }
        }

        private void cbToolEditor_CheckedUnchecked(object sender, EventArgs e)
        {
            if (!Lock)
            {
                StiOptions.Viewer.Elements.ShowToolEditorButton = cbToolEditor.IsChecked;
                PreviewControl.UpdateControlsState();
            }
        }

        private void cbToolFind_CheckedUnchecked(object sender, EventArgs e)
        {
            if (!Lock)
            {
                PreviewControl.IsToolFindActivated = cbToolFind.IsChecked;
                PreviewControl.UpdateControlsState();
            }
        }

        private void cbFullScreen_CheckedUnchecked(object sender, EventArgs e)
        {
            if (!Lock)
            {
                StiOptions.Viewer.Elements.ShowFullScreenButton = cbFullScreen.IsChecked;
                PreviewControl.UpdateControlsState();
            }
        }

        private void cbZoomOnePage_CheckedUnchecked(object sender, EventArgs e)
        {
            if (!Lock)
            {
                StiOptions.Viewer.Elements.ShowZoomOnePageButton = cbZoomOnePage.IsChecked;
                PreviewControl.UpdateControlsState();
            }
        }

        private void cbZoomTwoPages_CheckedUnchecked(object sender, EventArgs e)
        {
            if (!Lock)
            {
                StiOptions.Viewer.Elements.ShowZoomTwoPagesButton = cbZoomTwoPages.IsChecked;
                PreviewControl.UpdateControlsState();
            }
        }

        private void cbZoomPageWidth_CheckedUnchecked(object sender, EventArgs e)
        {
            if (!Lock)
            {
                StiOptions.Viewer.Elements.ShowZoomPageWidthButton = cbZoomPageWidth.IsChecked;
                PreviewControl.UpdateControlsState();
            }
        }

        private void tbOnePage_Click(object sender, RoutedEventArgs e)
        {
            PreviewControl.InvokeZoomOnePage();
        }

        private void tbTwoPages_Click(object sender, RoutedEventArgs e)
        {
            PreviewControl.InvokeZoomTwoPages();
        }

        private void tbNormal_Click(object sender, RoutedEventArgs e)
        {
            PreviewControl.InvokeSetZoom(100d);
        }

        private void tbPageWidth_Click(object sender, RoutedEventArgs e)
        {
            PreviewControl.InvokeZoomPageWidth();
        }

        private void tbFirstPage_Click(object sender, RoutedEventArgs e)
        {
            PreviewControl.InvokePageFirst();
        }

        private void tbPreviousPage_Click(object sender, RoutedEventArgs e)
        {
            PreviewControl.InvokePagePrevious();
        }

        private void tbNextPage_Click(object sender, RoutedEventArgs e)
        {
            PreviewControl.InvokePageNext();
        }

        private void tbLastPage_Click(object sender, RoutedEventArgs e)
        {
            PreviewControl.InvokePageLast();
        }
        #endregion

        public MainPage()
        {
            InitializeComponent();
        }
    }
}