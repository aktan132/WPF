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
    public partial class test3 : Page
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3,4,5 };

        DispatcherTimer _timer;
        TimeSpan _time;

        int qNum = 0;
        int i, score;

        private ObservableCollection<sourcetest> souce;
        public test3()
        {
            InitializeComponent();
            InitializeComponent();
            souce= new ObservableCollection<sourcetest>()
            {
            
          
        };
          
            _time = TimeSpan.FromSeconds(120);

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

            if (qNum >= 5)

            {
                _timer.Stop();
                MessageBox.Show("Cчет :" + score + "/" + questionNumbers.Count);
                NavigationService.Navigate(new menutest());
                v = "Cчет :" + score + "/" + questionNumbers.Count;
                App.Current.Resources["sor3"] = v;
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

                    txtQuestion.Text = "Какое понятие используется для описания наиболее ранней даты, на которую может быть завершен проект;";
                    ans1.Content = "Дата завершения проекта";
                    ans2.Content = "Дата начала проекта";
                    ans3.Content = "Критический путь";
                    ans4.Content = "Нет ответа";
                    ans1.Tag = "1";


                    break;

                case 2:

                    txtQuestion.Text = "Какой показатель используется для оценки продолжительности выполнения задачи:";
                    ans1.Content = "Продолжительность выполнения";
                    ans2.Content = "Задержка";
                    ans3.Content = "Издержки";
                    ans4.Content = "Коэффициент свершения";
                    ans1.Tag = "1";
                    break;

                case 3:

                    txtQuestion.Text = "Какие инструменты используются для управления рисками в проектной деятельности:";
                    ans1.Content = "Матрица управления рисками, Gantt-диаграмма ";
                    ans2.Content = "Разбор причин и последствий, график Ганта";
                    ans3.Content = "Планирование стратегии, календарь выполнения задач";
                    ans4.Content = "Анализ сценариев, диаграмма Перта";
                    ans2.Tag = "1";
                    break;

                case 4:

                    txtQuestion.Text = "Что такое управление изменениями в проектном менеджменте:";
                    ans1.Content = "Процесс, который управляет изменениями внутри организации";
                    ans2.Content = "Процесс, который минимизирует изменения в проекте ";
                    ans3.Content = "Процесс, который управляет изменениями в проекте";
                    ans4.Content = " Процесс, который управляет бюджетом проекта";
                    ans3.Tag = "1";


                    break;
                case 5:

                    txtQuestion.Text = "Что такое управление изменениями в проектном менеджменте:";
                    ans1.Content = "Процесс, который управляет изменениями внутри организации";
                    ans2.Content = "Процесс, который минимизирует изменения в проекте ";
                    ans3.Content = "Процесс, который управляет изменениями в проекте";
                    ans4.Content = " Процесс, который управляет бюджетом проекта";
                    ans3.Tag = "1";


                    break;


            }
        }
    }
}
