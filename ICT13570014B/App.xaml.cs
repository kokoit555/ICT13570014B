﻿using Xamarin.Forms;

namespace ICT13570014B
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var tp = new TabbedPage();
            tp.Children.Add(new TabPage1());
            tp.Children.Add(new TabPage2());
            tp.Children.Add(new TabPage3());

            var cp = new CarouselPage();
            cp.Children.Add(new TabPage1());
            cp.Children.Add(new TabPage2());
            cp.Children.Add(new TabPage3());


            var mp = new MasterDetailPage();
                mp.Master = new MenuPage();
            mp.Detail = new NavigationPage(new ICT13570014BPage());
            

            MainPage = mp;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
