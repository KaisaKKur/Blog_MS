using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core {
    static class Account {
        private static UInt32 _ID = 0;
        private static string _username = string.Empty;
        private static string _nickname = string.Empty;

        /* Property
         */
        public static UInt32 ID {
            get => _ID;
            set => _ID = value;
        }

        public static string Username {
            get => _username;
            set => _username = value;
        }

        public static string Nickname {
            get => _nickname;
            set => _nickname = value;
        }
    }
}
