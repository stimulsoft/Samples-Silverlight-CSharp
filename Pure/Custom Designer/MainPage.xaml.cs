using System;
using System.Windows.Controls;
using Stimulsoft.Report;

namespace CustomDesigner
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            StiOptions.Silverlight.Designer.UseCustomMenu = true;
            StiOptions.Silverlight.Designer.CustomMenuType = typeof(CustomMenu);
            StiOptions.Silverlight.Themes.CurrentTheme = StiSilverlightThemes.Office2007Blue;
            StiOptions.Silverlight.Themes.UseDefaultTheme = false;

            InitializeComponent();
        }
    }
}