using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Globalization;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Items Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234233

namespace MyBusinessDashboard
{
    /// <summary>
    /// A page that displays a collection of item previews.  In the Split Application this page
    /// is used to display and select one of the available groups.
    /// </summary>
    public sealed partial class ApplicationHome : MyBusinessDashboard.Common.LayoutAwarePage
    {
        public ApplicationHome()
        {
            this.InitializeComponent();

            //Add all button event handlers
            ContactBtn.Click += ContactBtn_OnClick;
            CalendarBtn.Click += CalendarBtn_OnClick;
            FileBtn.Click += FileBtn_OnClick;
            NewsBtn.Click += NewsBtn_OnClick;
            EmailBtn.Click += EmailBtn_OnClick;
            SettingsBtn.Click += SettingsBtn_OnClick;

            //Add all tab event handlers
            NewsFeedCNTab.Click += CompanyNews_OnClick;
            NewsFeedChatTab.Click += Chat_OnClick;
            NewsFeedEventsTab.Click += EventList_OnClick;

            //Create ticker to refresh DateTime. 
            //Will call method to refresh 10 times every 100 milliseconds
            DispatcherTimer dT = new DispatcherTimer();
            dT.Interval = new TimeSpan(10);
            dT.Start();
            dT.Tick += setInternalClock;
                
        }

        private void setInternalClock(object sender, object e)
        {
            //Create calendar object to get current day & time
            Calendar calendar = new Calendar();
            curDatetb.Text = calendar.DayOfWeekAsString() + " " + DateTime.Now.ToString("hh:mm:ss tt");
        }
        private void ContactBtn_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Contacts));
        }
        private void CalendarBtn_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CreateCalendar));
        }
        private void FileBtn_OnClick(object sender, RoutedEventArgs e)
        {

        }
        private void NewsBtn_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NewsHome));
        }
        private void EmailBtn_OnClick(object sender, RoutedEventArgs e)
        {

        }
        private void SettingsBtn_OnClick(object sender, RoutedEventArgs e)
        {

        }
        private void CompanyNews_OnClick(object sender, RoutedEventArgs e)
        {
            //Change border color on active tab
            NewsFeedCNTab.BorderBrush = new SolidColorBrush(Colors.MediumBlue);
            NewsFeedEventsTab.BorderBrush = null;
            NewsFeedChatTab.BorderBrush = null;
        }
        private void Chat_OnClick(object sender, RoutedEventArgs e)
        {
            //Change border color on active tab
            NewsFeedChatTab.BorderBrush = new SolidColorBrush(Colors.MediumBlue);
            NewsFeedEventsTab.BorderBrush = null;
            NewsFeedCNTab.BorderBrush = null;
        }
        private void EventList_OnClick(object sender, RoutedEventArgs e)
        {
            //Change border color on active tab
            NewsFeedEventsTab.BorderBrush = new SolidColorBrush(Colors.MediumBlue);
            NewsFeedCNTab.BorderBrush = null;
            NewsFeedChatTab.BorderBrush = null;
        }
        private void AddContact_Click(object sender, RoutedEventArgs e)
        {

        }
        private void OpenFileCloud_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Help_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Logout_Click(object sender, RoutedEventArgs e)
        {

        }
        private void InstantMessage_Click(object sender, RoutedEventArgs e)
        {

        }








        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            // TODO: Assign a bindable collection of items to this.DefaultViewModel["Items"]
        }
    }
}

