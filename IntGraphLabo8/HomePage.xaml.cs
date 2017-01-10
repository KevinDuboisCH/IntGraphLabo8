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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IntGraphLabo8
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();

            _user = new User();
            CurrentProfile = Profile.Operator;
            _isConnected = false;

            DependencyPropertyDescriptor descriptorCurrentProfile =
                DependencyPropertyDescriptor.FromProperty(
                    CurrentProfileProperty, typeof(HomePage));
            descriptorCurrentProfile.AddValueChanged(this, CurrentProfileChange);
        }



        #region Current Profile Dependency Property
        public Profile CurrentProfile
        {
            get { return (Profile)GetValue(CurrentProfileProperty); }
            set { SetValue(CurrentProfileProperty, value); }
        }

        public static readonly DependencyProperty CurrentProfileProperty =
            DependencyProperty.Register(nameof(CurrentProfile), typeof(Profile), typeof(HomePage), new UIPropertyMetadata(Profile.Operator));

        public event EventHandler CurrentProfileChanged;

        protected virtual void OnCurrentProfileChanged()
        {
            if (CurrentProfileChanged != null)
                CurrentProfileChanged(this, new EventArgs());
        }

        private void CurrentProfileChange(object sender, EventArgs e)
        {
            //switch (CurrentProfile)
            //{
            //    case Profile.Operator:
            //        ButtonOperator.Style = (Style)Application.Current.FindResource("ActivatedButton");
            //        break;
            //    case Profile.Manager:
            //        ButtonManager.Style = (Style)Application.Current.FindResource("ActivatedButton");
            //        break;
            //    case Profile.Administrator:
            //        ButtonAdministrator.Style = (Style)Application.Current.FindResource("ActivatedButton");
            //        break;
            //    default:
            //        break;
            //}
            OnCurrentProfileChanged();
        }

        //private void TextValue_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    //CurrentProfile = TextBoxValue.Text;
        //}

        #endregion

        private User _user;

        //private Profile _currentProfile;
        //public Profile CurrentProfile
        //{
        //    get
        //    {
        //        return _currentProfile;
        //    }
        //}

        private bool _isConnected;
        public bool IsConnected
        {
            get
            {
                return _isConnected;
            }
        }

        public event EventHandler OnConnected;

        public event EventHandler OnDeconnected;

        protected void ButtonOperator_Click(object sender, RoutedEventArgs e)
        {
            if(!IsConnected)
            {
                CurrentProfile = Profile.Operator;
            }
        }

        private void ButtonManager_Click(object sender, RoutedEventArgs e)
        {
            if (!IsConnected)
            {
                CurrentProfile = Profile.Manager;
            }
        }

        private void ButtonAdministrator_Click(object sender, RoutedEventArgs e)
        {
            if (!IsConnected)
            {
                CurrentProfile = Profile.Administrator;
            }
        }


        #region Connection management
        private void ButtonConnection_Click(object sender, RoutedEventArgs e)
        {
            if (!IsConnected)
            {
                if (_user.TryConnection(CurrentProfile, PasswordBoxProfile.Password))
                {
                    _isConnected = true;
                    TextBlockConnectionResult.Text = string.Empty;
                    if (OnConnected != null)
                        OnConnected(this, new EventArgs());
                    GroupBoxModifyPassword.Visibility = Visibility.Visible;
                }
                else
                {
                    TextBlockConnectionResult.Text = "Mot de passe incorrect";
                }
            }
        }

        private void ButtonDeconnection_Click(object sender, RoutedEventArgs e)
        {
            _isConnected = false;
            if (OnDeconnected != null)
                OnDeconnected(this, new EventArgs());
            GroupBoxModifyPassword.Visibility = Visibility.Hidden;
        }

        private void ButtonValidate_Click(object sender, RoutedEventArgs e)
        {
            if(IsConnected)
            {
                //_user.Passwords[CurrentProfile]
            }
        }

        #endregion
    }
}
