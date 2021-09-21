using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S6_ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewCode : ContentPage
    {
        public ListViewCode()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            listView.ItemsSource = new string[]
            {
                "awebo",
                "monodroid",
                "monotouch",
                "monodevelop",
                "monotone",
                "monopoy",
                "monomodal",
                "mononucleosis"
            };
        }
    }
}