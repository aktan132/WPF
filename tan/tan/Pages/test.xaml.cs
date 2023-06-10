using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Threading;


namespace tan.Pages
{


    public partial class test : Page
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3 };

        DispatcherTimer _timer;
        TimeSpan _time;

        int qNum = 0;
        int i, score;

        public object v { get;  set; }

        public test()
        {
            InitializeComponent();
            _time = TimeSpan.FromSeconds(300);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tbTime.Text = _time.ToString("c");
                if (_time == TimeSpan.Zero) NavigationService.Navigate(new menutest());  
                _time = _time.Add(TimeSpan.FromSeconds(-1));
                
            }, Application.Current.Dispatcher);

            _timer.Start();
            
            NextQuestion();
        }
   
        private void checkAnswer(object sender, RoutedEventArgs e)
        {


            Button senderButton = sender as Button; 

            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }
         
            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                
                qNum++;
            }

          
            scoreText.Content = "Cчет :" + score + "/" + questionNumbers.Count;

            if (qNum >= 3)
               
            {
                _timer.Stop();
               
                MessageBox.Show("Cчет :" + score + "/" + questionNumbers.Count);
                v = "Cчет :" + score + "/" + questionNumbers.Count;
                new sorce();
                NavigationService.Navigate (new menutest());

                App.Current.Resources["sor"] = v;
               
               


            }
            
            NextQuestion();

        }
  


        private void RestartGame()
        {
    
            score = 0; 
            qNum = -1; 
            i = 0; 

        }

        private void NextQuestion()
        {
            

            if (qNum < questionNumbers.Count) 
            {
                i = questionNumbers[qNum];
            }
            else
            {
              
                RestartGame();
            }

          
            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DeepSkyBlue;
            }


            switch (i)
            {
                case 1:

                    txtQuestion.Text = "В сетевой модели не должно быть:";
                    ans1.Content = "В сетевой модели не должно быть:"; 
                    ans2.Content = "Собственных векторов";
                    ans3.Content = "Седловых точек";
                    ans4.Content = "Не знаю";
                    ans2.Tag = "1"; 
                                   
                                   
                    break;

                case 2:

                    txtQuestion.Text = "Критическим путем в сетевом графике называется:";
                    ans1.Content = "Самый короткий путь";
                    ans2.Content = "Самый длинный путь";
                    ans3.Content = "Замкнутый путь";
                    ans4.Content = "Не знаю";
                    ans1.Tag = "1";
                    break;

                case 3:

                    txtQuestion.Text = "Математической основой методов сетевого планирования является:";
                    ans1.Content = "Аналитическая геометрия";
                    ans2.Content = "Теория электрических цепей";
                    ans3.Content = "Теория графов";
                    ans4.Content = "Незнаю";
                    ans3.Tag = "1";
                    break;

             

            }
        }
    }
}
