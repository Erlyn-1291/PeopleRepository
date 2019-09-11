using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;
using People.Models;


namespace People
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        void OnNewButoonClicked(object sender, EventArgs e)
        {
            // Get path
            string dbPath =
                Path.Combine
                (Environment.GetFolderPath
                (Environment.SpecialFolder.LocalApplicationData), "dbPeople.db");

            PersonRepositoryCRUD personRepo = // NombreVariable.Miembro
                new PersonRepositoryCRUD(dbPath);

            // Crear un objeto Person
            Person NewPerson = new Person();
            NewPerson.Name = EntryPersonName.Text;

            personRepo.CreatePerson(NewPerson);

            LabelStatusMessage.Text = personRepo.StatusMessage;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
