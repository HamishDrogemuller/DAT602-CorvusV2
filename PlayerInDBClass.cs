using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorvusV2
{
    public class PlayerInDB
    {
        private string _username;
        private string _password;
        private string _email;
        private int _score;
        private int _highScore;
        private bool _admin;
        private int _loginAttempt;
        private bool _lockedUser;
        private bool _online;

        public string Username { get { return _username; } set { _username = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public int Score { get { return _score; } set { _score = value; } }
        public int HighScore { get { return _highScore; } set { _highScore = value; } }
        public bool Admin { get { return _admin; } set { _admin = value; } }
        public int LoginAttempt { get { return _loginAttempt; } set { _loginAttempt = value; } }
        public bool LockedUser { get { return _lockedUser; } set { _lockedUser = value; } }
        public bool online { get { return _online; } set { _online = value; } }

    }
}
