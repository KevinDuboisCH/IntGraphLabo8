using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls
{
    public enum Profile { Operator = 0, Manager, Administrator };

    public class User
    {
        public User()
        {
            _passwords = new Dictionary<Profile, string>();

            foreach (Profile item in Enum.GetValues(typeof(Profile)))
            {
                _passwords.Add(item, item.ToString());
            }
            _currentProfile = Profile.Operator;
            _isConnected = false;
        }
        
        

        private Dictionary<Profile, string> _passwords;
        public Dictionary<Profile, string> Passwords
        {
            get
            {
                return _passwords;
            }
            set
            {
                if(value != _passwords)
                {
                    _passwords = value;
                }
            }
        }

        #region CurrentProfile
        private Profile _currentProfile;
        public Profile CurrentProfile
        {
            get
            {
                return _currentProfile;
            }
        }
        #endregion


        #region IsConnected
        private bool _isConnected;
        public bool IsConnected
        {
            get
            {
                return _isConnected;
            }
        }
        #endregion

        
        public bool TryConnection(Profile profile, string password)
        {
            if (_passwords.ContainsKey(profile))
            {
                _isConnected = true;
                _currentProfile = profile;
                return _passwords[profile] == password;
            }

            return false;
        }
    }
}
