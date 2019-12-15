﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlbertQuiz
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Question6 : ContentPage
	{

		public Question6 ()
		{
			InitializeComponent ();
		}

        //"Correct Answer" in popup box
        private void Correct_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Corrrect Answer!", "OK");
            App.correctAnswer++;
            Navigation.PushAsync(new Question7());
        }

        //"Sorry incorrect Answer" in pop up box
        private void Incorrect_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Sorry Incorrect Answer", "OK");
            Navigation.PushAsync(new Question7());
        }

        //"Sorry incorrect Answer" in pop up box
        private void Incorrect2_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Sorry Incorrect Answer", "OK");
            Navigation.PushAsync(new Question7());
        }
    }
}