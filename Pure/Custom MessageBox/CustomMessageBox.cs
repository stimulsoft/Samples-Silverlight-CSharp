using System;
using Stimulsoft.Report.SL;
using System.Windows;
using System.Windows.Media.Imaging;
using Stimulsoft.Report.SL.MessageBox;

namespace CustomMessageBox
{
    public class StiMessageBox : IStiMessageBox
    {
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //The implementation of ButtonYesClick and ButtonNoClick events should be done as 
        //shown in the example. They are used for saving and opening a report in 
        //the designer. Events must work strictly by clicking the button!
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        #region Fields
        private CustomMessageBoxWindow window = null;
        #endregion

        #region Properties
        private MessageBoxResult result = MessageBoxResult.Cancel;
        public MessageBoxResult Result
        {
            get
            {
                return result;
            }
        }
        #endregion

        #region Methods
        public void Show(string messageBoxText, DependencyObject parentWindow = null)
        {
            Show(messageBoxText, string.Empty, StiMessageBoxButton.OK, StiMessageBoxImage.Information, parentWindow);
        }

        public void Show(string messageBoxText, string caption, DependencyObject parentWindow = null)
        {
            Show(messageBoxText, caption, StiMessageBoxButton.OK, StiMessageBoxImage.Information, parentWindow);
        }

        public void Show(string messageBoxText, string caption, StiMessageBoxButton button, DependencyObject parentWindow = null)
        {
            Show(messageBoxText, caption, button, StiMessageBoxImage.Information, parentWindow);
        }

        public void Show(string messageBoxText, StiMessageBoxImage icon, DependencyObject parentWindow = null)
        {
            Show(messageBoxText, string.Empty, StiMessageBoxButton.OK, icon, parentWindow);
        }

        public void Show(string messageBoxText, string caption, StiMessageBoxButton button, StiMessageBoxImage icon, DependencyObject parentWindow = null)
        {
            window = new CustomMessageBoxWindow();

#if Silverlight5
            if (parentWindow != null && Application.Current.IsRunningOutOfBrowser)
            {
                System.Windows.Window sysWindow = System.Windows.Window.GetWindow(parentWindow);
                window.SetWindow(sysWindow);
            }
#endif

            window.textBlockMessage.Text = messageBoxText;
            window.Title = caption;

            #region StiMessageBoxButton
            switch (button)
            {
                #region StiMessageBoxButton.OK
                case StiMessageBoxButton.OK:
                    window.Result = MessageBoxResult.OK;
                    window.messageButtonOK.Visibility = Visibility.Visible;
                    window.buttonOk1.Focus();
                    break;
                #endregion

                #region StiMessageBoxButton.OKCancel
                case StiMessageBoxButton.OKCancel:
                    window.Result = MessageBoxResult.Cancel;
                    window.messageButtonOKCancel.Visibility = Visibility.Visible;
                    window.buttonOk2.Focus();
                    break;
                #endregion

                #region StiMessageBoxButton.YesNo
                case StiMessageBoxButton.YesNo:
                    window.Result = MessageBoxResult.No;
                    window.messageButtonYesNo.Visibility = Visibility.Visible;
                    window.buttonYes3.Focus();
                    break;
                #endregion

                #region StiMessageBoxButton.YesNoCancel
                case StiMessageBoxButton.YesNoCancel:
                    window.Result = MessageBoxResult.Cancel;
                    window.messageButtonYesNoCancel.Visibility = Visibility.Visible;
                    window.buttonYes4.Focus();
                    break;
                #endregion
            }
            #endregion

            #region MessageBoxImage
            switch (icon)
            {
                case StiMessageBoxImage.Error:
                    window.image.Source = new BitmapImage(new Uri("/CustomMessageBox;component/Images/Error.png", UriKind.RelativeOrAbsolute));
                    break;

                case StiMessageBoxImage.Information:
                    window.image.Source = new BitmapImage(new Uri("/CustomMessageBox;component/Images/Information.png", UriKind.RelativeOrAbsolute));
                    break;

                case StiMessageBoxImage.Warning:
                    window.image.Source = new BitmapImage(new Uri("/CustomMessageBox;component/Images/Warning.png", UriKind.RelativeOrAbsolute));
                    break;
                default:
                    window.image.Visibility = Visibility.Collapsed;
                    break;
            }
            #endregion

            window.ButtonYesClick += new RoutedEventHandler(buttonYes_Click);
            window.ButtonNoClick += new RoutedEventHandler(buttonNo_Click);

            window.Closed += delegate
            {
                result = window.Result;
                InvokeClosed();
            };
            window.Show();
        }
        #endregion

        #region Handlers
        private void buttonYes_Click(object sender, RoutedEventArgs e)
        {
            InvokeButtonYesClick();
        }

        private void buttonNo_Click(object sender, RoutedEventArgs e)
        {
            InvokeButtonNoClick();
        }
        #endregion

        #region Events
        public event EventHandler Closed;
        private void InvokeClosed()
        {
            if (Closed != null) Closed(this, null);
        }

        public event RoutedEventHandler ButtonYesClick;
        protected void InvokeButtonYesClick()
        {
            if (ButtonYesClick != null) ButtonYesClick(this, null);
        }

        public event RoutedEventHandler ButtonNoClick;
        private void InvokeButtonNoClick()
        {
            if (ButtonNoClick != null) ButtonNoClick(this, null);
        }
        #endregion
    }
}