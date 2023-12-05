namespace Lesson12.Calculator;

public class CalculatorPresenter
{
    private readonly CalculatorModel _model;
    private readonly ICalculatorView _view;

    public CalculatorPresenter(CalculatorModel model, ICalculatorView view)
    {
        _model = model;
        _view = view;
    }

    public void PerformOperation(string operation)
    {
        double a = double.Parse(_view.GetInput());
        double b = double.Parse(_view.GetInput());

        double result = 0;

        switch (operation)
        {
            case "Add":
                result = _model.Add(a, b);
                break;
            case "Subtract":
                result = _model.Subtract(a, b);
                break;
            case "Multiply":
                result = _model.Multiply(a, b);
                break;
            case "Divide":
                result = _model.Divide(a, b);
                break;
        }

        _view.SetResult(result.ToString());
    }
}