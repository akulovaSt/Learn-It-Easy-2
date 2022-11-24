using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Scheduling.Models;

namespace Scheduling.Views
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
   
    public partial class NoteAddingPage : ContentPage
    {
        public string ItemId
        {
            set
            {
                LoadNote(value);
            }
        }

        public NoteAddingPage()
        {
            InitializeComponent();

            BindingContext = new Note();
        }

        private async void LoadNote(string value)
        {
            try
            {
                int id = Convert.ToInt32(value);
                Note note = await App.NotesDB.GetNoteAsync(id);//получение записки из бд
                BindingContext = note;
            }
            catch { }
        }

        private async void OnSaveButton_Clicked(Object sender, EventArgs e)
        {
            Note note = (Note)BindingContext;

            note.Date = DateTime.UtcNow;

            if (!string.IsNullOrWhiteSpace(note.Text))//провека на пробелы
            {
                await App.NotesDB.SaveNoteAsync(note);
            }

            await Shell.Current.GoToAsync("..");//шаг назад (возвращаемся к списку всех заметок)
        }

        private async void OnDeleteButton_CLicked(Object sender, EventArgs e)
        {
            Note note = (Note)BindingContext;

            await App.NotesDB.DeleteNoteAsync(note);

            await Shell.Current.GoToAsync(".."); 
        }
    }
}