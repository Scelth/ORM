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
using Wiki.Model;

namespace Wiki.View
{
    /// <summary>
    /// Interaction logic for AddView.xaml
    /// </summary>
    public partial class AddView : UserControl
    {
        public AddView()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            nameTextBox.Text = string.Empty;
            yearTextBox.Text = null;
            typeOfBoardTextBox.Text = string.Empty;
            mapTextBox.Text = string.Empty;
            populationTextBox.Text = string.Empty;
            areaTextBox.Text = string.Empty;
            gdpTextBox.Text = string.Empty;
            rulerTextBox.Text = string.Empty;
            anthemTextBox.Text = string.Empty;
        }
    }
}
