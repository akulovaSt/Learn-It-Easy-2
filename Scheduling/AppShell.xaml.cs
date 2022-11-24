using Scheduling.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Scheduling
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
           
            Routing.RegisterRoute(nameof(NoteAddingPage), typeof(NoteAddingPage));
            //Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }
    }
}