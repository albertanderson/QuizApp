using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlbertQuiz
{
    public partial class MainPage : ContentPage
    {
        public int Correct = 0;
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private void Button_StartQuiz_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Question1());
        }
    }
}
