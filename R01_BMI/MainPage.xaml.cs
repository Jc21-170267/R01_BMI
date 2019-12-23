using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R01_BMI
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String h = sintyou.Text;
            String w = taijyu.Text;
            double hh = double.Parse(h);
            double ww = double.Parse(w);

            double x = ww / (hh / 100 * hh / 100);
            double a = Math.Round(x, MidpointRounding.AwayFromZero);
            anser.Text = "BMIは" + a + "です。";
        }
    }
}
