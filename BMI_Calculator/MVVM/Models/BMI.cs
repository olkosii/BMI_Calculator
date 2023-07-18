using PropertyChanged;

namespace BMI_Calculator.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class BMI
    {
        private float result;

        public float Height { get; set; }
        public float Weight { get; set; }
        public float Result 
        { 
            get 
            {
                return ((Weight / Height) / Height) * 10000;
            }
        }

        public string ResultText
        {
            get
            {
                string template = "BMI: #";
                if (Result < 16)
                    return template.Replace("#", "Need to it");
                else if (result >= 16 && result < 30)
                    return template.Replace("#", "Normal");
                else if (result >= 30 && result < 40)
                    return template.Replace("#", "Stop eat");
                else
                    return template.Replace("#", "Go to the Gym!");
            }
        }
    }
}
