using System.Windows;
using DnDDiceRollerCore;

namespace DnDDiceRoller
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

        private void TestDie(object sender, RoutedEventArgs e)
        {
            Die die = new Die("Fuck", 0, 10);
            rollOutput.Content = die.roll();
        }
    }
}
