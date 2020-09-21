using System.Windows;

namespace Calculator
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

    private void sevenButton_Click(object sender, RoutedEventArgs e)
    {
      if (this.resultLabel.Content.ToString() == "0")
      {
        this.resultLabel.Content = "7";
      }
      else
      {
        this.resultLabel.Content = $"{resultLabel.Content}7";
      }
    }
  }
}