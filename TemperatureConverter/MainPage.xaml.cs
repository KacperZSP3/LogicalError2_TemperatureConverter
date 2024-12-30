namespace TemperatureConverter;

//Temperatura jest 

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnConvertClicked(object sender, EventArgs e)
    {
        if (double.TryParse(CelsiusEntry.Text, out double celsius))
        {
            double fahrenheit = (celsius * 5 / 9) + 32;
            ResultLabel.Text = "Fahrenheit: " + fahrenheit;
        }
        else
        {
            ResultLabel.Text = "Invalid input";
        }
    }
}