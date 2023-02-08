using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace task2LoginPage.ViewModel
{
    public class MainPageVM : INotifyPropertyChanged
    {
        /*private string _username;
        public string username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                PropertyChanged(this, new PropertyChangedEventArgs("username"));
            }
        }

        private string _password;

        public string password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("password"));
            }
        }
        */

        public MainPageVM()
        {
        }
        public Command MainPageLoginCommand
        {
            get
            {
                return new Command(MainPageLogin);
            }
        }
        public Command SignUpCommand
        {
            get
            {
                return new Command(SignUp);
            }
        }
       

        private void MainPageLogin()
        {
            App.Current.MainPage.Navigation.PushAsync(new LoginPage());
            /*if (username.Length.Equals(8) && password.Length.Equals(8) && !username.Equals(false) && !password.Equals(false))
            {
                foreach (char c in password)
                {
                    if (c >= 48 && c <= 58)
                    {
                        foreach (char d in password)
                        {
                            if (d >= 65 && d <= 90)
                            {
                                foreach (char e in password)
                                {
                                    if (e >= 97 && e <= 122)
                                    {
                                        foreach (char f in password)
                                        {
                                            if (f == '@' || f == '#' || f == '$' || f == '&' || f == '*')
                                            {
                                                App.Current.MainPage.Navigation.PushAsync(new LoginPage());
                                                return;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
            else
            {
                valOpacity = 0.5;
                enableLogin = false;
            }*/
        }
        private void SignUp()
        {
            App.Current.MainPage.Navigation.PushAsync(new View.SignUpPage());
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

