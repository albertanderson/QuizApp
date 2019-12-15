using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AlbertQuiz.Answers;


namespace AlbertQuiz
{

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Question1 : ContentPage
	{
		public Question1 ()
		{
			InitializeComponent ();

        }

        //"Correct Answer" in popup box
        private void Correct_Clicked(object sender, EventArgs e)
        {
            App.correctAnswer++;
            DisplayAlert("Alert", "Corrrect Answer!", "OK");
            Navigation.PushAsync(new Question2());
        }

        //"Sorry incorrect Answer" in pop up box
        private void Incorrect_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Sorry Incorrect Answer", "OK");
            Navigation.PushAsync(new Question2());
        }

        //"Sorry incorrect Answer" in pop up box
        private void Incorrect2_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Sorry Incorrect Answer", "OK");
            Navigation.PushAsync(new Question2());
        }
    }
}