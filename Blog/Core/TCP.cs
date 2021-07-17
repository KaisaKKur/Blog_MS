using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blog.Core {
    class TCP {
        TcpListener _listener;
        TcpClient _client;

        public delegate void ReceivedMessage(TCP TCP, string receivedMessage);
        public event ReceivedMessage onReceivedMessage;

        /* Property
         */
        public TcpListener Listener {
            get => _listener;
            set => _listener = value;
        }

        public TcpClient Client {
            get => _client;
            set => _client = value;
        }

        public TCP() {
            _listener = new TcpListener(IPAddress.Loopback, 9309);
            _listener.Start();
        }

        public void destroy() {
            try {
                if (_client != null) {
                    if (_client.Connected) {
                        _client.Close();
                    }
                }
                if (_listener != null) {
                    _listener.Stop();
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message, "TCP: destroy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void server() {
            try {
                TcpClient remoteClient = _listener.AcceptTcpClient();

                while (true) {
                    NetworkStream clientStream = remoteClient.GetStream();
                    BinaryReader BR = new BinaryReader(clientStream);
                    string receivedMessage = BR.ReadString();
                    onReceivedMessage(this, receivedMessage);
                }
            } catch (SocketException se) {
                MessageBox.Show(se.Message, "TCP: server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception) {
            }
        }

        public void client() {
            try {
                while (_client == null) {
                    try {
                        _client = new TcpClient(IPAddress.Loopback.ToString(), 9308);
                    } catch (SocketException) {
                    }
                }
            } catch (Exception) {
            }
        }

        public void sendString(string message) {
            try {
                if (_client != null) {
                    NetworkStream clientStream = _client.GetStream();
                    BinaryWriter BW = new BinaryWriter(clientStream);
                    BW.Write(message);
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message, "TCP: sendString", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
