using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WSRKart
{
    /// <summary>
    /// Логика взаимодействия для Sample.xaml
    /// </summary>
    public partial class Sample : UserControl
    {
        DispatcherTimer timerToStartKart = new DispatcherTimer();
        DateTime startDate = Convert.ToDateTime("20.06.2022 00:00:00");
        TimeSpan ToEnd;
        public Sample()
        {
            InitializeComponent();
            timerToStartKart.Interval = TimeSpan.FromMilliseconds(1);
            timerToStartKart.Tick += Tick;
            timerToStartKart.Start();
        }

        private void Tick(object sender, EventArgs e)
        {
            Task.Factory.StartNew(async () =>
            {
                await Application.Current.Dispatcher.InvokeAsync(() =>
                {
                    if (DateTime.Now < startDate)
                    {
                        ToEnd = startDate - DateTime.Now;
                        DateTime aboba = DateTime.MinValue + ToEnd;
                        TimerToStart.Text = ($"До начала события осталось {aboba.Year - 1} лет, {aboba.Month - 1} месяцев, {aboba.Day - 1} дней, {aboba.Hour} часов, {aboba.Minute} минут и {aboba.Second} секунд.");
                    }
                });
            });
            
            
            

        }


    }
}
