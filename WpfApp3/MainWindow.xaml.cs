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

namespace WpfApp3
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            lbl1f.Content = ((ListBoxItem)lbx1.SelectedItem).Content;
            lbl2f.Content = ((ComboBoxItem)cmb1.SelectedItem).Content;
            lbx3f.Items.Clear();
            foreach (CheckBox checkbox in stackp3f.Children)
            {
                if (checkbox.IsChecked == true)
                {
                    lbx3f.Items.Add(checkbox.Content);
                }
            }

            foreach (RadioButton radiobutton in stackp4.Children)
            {
                if (radiobutton.IsChecked == true)
                {
                    lbl4f.Content = radiobutton.Content;
                }
            }

            lbl5f.Content = txb5f.Text;

            MessageBox.Show($"Kedves {txbNev.Text}! Kéri továbbítani az eredményeket a(z) {txbEmail.Text} címre?", "Rendelkezés", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.Yes);

        }
    }
}