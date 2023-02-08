using System.ComponentModel;
using task2LoginPage.ViewModel;
using Xamarin.Forms;

namespace task2LoginPage
{
    public partial class MainPage : ContentPage
    {
        MainPageVM vm;
        public MainPage()
        {
            InitializeComponent();
            vm = new MainPageVM();
            BindingContext = vm;
        }
    }
}

