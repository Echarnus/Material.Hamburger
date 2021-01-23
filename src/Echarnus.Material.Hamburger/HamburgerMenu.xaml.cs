using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Echarnus.Material.Hamburger
{
    public partial class HamburgerMenu : UserControl
    {
        #region "Transition"
        public static readonly DependencyProperty TransitionTimeProperty =
   DependencyProperty.Register(nameof(TransitionTime), typeof(KeyTime),
    typeof(HamburgerMenu), new PropertyMetadata(null));

        public KeyTime TransitionTime
        {
            get { return (KeyTime)GetValue(TransitionTimeProperty); }
            set { SetValue(TransitionTimeProperty, value); }
        }
        #endregion

        #region "Orientation"
        public static readonly DependencyProperty OrientationProperty =
   DependencyProperty.Register(nameof(Orientation), typeof(Orientation),
    typeof(HamburgerMenu), new PropertyMetadata(Orientation.Horizontal));

        public Orientation Orientation
        {
            get { return (Orientation)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }
        #endregion

        #region "MenuBackgroundProperty"
        public static readonly DependencyProperty MenuBackgroundProperty =
   DependencyProperty.Register(nameof(MenuBackground), typeof(SolidColorBrush),
    typeof(HamburgerMenu), new UIPropertyMetadata(null));

        public SolidColorBrush MenuBackground
        {
            get { return (SolidColorBrush)GetValue(MenuBackgroundProperty); }
            set { SetValue(MenuBackgroundProperty, value); }
        }
        #endregion

        #region "MenuIconForegroundProperty"
        public static readonly DependencyProperty MenuIconForegroundProperty =
   DependencyProperty.Register(nameof(MenuIconForeground), typeof(SolidColorBrush),
    typeof(HamburgerMenu), new UIPropertyMetadata(null));

        public SolidColorBrush MenuIconForeground
        {
            get { return (SolidColorBrush)GetValue(MenuIconForegroundProperty); }
            set { SetValue(MenuIconForegroundProperty, value); }
        }
        #endregion

        #region "MenuIconBackgroundProperty"
        public static readonly DependencyProperty MenuIconBackgroundProperty =
   DependencyProperty.Register(nameof(MenuIconBackground), typeof(SolidColorBrush),
    typeof(HamburgerMenu), new UIPropertyMetadata(null));

        public SolidColorBrush MenuIconBackground
        {
            get { return (SolidColorBrush)GetValue(MenuIconBackgroundProperty); }
            set { SetValue(MenuIconBackgroundProperty, value); }
        }
        #endregion

        #region "HamburgerContentProperty"
        public static readonly DependencyProperty HamburgerContentProperty =
   DependencyProperty.Register(nameof(HamburgerContent), typeof(FrameworkElement),
    typeof(HamburgerMenu), new UIPropertyMetadata(null));

        public FrameworkElement HamburgerContent
        {
            get { return (FrameworkElement)GetValue(HamburgerContentProperty); }
            set { SetValue(HamburgerContentProperty, value); }
        }
        #endregion

        public HamburgerMenu()
        {
            TransitionTime = KeyTime.FromTimeSpan(new TimeSpan(0, 0, 5));
            InitializeComponent();
        }

        bool StateClosed = true;
        private void ButtonMenu_Click(object sender, RoutedEventArgs e)
        {
            if (StateClosed)
            {
                Storyboard sb = this.FindResource("OpenMenuIcon") as Storyboard;
                sb.Begin();
            }
            else
            {
                Storyboard sb = this.FindResource("CloseMenuIcon") as Storyboard;
                sb.Begin();
            }

            StateClosed = !StateClosed;
        }
    }
}
