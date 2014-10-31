using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using EV3MessengerLib;

namespace sWasteController
{
    public partial class MainForm : Form
    {
        private const string LogicBox = "LogicBox";
        private readonly EV3Messenger _messenger = new EV3Messenger();


        public MainForm()
        {
            InitializeComponent();

            //Initialize the ComboBox with all the SerialPorts of this PC
            cbSerialPorts.TextChanged += (sender, e) => bConnect.Text = "Verbind met " + cbSerialPorts.Text;
            cbSerialPorts.Items.AddRange(SerialPort.GetPortNames());
            if (cbSerialPorts.Items.Count > 0) cbSerialPorts.SelectedIndex = 0;
        }


        // Updates the UI
        public bool Connected
        {
            get { return _messenger.IsConnected; }
            set
            {
                tslConnected.ForeColor = value ? Color.Green : Color.Red;
                tslConnected.Text = value ? String.Format("Verbonden met {0}", _messenger.Port) : "Niet Verbonden";
                gbControls.Enabled = value;
                bConnect.Enabled = !value;
                bDisconnect.Enabled = value;

                tReceiveMessages.Enabled = value;
            }
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            if (_messenger.Connect(cbSerialPorts.Text)) Connected = true;
            else
            {
                MessageBox.Show(
                    String.Format(
                        "Kon geen verbinding maken met een EV3 op poort {0}\nWeet je zeker dat de verbinding goed ingesteld is?",
                        cbSerialPorts.Text), "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bDisconnect_Click(object sender, EventArgs e)
        {
            _messenger.Disconnect();
            Connected = false;
        }

        private void bStartStop_Click(object sender, EventArgs e)
        {
            bool start = sender == bStart;
            _messenger.SendMessage(LogicBox, start);
        }

        private void tReceiveMessages_Tick(object sender, EventArgs e)
        {
            if (Connected)
            {
                EV3Message message = _messenger.ReadMessage();
                if (message != null) lbLogs.Items.Add(String.Format("{0}: {1}", message.MailboxTitle, message.ValueAsText));
            }
            else Connected = false;
        }
    }
}