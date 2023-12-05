using System.Windows;

namespace Lesson12.Calculator;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private double intermediateResult = 0; // Variable to store intermediate result
    private bool isOperationClicked = false; // Flag to track if an operation button was clicked

    public MainWindow()
    {
        InitializeComponent();
    }

    private void AddButton_Click(object sender, RoutedEventArgs e)
    {
        double a, b;
        if (double.TryParse(inputTextBox1.Text, out a) && double.TryParse(inputTextBox2.Text, out b))
        {
            intermediateResult = a + b;
            isOperationClicked = true;
        }
        else
        {
            resultTextBlock.Text = "Invalid input";
        }
    }

    private void SubtractButton_Click(object sender, RoutedEventArgs e)
    {
        double a, b;
        if (double.TryParse(inputTextBox1.Text, out a) && double.TryParse(inputTextBox2.Text, out b))
        {
            intermediateResult = a - b;
            isOperationClicked = true;
        }
        else
        {
            resultTextBlock.Text = "Invalid input";
        }
    }

    private void MultiplyButton_Click(object sender, RoutedEventArgs e)
    {
        double a, b;
        if (double.TryParse(inputTextBox1.Text, out a) && double.TryParse(inputTextBox2.Text, out b))
        {
            intermediateResult = a * b;
            isOperationClicked = true;
        }
        else
        {
            resultTextBlock.Text = "Invalid input";
        }
    }

    private void DivideButton_Click(object sender, RoutedEventArgs e)
    {
        double a, b;
        if (double.TryParse(inputTextBox1.Text, out a) && double.TryParse(inputTextBox2.Text, out b))
        {
            if (b != 0)
            {
                intermediateResult = a / b;
                isOperationClicked = true;
            }
            else
            {
                resultTextBlock.Text = "Cannot divide by zero";
            }
        }
        else
        {
            resultTextBlock.Text = "Invalid input";
        }
    }


    private void EqualsButton_Click(object sender, RoutedEventArgs e)
    {
        if (isOperationClicked)
        {
            resultTextBlock.Text = intermediateResult.ToString();
            isOperationClicked = false; // Reset the flag
        }
    }
}