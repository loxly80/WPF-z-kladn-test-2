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
      combo.SelectedIndex = 0;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      canvas.Children.Clear();
      Random random = new Random();
      var x = random.Next(3, 11);
      var y = random.Next(3, 11);

      for (int i = 0; i < x; i++)
      {
        for (int j = 0; j < y; j++)
        {
          var rect = new Rectangle()
          {
            Width = 10,
            Height = 10
          };
          if (combo.SelectedIndex == 0)
          {
            rect.Fill = (i + j) % 2 == 0 ? Brushes.Red : Brushes.Blue;
          }
          else
          {
            rect.Fill = (i + j) % 2 == 0 ? Brushes.Blue : Brushes.Red;
          }            
          Canvas.SetLeft(rect, i * 15 + 5);
          Canvas.SetTop(rect, j * 15 + 5);
          canvas.Children.Add(rect);
        }
      }
    }
  }
}
