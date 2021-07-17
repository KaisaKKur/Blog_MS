using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog {
    public enum ApplicationWorkProcess : UInt16 {
        Home,
        Profile,
        Editor,
        Signout,
        ArchiveListByDate,
        Idle
    }

    static class ApplicationWorkStatus {
        private static ApplicationWorkProcess _applicationWorkProcess = ApplicationWorkProcess.Idle;

        /* Property
         */
        public static ApplicationWorkProcess ApplicationWorkProcess {
            get => _applicationWorkProcess;
            set => _applicationWorkProcess = value;
        }
    }
}
