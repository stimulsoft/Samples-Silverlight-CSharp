using System;
using System.Windows.Controls;
using Stimulsoft.Report.SLDesign;
using Stimulsoft.Base.Localization;
using System.Windows;
using Stimulsoft.Controls.SL;

namespace CustomDesigner
{
    public partial class CustomMenu : UserControl, IStiSLDesignerMenu
    {
        public CustomMenu(StiSLDesignerControl designer)
        {
            InitializeComponent();
            this.designer = designer;
        }

        #region IStiSLDesignerMenu Members
        private StiSLDesignerControl designer = null;
        public StiSLDesignerControl Designer
        {
            get
            {
                return designer;   
            }
            set
            {
                designer = value;
            }
        }

        public StiToggleButtonBase BIFontBold
        {
            get 
            {
                return btFontBold;
            }
        }

        public StiToggleButtonBase BIFontItalic
        {
            get 
            {
                return btFontItalic;
            }
        }

        public StiToggleButtonBase BIFontUnderline
        {
            get 
            {
                return btFontUnderline;
            }
        }

        public Stimulsoft.Controls.SL.RibbonDropDownButton RibbonButtonLanguage
        {
            get { throw new NotImplementedException(); }
        }

        public event System.Windows.RoutedEventHandler ButtonLanguageAssigned = null;


        public void RefreshTabState()
        {
            throw new NotImplementedException();
        }

        Stimulsoft.Controls.SL.StiMenuEx IStiSLDesignerMenu.RibbonButtonLanguage
        {
            get { throw new NotImplementedException(); }
        }

        public bool ShowMainMenu
        {
            get
            {
                return true;
            }
            set
            {
                
            }
        }

        public bool ShowQuickAccessToolBar
        {
            get
            {
                return true;
            }
            set
            {
            }
        }
        #endregion

        #region Methods
        public void Localize()
        {
            
        }

        public void RefreshRibbon()
        {
            bool isEnabled = (designer.Report != null);

            this.btPageDelete.IsEnabled = (isEnabled && designer.Report.Pages.Count > 1);
            this.btPageNew.IsEnabled = isEnabled;
            this.btPageSize.IsEnabled = isEnabled;
            this.btReportSave.IsEnabled = isEnabled;
            this.btClose.IsEnabled = isEnabled;

            object fontObject = designer.Report != null ? designer.Report.GetCurrentPage().GetFont() : null;

            btFontBold.IsEnabled = StiActions.Font.States.GetFontBoldEnabled(designer, fontObject);
            btFontItalic.IsEnabled = StiActions.Font.States.GetFontItalicEnabled(designer, fontObject);
            btFontUnderline.IsEnabled = StiActions.Font.States.GetFontUnderlineEnabled(designer, fontObject);

            object textHorizontalAlignmentObj = designer.Report != null ? designer.Report.GetCurrentPage().GetTextHorAlignment() : null;
            object horizontalAlignmentObj = designer.Report != null ? designer.Report.GetCurrentPage().GetHorAlignment() : null;
            object verticalAlignmentObj = designer.Report != null ? designer.Report.GetCurrentPage().GetVertAlignment() : null;

            btContentAlignLeft.IsEnabled = StiActions.ContentAlignment.States.GetAlignLeftEnabled(designer, textHorizontalAlignmentObj, horizontalAlignmentObj);
            btContentAlignCenter.IsEnabled = StiActions.ContentAlignment.States.GetAlignCenterEnabled(designer, textHorizontalAlignmentObj, horizontalAlignmentObj);
            btContentAlignRight.IsEnabled = StiActions.ContentAlignment.States.GetAlignRightEnabled(designer, textHorizontalAlignmentObj, horizontalAlignmentObj);
            btContentAlignWidth.IsEnabled = StiActions.ContentAlignment.States.GetAlignWidthEnabled(designer, textHorizontalAlignmentObj);
            btContentAlignTop.IsEnabled = StiActions.ContentAlignment.States.GetAlignTopEnabled(designer, verticalAlignmentObj);
            btContentAlignMiddle.IsEnabled = StiActions.ContentAlignment.States.GetAlignMiddleEnabled(designer, verticalAlignmentObj);
            btContentAlignBottom.IsEnabled = StiActions.ContentAlignment.States.GetAlignBottomEnabled(designer, verticalAlignmentObj);
            btWordWrap.IsEnabled = StiActions.ContentAlignment.States.GetWordWrapEnabled(designer);
        }

        public void RefreshControlState()
        {
            bool isEnabled = (designer.Report != null);

            this.btPageDelete.IsEnabled = (isEnabled && designer.Report.Pages.Count > 1);
            this.btPageNew.IsEnabled = isEnabled;
            this.btPageSize.IsEnabled = isEnabled;
            this.btReportSave.IsEnabled = isEnabled;
            this.btClose.IsEnabled = isEnabled;

            btFontBold.IsEnabled = isEnabled;
            btFontItalic.IsEnabled = isEnabled;
            btFontUnderline.IsEnabled = isEnabled;

            btContentAlignLeft.IsEnabled = isEnabled;
            btContentAlignCenter.IsEnabled = isEnabled;
            btContentAlignRight.IsEnabled = isEnabled;
            btContentAlignWidth.IsEnabled = isEnabled;
            btContentAlignTop.IsEnabled = isEnabled;
            btContentAlignMiddle.IsEnabled = isEnabled;
            btContentAlignBottom.IsEnabled = isEnabled;
            btWordWrap.IsEnabled = isEnabled;
        }

        public void RefreshAllControl(bool isEnabled)
        {
            this.btPageDelete.IsEnabled = isEnabled;
            this.btPageNew.IsEnabled = isEnabled;
            this.btPageSize.IsEnabled = isEnabled;
            this.btReportSave.IsEnabled = isEnabled;
            this.btClose.IsEnabled = isEnabled;

            btFontBold.IsEnabled = isEnabled;
            btFontItalic.IsEnabled = isEnabled;
            btFontUnderline.IsEnabled = isEnabled;

            btContentAlignLeft.IsEnabled = isEnabled;
            btContentAlignCenter.IsEnabled = isEnabled;
            btContentAlignRight.IsEnabled = isEnabled;
            btContentAlignWidth.IsEnabled = isEnabled;
            btContentAlignTop.IsEnabled = isEnabled;
            btContentAlignMiddle.IsEnabled = isEnabled;
            btContentAlignBottom.IsEnabled = isEnabled;
            btWordWrap.IsEnabled = isEnabled;
        }

        public void CloseRibbonMainTabControl()
        {
            
        }

        public void ApplyMainMenuConfiguration()
        {
            
        }

        public void RefreshRibbonContentAlignment()
        {
            
        }
        #endregion

        #region Handlers
        private void btReportNew_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            StiActions.MainMenu.InvokeReportNewBlank(designer);
        }

        private void btReportOpen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            StiActions.MainMenu.InvokeReportOpen(designer);
        }

        private void btReportSave_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            StiActions.MainMenu.InvokeReportSave(designer);
        }

        private void btPageNew_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            StiActions.MainMenu.InvokePageNew(designer, designer.Report.Pages.Count);
        }

        private void btPageDelete_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            StiActions.MainMenu.InvokePageDelete(designer);
        }

        private void btPageSize_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            StiActions.MainMenu.InvokePageSetup(designer);
        }

        private void btClose_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            StiActions.MainMenu.InvokeClose(designer);
        }

        private void btFontBold_Click(object sender, RoutedEventArgs e)
        {
            StiActions.Font.InvokeBold(designer, (bool)btFontBold.IsChecked);
        }

        private void btFontItalic_Click(object sender, RoutedEventArgs e)
        {
            StiActions.Font.InvokeItalic(designer, (bool)btFontItalic.IsChecked);
        }

        private void btFontUnderline_Click(object sender, RoutedEventArgs e)
        {
            StiActions.Font.InvokeUnderline(designer, (bool)btFontUnderline.IsChecked);
        }

        private void btContentAlignTop_Click(object sender, RoutedEventArgs e)
        {
            btContentAlignTop.IsChecked = true;
            btContentAlignMiddle.IsChecked = false;
            btContentAlignBottom.IsChecked = false;
            StiActions.ContentAlignment.InvokeAlignTop(designer);
        }

        private void btContentAlignMiddle_Click(object sender, RoutedEventArgs e)
        {
            btContentAlignMiddle.IsChecked = true;
            btContentAlignTop.IsChecked = false;
            btContentAlignBottom.IsChecked = false;
            StiActions.ContentAlignment.InvokeAlignMiddle(designer);
        }

        private void btContentAlignBottom_Click(object sender, RoutedEventArgs e)
        {
            btContentAlignBottom.IsChecked = true;
            btContentAlignTop.IsChecked = false;
            btContentAlignMiddle.IsChecked = false;
            StiActions.ContentAlignment.InvokeAlignBottom(designer);
        }

        private void btContentAlignLeft_Click(object sender, RoutedEventArgs e)
        {
            btContentAlignLeft.IsChecked = true;
            btContentAlignCenter.IsChecked = false;
            btContentAlignRight.IsChecked = false;
            btContentAlignWidth.IsChecked = false;
            StiActions.ContentAlignment.InvokeAlignLeft(designer);
        }

        private void btContentAlignCenter_Click(object sender, RoutedEventArgs e)
        {
            btContentAlignCenter.IsChecked = true;
            btContentAlignLeft.IsChecked = false;
            btContentAlignRight.IsChecked = false;
            btContentAlignWidth.IsChecked = false;
            StiActions.ContentAlignment.InvokeAlignCenter(designer);
        }

        private void btContentAlignRight_Click(object sender, RoutedEventArgs e)
        {
            btContentAlignRight.IsChecked = true;
            btContentAlignLeft.IsChecked = false;
            btContentAlignCenter.IsChecked = false;
            btContentAlignWidth.IsChecked = false;
            StiActions.ContentAlignment.InvokeAlignRight(designer);
        }

        private void btContentAlignWidth_Click(object sender, RoutedEventArgs e)
        {
            btContentAlignWidth.IsChecked = true;
            btContentAlignLeft.IsChecked = false;
            btContentAlignCenter.IsChecked = false;
            btContentAlignRight.IsChecked = false;
            StiActions.ContentAlignment.InvokeAlignWidth(designer);
        }

        private void btWordWrap_Click(object sender, RoutedEventArgs e)
        {
            StiActions.ContentAlignment.InvokeWordWrap(designer, (bool)btWordWrap.IsChecked);
        }
        #endregion        
    }
}