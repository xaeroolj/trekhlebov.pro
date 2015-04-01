using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Statistic
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            
            

            Stat_service.TestServiceClient proxy = new Stat_service.TestServiceClient();
            proxy.sqlTestCompleted += proxy_sqlTestCompleted;
            proxy.sqlTestAsync();


        }

        void proxy_sqlTestCompleted(object sender, Stat_service.sqlTestCompletedEventArgs e)
        {
            ObservableCollection<Stat_service.TestServicedbItemss> custdata = e.Result;
            testDG.DataContext = custdata;
            
        }
        /*
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Stat_service.TestServiceClient proxy = new Stat_service.TestServiceClient();
            //proxy.addCHGAsync("04.01.2015 20:19:35 SDM9999 ROMAN");
        }
        */
        
    }
}
