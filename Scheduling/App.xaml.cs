using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Scheduling.Data;
using System.IO;


namespace Scheduling
{
    public partial class App : Application
    {
        public static NotesDB notesDB; //представляет базу данных

        public static NotesDB NotesDB
        {
            get//пытаемся получить значение переменной notesDB c помощью одноименного свойства
            {
                if (notesDB == null)//содержиться ли 0-ссылка в поле DataBase (не инициализированно ли это поле уже)
                {
                    notesDB = new NotesDB(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "NotesDatabase.db3"));
                }
                return notesDB;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
