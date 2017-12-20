using Xamarin.Forms;

namespace ICT13570014B
{
    public partial class ICT13570014BPage : ContentPage
    {
        public ICT13570014BPage()
        {
            InitializeComponent();
            okButton.Clicked += OkButton_Clicked;
            genderPicker.Items.Add("ชาย");
            genderPicker.Items.Add("หญิง");

            mySlider.ValueChanged += MySlider_ValueChanged;
            myStepper.ValueChanged += MyStepper_ValueChanged;
        }

        void OkButton_Clicked(object sender, System.EventArgs e)
        {
            CamelCaseLabel.Text = CamelCaseLabel2.Text;
        }

        void MySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }

        void MyStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }
    }
}
