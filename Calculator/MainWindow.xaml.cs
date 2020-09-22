using System.Windows;

namespace Calculator
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private double lastNumber, result; // private as default
    private SelectedOperator selectedOperator;

    public MainWindow()
    {
      InitializeComponent();

      this.acButton.Click += AcButton_Click;
      this.negativeButton.Click += NegativeButton_Click;
      this.percentageButton.Click += PercentageButton_Click;
      this.equalButton.Click += EqualButton_Click;
    }

    private void EqualButton_Click(object sender, RoutedEventArgs e)
    {
      double temp;

      if (double.TryParse(this.resultLabel.Content.ToString(), out temp))
      {
        switch (this.selectedOperator)
        {
          case SelectedOperator.Addition:
            this.result = MyMath.Add(this.lastNumber, temp);
            break;

          case SelectedOperator.Substraction:
            this.result = MyMath.Sub(this.lastNumber, temp);
            break;

          case SelectedOperator.Multiplication:
            this.result = MyMath.Mul(this.lastNumber, temp);
            break;

          case SelectedOperator.Division:
            if (temp == 0)
            {
              MessageBox.Show("Division by 0 is not supported", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
              this.result = MyMath.Div(this.lastNumber, temp);
            }

            break;

          default:
            break;
        }

        this.resultLabel.Content = this.result.ToString();
      }
    }

    private void PercentageButton_Click(object sender, RoutedEventArgs e)
    {
      if (this.lastNumber == 0)
      {
        if (double.TryParse(this.resultLabel.Content.ToString(), out lastNumber))
        {
          this.resultLabel.Content = (this.lastNumber / 100);
        }
      }
      else
      {
        double temp;
        if (double.TryParse(this.resultLabel.Content.ToString(), out temp))
        {
          this.resultLabel.Content = ((this.lastNumber*temp) / 100);
        }
      }
    }

    private void NegativeButton_Click(object sender, RoutedEventArgs e)
    {
      if (this.resultLabel.Content.ToString() != "0")
      {
        if (double.TryParse(this.resultLabel.Content.ToString(), out lastNumber))
        {
          this.resultLabel.Content = (this.lastNumber * (-1)).ToString();
        }
      }
    }

    private void AcButton_Click(object sender, RoutedEventArgs e)
    {
      this.resultLabel.Content = "0";
      this.result = 0;
      this.lastNumber = 0;
    }

    private void OperationButton_Click(object sender, RoutedEventArgs e)
    {
      if (double.TryParse(this.resultLabel.Content.ToString(), out lastNumber))
      {
        this.resultLabel.Content = "0";
      }

      if (sender == this.divisionButton)
      {
        this.selectedOperator = SelectedOperator.Division;
      }

      if (sender == this.plusButton)
      {
        this.selectedOperator = SelectedOperator.Addition;
      }

      if (sender == this.multiplyButton)
      {
        this.selectedOperator = SelectedOperator.Multiplication;
      }

      if (sender == this.minusButton)
      {
        this.selectedOperator = SelectedOperator.Substraction;
      }
    }

    private void PointButton_Click(object sender, RoutedEventArgs e)
    {
      if (!this.resultLabel.Content.ToString().Contains("."))
      {
        this.resultLabel.Content = $"{this.resultLabel.Content}.";
      }
    }

    private void NumberButton_Click(object sender, RoutedEventArgs e)
    {
      int selectedValue = 0;

      if (sender == this.zeroButton)
      {
        selectedValue = 0;
      }

      if (sender == this.oneButton)
      {
        selectedValue = 1;
      }

      if (sender == this.twoButton)
      {
        selectedValue = 2;
      }

      if (sender == this.threeButton)
      {
        selectedValue = 3;
      }

      if (sender == this.fourButton)
      {
        selectedValue = 4;
      }

      if (sender == this.fiveButton)
      {
        selectedValue = 5;
      }

      if (sender == this.sixButton)
      {
        selectedValue = 6;
      }

      if (sender == this.sevenButton)
      {
        selectedValue = 7;
      }

      if (sender == this.eightButton)
      {
        selectedValue = 8;
      }

      if (sender == this.nineButton)
      {
        selectedValue = 9;
      }

      if (this.resultLabel.Content.ToString() == "0")
      {
        this.resultLabel.Content = $"{selectedValue}";
      }
      else
      {
        this.resultLabel.Content = $"{resultLabel.Content}{selectedValue}";
      }
    }
  }

  public enum SelectedOperator
  {
    Addition,
    Substraction,
    Multiplication,
    Division
  }

  public class MyMath
  {
    public static double Add(double x, double y)
    {
      return x + y;
    }

    public static double Div(double x, double y)
    {
      return x / y;
    }

    public static double Sub(double x, double y)
    {
      return x - y;
    }

    public static double Mul(double x, double y)
    {
      return x * y;
    }
  }
}