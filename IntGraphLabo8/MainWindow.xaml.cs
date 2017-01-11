using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using UserControls;

//Salut Poilu;
namespace IntGraphLabo8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            System.Timers.Timer timer = new System.Timers.Timer(100);


            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.Enabled = true;

            InitializeComponent();
            _machineApplication = new MachineApplication();
            _homePage = new HomePage(_machineApplication);
        }

        private MachineApplication _machineApplication;

        #region Variable Content User Controls
        private HomePage _homePage;
        private ConfigSheet _configSheet;
        #endregion

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Normal, (Action)(() =>
            {
                StateUpdate();
            }));
        }

        private void Configuration_Click(object sender, RoutedEventArgs e)
        {
            //ConfigSheet.Visibility = Visibility.Visible;
            //HomePage.Visibility = Visibility.Hidden;
            SupervisionControl.StartEnable = false;
        }

        private void Accueil_Click(object sender, RoutedEventArgs e)
        {
            //ConfigSheet.Visibility = Visibility.Hidden;
            //HomePage.Visibility = Visibility.Visible;
            AreaVariableContent.Children.Clear();
            AreaVariableContent.Children.Add(_homePage);
            SupervisionControl.StartEnable = true;
            SupervisionControl.Status = "test";
        }

        private void StateUpdate()
        {
            if(_homePage.IsConnected)
                switch (_homePage.CurrentProfile)
                {
                    case Profile.Operator:
                        OperatorImage.Visibility = Visibility.Visible;
                        break;
                    case Profile.Manager:
                        ManagerImage.Visibility = Visibility.Visible;
                        break;
                    case Profile.Administrator:
                        AdministratorImage.Visibility = Visibility.Visible;
                        break;
                    default:
                        break;
                }
            else
            {
                AdministratorImage.Visibility = Visibility.Hidden;
                OperatorImage.Visibility = Visibility.Hidden;
                ManagerImage.Visibility = Visibility.Hidden;
            }
        }
    }
}
