using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Scheduling.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthPage : ContentPage
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        //private async void Button_Clicked1(object sender, EventArgs e)
        //{
        //    string result = await DisplayPromptAsync("Авторизация",
        //        "Введите имя пользователя",
        //        "ОК",
        //        "Отмена",
        //        "Подтверждение",
        //        initialValue: "0",
        //        keyboard: Keyboard.Default);

        //    await DisplayAlert("Подтверждение", $"Вы зарешестрированы как: {result}", "ОК");
        //}
    }
}