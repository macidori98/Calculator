using System.Windows;

namespace Calculator
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private double lastNumber, result;

    public MainWindow()
    {
      InitializeComponent();

      this.acButton.Click += AcButton_Click;
      this.negativeButton.Click += NegativeButton_Click;
      this.percentageButton.Click += PercentageButton_Click;
    }

    private void PercentageButton_Click(object sender, RoutedEventArgs e)
    {
      if (this.resultLabel.Content.ToString() != "0")
      {
        if (double.TryParse(this.resultLabel.Content.ToString(), out lastNumber))
        {
          this.resultLabel.Content = (this.lastNumber / 100);
        }
      }
    }

    private void NegativeButton_Click(object sender, RoutedEventArgs e)
    {
      if (this.resultLabel.Content.ToString() != "0")
      {
        if (double.TryParse(this.resultLabel.Content.ToString(), out lastNumber))
        {
          this.resultLabel.Content = (this.lastNumber * (-1));
        }
      }
    }

    private void AcButton_Click(object sender, RoutedEventArgs e)
    {
      this.resultLabel.Content = "0";
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