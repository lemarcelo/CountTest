using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CountSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int lblValue = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        private void Increment(object sender, EventArgs e)
        {
            lblValue++;
            lblCount.Text = lblValue.ToString();
        }
    }
}
