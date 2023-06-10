using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using tan.Pages;

namespace tan.views
{
    /// <summary>
    /// Логика взаимодействия для animeloading.xaml
    /// </summary>
    public partial class animeloading : Window
    {
        BackgroundWorker worker;
        public animeloading(string login, string password)
        {
          

            InitializeComponent();
            losa.Content = login;
            pas.Content = password;
            MyProgressBar.Visibility = Visibility.Visible; //Make Progressbar visible
            MyProgressLabel.Visibility = Visibility.Visible; //Make TextBlock visible

            worker = new BackgroundWorker(); //Initializing the worker object
            worker.ProgressChanged += Worker_ProgressChanged; //Binding Worker_ProgressChanged method
            worker.DoWork += Worker_DoWork; //Binding Worker_DoWork method
            worker.WorkerReportsProgress = true; //telling the worker that it supports reporting progress
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted; //Binding worker_RunWorkerCompleted method
            worker.RunWorkerAsync(); //Executing the worker
        }

        

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            long sum = 0;
            long total = 100000;
            for (long i = 1; i <= total; i++)
            {
                sum += i;
                int percentage = Convert.ToInt32(((double)i / total) * 100);

                Dispatcher.Invoke(new System.Action(() =>
                {
                    worker.ReportProgress(percentage);

                }));

            }



        }

        void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            MyProgressBar.Value = e.ProgressPercentage;
        }
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MyProgressBar.Visibility = Visibility.Collapsed;
            MyProgressLabel.Visibility = Visibility.Collapsed;

           string login = (string)losa.Content;
            string password = (string)pas.Content;
            Thisismail taskWindow = new Thisismail(login,password);

                            taskWindow.Show();
                            this.Close();
        }

    }
}
