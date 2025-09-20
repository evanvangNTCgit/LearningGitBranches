using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LearningGitBranches
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void firstCommitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This button was made on the first commit by Evan Vang when he was learning about git branches!!");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Alright the final check is passed! Is is now in the main.
            // Okay now testing team has done all of their tests... And does not see any edge cases. 
            // Okay from the development team everything looks alright. Thumbs up!!
            var dateOfCreation = new DateTime(2025, 9, 19);

            MessageBox.Show($"{dateOfCreation}");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var evanImageWindow = new Window1();
            evanImageWindow.Show();
        }
    }
}