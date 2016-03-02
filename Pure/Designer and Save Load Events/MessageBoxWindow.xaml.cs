using System;
using System.Windows.Controls;
using System.Windows;

namespace DesignerSaveLoad
{
    public partial class MessageBoxWindow : ChildWindow
    {
        #region Fields
        public MessageBoxResult Result = MessageBoxResult.None;
        #endregion

        public MessageBoxWindow()
        {
            InitializeComponent();
        }

        private void btYes_Click(object sender, RoutedEventArgs e)
        {
            Result = MessageBoxResult.Yes;
            this.Close();
        }

        private void btNo_Click(object sender, RoutedEventArgs e)
        {
            Result = MessageBoxResult.No;
            this.Close();
        }
    }
}