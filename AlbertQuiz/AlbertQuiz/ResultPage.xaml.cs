using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlbertQuiz
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResultPage : ContentPage
	{
        public int Correct;
		public ResultPage ()
		{
			InitializeComponent ();
		}
        public ResultPage(int Correct)
        {
            Correct = this.Correct;

        }

        private void Result_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Alert", "You got " + App.correctAnswer +" correct out of 10", "OK");
        }
    }
}