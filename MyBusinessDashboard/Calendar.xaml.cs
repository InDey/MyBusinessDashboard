using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace MyBusinessDashboard
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Calendar : MyBusinessDashboard.Common.LayoutAwarePage
    {
        //Create global string array of months for referance
        String[] months = new String[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        DateTime curMonth = DateTime.Now;
        Int32 yearOfMonth = DateTime.Now.Year;

        public Calendar()
        {

            this.InitializeComponent();

            //Call method to populate calendar
            MonthBlock.Text = months[curMonth.Month - 1].ToString();
            createCalendarGrid();
            populateCalendar();
            
            //Call EventHandlers to change selected month
            BackMonthBtn.Click += backMonthBtn_OnClick;
            NextMonthBtn.Click += nextMonthBtn_OnClick;
        
        }
        private void nextMonthBtn_OnClick(object sender, RoutedEventArgs e)
        {
            //Take currently selected month and get proceeding month
            String selectedMonth = MonthBlock.Text;
            Int32 monthArrayPlace = Array.IndexOf(months, selectedMonth);
            if (monthArrayPlace == 11)
            {
                monthArrayPlace = -1;
                yearOfMonth = yearOfMonth + 1; //Move forward to next year if Dec - Jan
            }
            String nextMonth = months.GetValue(monthArrayPlace + 1).ToString();
            MonthBlock.Text = nextMonth;
        }
        private void backMonthBtn_OnClick(object sender, RoutedEventArgs e)
        {
            //Take currently selected month and get preceeding month
            String selectedMonth = MonthBlock.Text;
            Int32 monthArrayPlace = Array.IndexOf(months, selectedMonth);
            if (monthArrayPlace == 0)
            {
                monthArrayPlace = 12;
                yearOfMonth = yearOfMonth - 1; //Move back to previous year if Jan - Dec
            }
            String lastMonth = months.GetValue(monthArrayPlace - 1).ToString();
            MonthBlock.Text = lastMonth;
        }
        private void createCalendarGrid()
        {
            
        }
        private void populateCalendar()
        {
            //Get number of days in selected month relative to current year
            Int32 selectedMonth = Array.IndexOf(months, MonthBlock.Text);
            Int32 daysInMonth = DateTime.DaysInMonth(yearOfMonth, selectedMonth);

            //Iterate through daysOfMonth, do necessary actions
            for (int i = 1; i < daysInMonth; i++)
            {
                

            }
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
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }
    }
}
