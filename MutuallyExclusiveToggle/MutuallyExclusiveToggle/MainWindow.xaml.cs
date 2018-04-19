using System.Windows;

namespace MutuallyExclusiveToggle
{
    public partial class MainWindow : Window
    {
        #region CTOR
        public MainWindow()
        {
            InitializeComponent();

            var toggleControlVM = new ToggleControlVM();
            DataContext = toggleControlVM;
        }
        #endregion
    }
}
