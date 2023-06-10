using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Threading;
using tan.Model;

namespace tan.Pages
{
    /// <summary>
    /// Логика взаимодействия для test2.xaml
    /// </summary>
    public partial class test2 : Page
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3,4 };

        DispatcherTimer _timer;
        TimeSpan _time;

        int qNum = 0;
        int i, score;

        private ObservableCollection<sourcetest> souce;
        public test2()
        {
            InitializeComponent();
            InitializeComponent();
            souce= new ObservableCollection<sourcetest>()
            {
            
          
        };
          
            _time = TimeSpan.FromSeconds(180);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tbTime.Text = _time.ToString("c");
                if (_time == TimeSpan.Zero) NavigationService.Navigate(new menutest());
                _time = _time.Add(TimeSpan.FromSeconds(-1));

            }, Application.Current.Dispatcher);

            _timer.Start();

            NextQuestion();
        }
        public object v { get; set; }
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

            if (qNum >= 4)

            {
                _timer.Stop();
                MessageBox.Show("Cчет :" + score + "/" + questionNumbers.Count);
                NavigationService.Navigate(new menutest());
                v = "Cчет :" + score + "/" + questionNumbers.Count;
                App.Current.Resources["sor2"] = v;
            }
            new sourcetest() { Sorce = ("Cчет :" + score + "/" + questionNumbers.Count) };

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

                    txtQuestion.Text = "Основные шаги процесса сетевого планирования?:";
                    ans1.Content = "Определение целей и задач, распределение ресурсов:";
                    ans2.Content = "Распределение ресурсов";
                    ans3.Content = "Определение сроков";
                    ans4.Content = "Нет правильного ответа";
                    ans1.Tag = "1";


                    break;

                case 2:

                    txtQuestion.Text = "Основными элементами СГ являются::";
                    ans1.Content = "Cабота,событие,путь";
                    ans2.Content = "Cобытие,путь";
                    ans3.Content = "Замкнутый путь";
                    ans4.Content = "Нет правильного ответа";
                    ans1.Tag = "1";
                    break;

                case 3:

                    txtQuestion.Text = "Работа?";
                    ans1.Content = "Процесс или действие, приводящее к результату.";
                    ans2.Content = "Выполенение какого либо действия";
                    ans3.Content = "Теория графов";
                    ans4.Content = "Нет правильного ответа";
                    ans1.Tag = "1";
                    break;

                case 4:

                    txtQuestion.Text = "Существует три вида работ:";
                    ans1.Content = "действительная,работа-ожидание,фиктивная – логическая:";
                    ans2.Content = "фиктивная, логическая,ожидание";
                    ans3.Content = "Седловая, логическая,работа ERS";
                    ans4.Content = "Нет правильного ответа";
                    ans1.Tag = "1";


                    break;


            }
        }
    }
}
