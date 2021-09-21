using System;
using System.Collections;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S6_ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewSource : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
       
        public ListViewSource()
        {
            InitializeComponent();
            EmployeeView.ItemsSource = employees;
            employees.Add(new Employee { DisplayName = "Jassyra Espinoza" });
            employees.Add(new Employee { DisplayName = "Danae Quispe" });
            employees.Add(new Employee { DisplayName = "Samm Alcantara" });
            employees.Add(new Employee { DisplayName = "Kiara Pinedo" });
        }

    }
}