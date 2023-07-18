using BMI_Calculator.MVVM.ViewModels;

namespace BMI_Calculator.MVVM.Views;

public partial class BMIView : ContentPage
{
	private BMIViewModel _viewModel;
	public BMIView()
	{
		InitializeComponent();

		_viewModel = new BMIViewModel();

		BindingContext = _viewModel;
	}
}