using System.Windows;
using System.Windows.Controls;

namespace MutuallyExclusiveToggle.Controls
{
    public partial class CustomToggleButtonGroup : UserControl
    {
        #region CTOR
        public CustomToggleButtonGroup()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void ScreenToggle_Checked(object sender, RoutedEventArgs e)
        {
            if(OutputToggle.IsChecked ?? false)
                OutputToggle.IsChecked = false;
        }

        private void OutputToggle_Checked(object sender, RoutedEventArgs e)
        {
            if(ScreenToggle.IsChecked ?? false)
                ScreenToggle.IsChecked = false;
        }
        #endregion
    }
}
