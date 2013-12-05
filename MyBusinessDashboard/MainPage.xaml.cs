using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MyBusinessDashboard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            
            this.InitializeComponent();
            TextBox userID = (TextBox)this.UserBox;
            string Password;
            Button Login;
            Login = LoginBtn;
            Login.Click += Login_Click;
            userID.Text = "Username";
            double scrnWidth = Width;
            userID.Text = scrnWidth.ToString();
            Password = PassBox.Password;
            RegisterBtn.PointerReleased += registerBtn_OnClick;
            
        }

        private void registerBtn_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Register));
        }
        
        void Login_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();

            TextBox User = (TextBox)UserBox;
            this.Frame.Navigate(typeof(ApplicationHome));

        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

    }
}
