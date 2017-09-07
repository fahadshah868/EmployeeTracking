using EmpTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmpTrack.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }
        public MasterPage()
        {
            InitializeComponent();
            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "My Profile",
                TargetType = typeof(Profile.UserProfilePage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Employee Profile",
                TargetType = typeof(Profile.User3ProfilePage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Privacy Policy",
                TargetType = typeof(PrivacyPolicy.PrivacyPolicyPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Terms Of Use",
                TargetType = typeof(TermsOfUse.TermsOfUsePage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Data Usage Policy",
                TargetType = typeof(DataUsagePolicy.DataUsagePolicyPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "About Us",
                TargetType = typeof(AboutUs.AboutUsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Contact Us",
                TargetType = typeof(ContactUs.ContactUsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Settings",
                TargetType = typeof(Settings.UserSettingsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Usage",
                TargetType = typeof(Usage.UsagePage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "News",
                TargetType = typeof(News.NewsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Notifications",
                TargetType = typeof(Notifications.NotificationsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Logout",
                TargetType = typeof(Logout.LogoutPage)
            });

            listView.ItemsSource = masterPageItems;
        }
    }
}