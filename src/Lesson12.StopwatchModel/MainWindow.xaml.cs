using System;
using System.Windows;

namespace Lesson12.StopwatchModel;

public partial class MainWindow : Window, IStopwatchView
{
    private readonly StopwatchPresenter presenter;

    public MainWindow()
    {
        InitializeComponent();
        presenter = new StopwatchPresenter(new StopwatchModel(), this);
    }

    public void UpdateTimeDisplay(string time)
    {
        timeTextBlock.Text = time;
    }

    private void StartButton_Click(object sender, RoutedEventArgs e)
    {
        presenter.Start();
    }

    private void StopButton_Click(object sender, RoutedEventArgs e)
    {
        presenter.Stop();
    }

    private void ResetButton_Click(object sender, RoutedEventArgs e)
    {
        presenter.Reset();
    }
}
