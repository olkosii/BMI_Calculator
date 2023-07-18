using BMI_Calculator.MVVM.Models;

namespace BMI_Calculator.MVVM.ViewModels
{
    public class BMIViewModel
    {
        public BMI BMI { get; set; }

        public BMIViewModel()
        {
            BMI = new BMI
            {
                Height = 183,
                Weight = 67
            };
        }
    }
}
