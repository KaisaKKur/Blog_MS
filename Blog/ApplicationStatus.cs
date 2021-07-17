using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog {
    public enum ApplicationProcess : UInt16 {
        MainForm,
        Login,
        Signup,
        Signout,
        AdminChat,
        Idle
    }

    public static class ApplicationStatus {
        private static ApplicationProcess _applicationProcess = ApplicationProcess.Idle;

        /* Property
         */
        public static ApplicationProcess ApplicationProcess {
            get => _applicationProcess;
            set => _applicationProcess = value;
        }
    }
}
