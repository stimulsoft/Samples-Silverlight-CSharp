using System;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media.Animation;

namespace CustomMessageBox
{
    public partial class CustomMessageBoxWindow : ChildWindow
    {
        #region Fields
        public MessageBoxResult Result = MessageBoxResult.None;
        #endregion

        #region Handlers
        private void buttonOk1_Click(object sender, RoutedEventArgs e)
        {
            Result = MessageBoxResult.OK;
            this.Close();
        }

        private void buttonOk2_Click(object sender, RoutedEventArgs e)
        {
            Result = MessageBoxResult.OK;
            this.Close();
        }

        private void buttonCancel2_Click(object sender, RoutedEventArgs e)
        {
            Result = MessageBoxResult.Cancel;
            this.Close();
        }

        private void buttonYes3_Click(object sender, RoutedEventArgs e)
        {
            InvokeButtonYesClick();
            Result = MessageBoxResult.Yes;
            this.Close();
        }

        private void buttonNo3_Click(object sender, RoutedEventArgs e)
        {
            InvokeButtonNoClick();
            Result = MessageBoxResult.No;
            this.Close();
        }

        private void buttonYes4_Click(object sender, RoutedEventArgs e)
        {
            InvokeButtonYesClick();
            Result = MessageBoxResult.Yes;
            this.Close();
        }

        private void buttonNo4_Click(object sender, RoutedEventArgs e)
        {
            InvokeButtonNoClick();
            Result = MessageBoxResult.No;
            this.Close();
        }

        private void buttonCancel4_Click(object sender, RoutedEventArgs e)
        {
            Result = MessageBoxResult.Cancel;
            this.Close();
        }

        private void ChildWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.BeginTime = TimeSpan.FromMilliseconds(0);
            animation.Duration = TimeSpan.FromMilliseconds(700);
            animation.RepeatBehavior = RepeatBehavior.Forever;
            animation.AutoReverse = true;
            animation.From = 1;
            animation.To = 0.4;

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(animation);
            Storyboard.SetTarget(animation, image);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Image.OpacityProperty));

            storyboard.Begin();
        }
        #endregion

        #region Events
        public event RoutedEventHandler ButtonYesClick;
        private void InvokeButtonYesClick()
        {
            if (ButtonYesClick != null) ButtonYesClick(this, null);
        }

        public event RoutedEventHandler ButtonNoClick;
        private void InvokeButtonNoClick()
        {
            if (ButtonNoClick != null) ButtonNoClick(this, null);
        }
        #endregion

        public CustomMessageBoxWindow()
        {
            InitializeComponent();
        }
    }
}