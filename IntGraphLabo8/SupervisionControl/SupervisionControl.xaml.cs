using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace UserControls
{
    /// <summary>
    /// Interaction logic for SupervisionControl.xaml
    /// </summary>
    public partial class SupervisionControl : UserControl
    {
        private bool _startEnable;
        public SupervisionControl()
        {
            InitializeComponent();

            DependencyPropertyDescriptor SupervisionControlDescriptor =
                DependencyPropertyDescriptor.FromProperty(
                    SupervisionControl.StatusProprety,
                    typeof(SupervisionControl));
            SupervisionControlDescriptor.AddValueChanged(this, StatusChanged);
        }

        public event EventHandler EventStatusChanged;

        protected virtual void OnStatusChanged()
        {
            if (EventStatusChanged != null)
                EventStatusChanged(this, new EventArgs());
        }

        private void StatusChanged(object sender, EventArgs e)
        {
            TextBlockStatus.Text = Status;
            OnStatusChanged();
        }

        public static readonly DependencyProperty StatusProprety = DependencyProperty.Register(
            nameof(Status), typeof(string), typeof(SupervisionControl));

        public string Status
        {
            get { return (string)GetValue(StatusProprety); }
            set { SetValue(StatusProprety, value); }
        }

        public bool StartEnable
        {
            get
            {
                return _startEnable;
            }
            set
            {
                if (_startEnable = value)
                    StartButton.Visibility = Visibility.Visible;
                else
                    StartButton.Visibility = Visibility.Hidden;
            }
        }
    }
}
