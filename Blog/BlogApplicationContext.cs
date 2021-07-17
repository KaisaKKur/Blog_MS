using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Syncfusion.WinForms.Controls;

using Blog.AdminGroup;

namespace Blog {
    internal enum FormName : UInt16 {
        MainForm,
        Login,
        Signup,
        AdminGroupChat,
        NULL
    }  

    public class BlogApplicationContext : ApplicationContext {
        private Dictionary<FormName, SfForm> _forms;
        private UInt16 _formCount;
        private ApplicationProcess _applicationProcess;
        private Timer _timer_applicationStatus;

        private event EventHandler _formCountChanged;

        /* Property
         */
        public UInt16 FormCount {
            get => _formCount;
            set {
                if (_formCount != value) {
                    _formCount = value;
                    _formCountChanged(this, EventArgs.Empty);
                }
            }
        }

        public BlogApplicationContext() {
            _forms = new Dictionary<FormName, SfForm>();

            _formCount = 0;
            _formCountChanged += onFormCountChanged;

            _applicationProcess = ApplicationProcess.Idle;

            _timer_applicationStatus = new Timer {
                Enabled = true,
                Interval = 1
            };
            _timer_applicationStatus.Tick += _timer_applicationStatus_Tick;

            ApplicationStatus.ApplicationProcess = ApplicationProcess.Login;
        }

        private void _timer_applicationStatus_Tick(object sender, EventArgs e) {
            if (_applicationProcess != ApplicationStatus.ApplicationProcess) {
                _applicationProcess = ApplicationStatus.ApplicationProcess;
                switchShowForm();
            }
        }

        private void onFormCountChanged(object sender, EventArgs e) {
            if (_formCount == 0) {
                Application.Exit();
            }
        }

        private void onFormClosed_FormClosed(object sender, FormClosedEventArgs e) {
            if (_applicationProcess != ApplicationStatus.ApplicationProcess) {
                _applicationProcess = ApplicationStatus.ApplicationProcess;
                switchShowForm();
            }

            FormCount--;
        }

        private void switchShowForm() {
            switch (_applicationProcess) {
                case ApplicationProcess.MainForm:
                    _forms[FormName.MainForm] = new MainForm();
                    _forms[FormName.MainForm].FormClosed += onFormClosed_FormClosed;
                    _forms[FormName.MainForm].Show();
                    _formCount++;
                    break;

                case ApplicationProcess.Login:
                    _forms[FormName.Login] = new Login();
                    _forms[FormName.Login].FormClosed += onFormClosed_FormClosed;
                    _forms[FormName.Login].Show();
                    _formCount++;
                    break;

                case ApplicationProcess.Signup:
                    _forms[FormName.Signup] = new Signup();
                    _forms[FormName.Signup].FormClosed += onFormClosed_FormClosed;
                    _forms[FormName.Signup].Show();
                    _formCount++;
                    break;

                case ApplicationProcess.Signout:
                    _forms[FormName.Login] = new Login();
                    _forms[FormName.Login].FormClosed += onFormClosed_FormClosed;
                    _forms[FormName.Login].Show();
                    _formCount++;
                    _forms[FormName.MainForm].Close();
                    break;

                case ApplicationProcess.AdminChat:
                    _forms[FormName.AdminGroupChat] = new Admin();
                    _forms[FormName.AdminGroupChat].FormClosed += onFormClosed_FormClosed;
                    _forms[FormName.AdminGroupChat].Show();
                    _formCount++;
                    _applicationProcess = ApplicationProcess.Idle;
                    ApplicationStatus.ApplicationProcess = ApplicationProcess.Idle;
                    break;

                default:
                    break;
            }
        }
    }
}
