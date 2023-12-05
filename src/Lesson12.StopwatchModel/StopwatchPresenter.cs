using System;
using System.Windows.Threading;

namespace Lesson12.StopwatchModel;

public class StopwatchPresenter
{
    private readonly StopwatchModel model;
    private readonly IStopwatchView view;
    private readonly DispatcherTimer timer;

    public StopwatchPresenter(StopwatchModel model, IStopwatchView view)
    {
        this.model = model;
        this.view = view;
        this.timer = new DispatcherTimer
        {
            Interval = TimeSpan.FromMilliseconds(100)
        };
        this.timer.Tick += Timer_Tick;
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        view.UpdateTimeDisplay(model.Elapsed.ToString("hh\\:mm\\:ss\\.ff"));
    }

    public void Start()
    {
        model.Start();
        timer.Start();
    }

    public void Stop()
    {
        model.Stop();
        timer.Stop();
    }

    public void Reset()
    {
        model.Reset();
        view.UpdateTimeDisplay("00:00:00.00");
    }
}