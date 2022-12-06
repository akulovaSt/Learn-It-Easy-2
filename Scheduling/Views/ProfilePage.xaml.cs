using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Scheduling.Views
{
    public partial class ProfilePage : ContentPage
    {
        public IList<Discipline> Disciplines { get; set; }
        public ProfilePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            Disciplines = new List<Discipline>();

            Disciplines.Add(new Discipline()
            {
                Name = "Мат. анализ",
                Description = "Задач: 3 Материалов: 1",
                Image = "matha.png"
            });

            Disciplines.Add(new Discipline()
            {
                Name = "Программирование",
                Description = "Задач: 2 Материалов: 0",
                Image = "proga.png"
            });

            Disciplines.Add(new Discipline()
            {
                Name = "Тестирование ПО",
                Description = "Задач: 4 Материалов: 2",
                Image = "test.png"
            });

            Disciplines.Add(new Discipline()
            {
                Name = "Философия",
                Description = "Задач: 2 Материалов: 2",
                Image = "phi.png"
            });


            BindingContext = this;

            base.OnAppearing();
            
        }

        
        

        async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Discipline selectedDisc = e.CurrentSelection[0] as Discipline;

            await DisplayAlert(selectedDisc.Name, selectedDisc.Description, "OK");
        }
    }
}