using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Threading;

namespace UserControls
{
    class MainPageViewModel : BindableBase
    {
        public MainPageViewModel()
        {

            for (int i = 0; i < 60; i++)
            {
                var second = new Item
                {
                    Text = i.ToString(),
                    Angle = i * (360 / 60)
                };
                this.SecondTicks.Add(second);
            }

            for (int i = 0; i < 12; i++)
            {
                var hour = new Item
                {
                    Text = (i == 0) ? "12" : i.ToString(),
                    Angle = i * (360 / 12)
                };
                this.HoursTicks.Add(hour);
            }
        }

        ObservableCollection<Item> _SecondTicks = new ObservableCollection<Item>();
        public ObservableCollection<Item> SecondTicks { get { return _SecondTicks; } }

        ObservableCollection<Item> _HoursTicks = new ObservableCollection<Item>();
        public ObservableCollection<Item> HoursTicks { get { return _HoursTicks; } }

    }
    /// <summary>
    /// Interaction logic for Clock.xaml
    /// </summary>
    public partial class Clock : UserControl
    {
        System.Timers.Timer timer = new System.Timers.Timer(100);
         public Clock()
         {
             InitializeComponent();


             DateTime date = DateTime.Now;
             TimeZone time = TimeZone.CurrentTimeZone;
             TimeSpan difference = time.GetUtcOffset(date);

             timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
             timer.Enabled = true;

         }



        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
         {
             Dispatcher.Invoke(DispatcherPriority.Normal, (Action)(() =>
             {
                 second.Angle = DateTime.Now.Second * (360 / 60);
                 minute.Angle = DateTime.Now.Minute * (360 / 60);
                 hour.Angle = (DateTime.Now.Hour * (360 / 12));
             }));
         }

    }
}
