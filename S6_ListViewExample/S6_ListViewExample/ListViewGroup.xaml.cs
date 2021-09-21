using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using System.Linq;


namespace S6_ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        ObservableCollection<DocenteList> docentes = new ObservableCollection<DocenteList>();

        public ListViewGroup()
        {
            InitializeComponent();
            DocenteView.ItemsSource = docentes;


            docentes.Add(new DocenteList(Cabecera: "H")
            {
                new Docente() { Name = "Hugo", LastName = "Torrico" }
            });
            docentes.Add(new DocenteList(Cabecera: "J"){
                new Docente() { Name = "Jaime", LastName = "Farfan" },
                new Docente() { Name = "Jimena", LastName = "Muñoz" },
                new Docente() { Name = "Juan", LastName = "León" },
            });
            docentes.Add(new DocenteList(Cabecera: "L"){
                new Docente() { Name = "Linder", LastName = "Hassinger" },
            });
            docentes.Add(new DocenteList(Cabecera: "O"){
                new Docente() { Name = "Oscar", LastName = "Mansilla" },
            });

        }
    }
}