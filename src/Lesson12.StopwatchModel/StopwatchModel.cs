using System;
using System.Diagnostics;

namespace Lesson12.StopwatchModel;

public class StopwatchModel
{
    private readonly Stopwatch stopwatch = new Stopwatch();

    public TimeSpan Elapsed => stopwatch.Elapsed;

    public void Start()
    {
        stopwatch.Start();
    }

    public void Stop()
    {
        stopwatch.Stop();
    }

    public void Reset()
    {
        stopwatch.Reset();
    }
}