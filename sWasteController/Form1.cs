using System;
using System.Drawing;
using System.IO.Ports;
using System.Speech.Synthesis;
using System.Windows.Forms;
using EV3MessengerLib;

namespace sWasteController
{
    public partial class MainForm : Form
    {
        private const string LogicBox = "LogicBox";
        private readonly EV3Messenger _messenger = new EV3Messenger();
        private readonly SpeechSynthesizer _synthesizer = new SpeechSynthesizer();
        private int _black;
        private int _red;
        private int _white;


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

        public int Red
        {
            get { return _red; }
            set
            {
                _red = value;
                tsslRed.Text = "Rood: " + _red;
            }
        }

        public int Black
        {
            get { return _black; }
            set
            {
                _black = value;
                tsslBlack.Text = "Zwart: " + _black;
            }
        }

        public int White
        {
            get { return _white; }
            set
            {
                _white = value;
                tsslWhite.Text = "Wit: " + _white;
            }
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            if (_messenger.Connect(cbSerialPorts.Text)) Connected = true;
            else
            {
                MessageBox.Show(String.Format(
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
                if (message == null) return;

                switch (message.MailboxTitle)
                {
                    case "Color":
                        HandleColorUpdate((Colors)message.ValueAsNumber);
                        break;

                    default:
                        lbLogs.Items.Add(string.Format("[{0}] {1}", DateTime.Now.ToShortTimeString(),
                            message.ValueAsText));
                        _synthesizer.SpeakAsync(message.ValueAsText);
                        break;
                }
            }
            else Connected = false;
        }

        private void HandleColorUpdate(Colors color)
        {
            _synthesizer.SpeakAsync(color + " detected");
            switch (color)
            {
                case Colors.Red:
                    Red++;
                    break;
                case Colors.Black:
                    Black++;
                    break;
                default:
                    White++;
                    break;
            }
        }

        private enum Colors
        {
            Default,
            Black,
            Blue,
            Green,
            Yellow,
            Red,
            White,
            Brown
        }
    }
}