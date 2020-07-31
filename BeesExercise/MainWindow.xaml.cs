using BeesExercise.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BeesExercise
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Bee _SelectedBee;
        public MainWindow()
        {
            InitializeComponent();
            PopulateBeeBox();
            damage.IsEnabled = false;
        }

        public void PopulateBeeBox()
        {
            
            List<Bee> BeeList = new List<Bee>();
            BeeList.Add(new Worker());
            BeeList.Add(new Queen());
            BeeList.Add(new Drone());

            for (int i = 1; i < 10; i++)
            {
                BeeList.Add(new Worker() { Type = $"Worker {i + 1}" });
                BeeList.Add(new Queen() { Type = $"Queen {i + 1}" });
                BeeList.Add(new Drone() { Type = $"Drone {i + 1}" });
            }

            listBees.ItemsSource = BeeList.ToList();
        }

        private void listBoxBees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            damage.IsEnabled = true;

            if (listBees != null)
            {
                _SelectedBee = (Bee)listBees.SelectedItem;
                Type.Text = $"Type: {_SelectedBee.Type}";
                Health.Text = $"Health: {_SelectedBee.Health}";
                Alive.Text = $"Alive: {_SelectedBee.Alive}";
            }

        }

        private void damage_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int random = rnd.Next(100);
            _SelectedBee.Damage(random);
            Health.Text = $"Health: {_SelectedBee.Health}";
            Alive.Text = $"Alive: {_SelectedBee.Alive}";
        }
    }
}
