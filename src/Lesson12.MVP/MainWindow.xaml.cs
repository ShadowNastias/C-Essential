using System;
using System.Windows;

// View

namespace Lesson12.MVP;

public partial class MainWindow : Window
{
    private event EventHandler MyCustomEvent;

    public event EventHandler MyEvent
    {
        add { MyCustomEvent += value; }
        remove { MyCustomEvent -= value; }
    }

    public MainWindow()
    {
        InitializeComponent();
        new Presenter(this);
    }

    public event EventHandler myEvent = null;

    private void button1_Click(object sender, RoutedEventArgs e)
    {
        MyCustomEvent?.Invoke(this, EventArgs.Empty);
    }
}