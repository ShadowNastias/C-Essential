using System;

// Presenter

namespace Lesson12.MVP;

class Presenter
{
    Model model = null;
    MainWindow view = null;

    public Presenter(MainWindow mainWindow)
    {
        this.model = new Model();
        this.view = mainWindow;

        // Subscribe to the MyEvent event
        this.view.MyEvent += View_MyEvent;
    }

    private void View_MyEvent(object sender, EventArgs e)
    {
        // Handle the event when it's raised
        var data = this.view.textBox1.Text;
        string variable = model.Logic(data);
        this.view.textBox1.Text = variable;
    }
}
