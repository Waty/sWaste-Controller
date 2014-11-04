using System;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
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
        private int _trashCount;

        /// <summary>
        ///     Initializes every control on the form
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            //Initialize the ComboBox with all the SerialPorts of this PC
            cbSerialPorts.TextChanged += (sender, e) => bConnect.Text = "Verbind met " + cbSerialPorts.Text;
            cbSerialPorts.Items.AddRange(SerialPort.GetPortNames());
            if (cbSerialPorts.Items.Count > 0) cbSerialPorts.SelectedIndex = 0;
        }

        /// <summary>
        ///     Gets the IsConnected state of the EV3Messenger
        /// </summary>
        public bool Connected
        {
            get { return _messenger.IsConnected; }
        }

        /// <summary>
        ///     Keeps track of the amount of trash currently sits in the depot
        /// </summary>
        public int TrashCount
        {
            get { return _trashCount; }
            set
            {
                _trashCount = value;
                lTotalCount.Text = value.ToString("G");
            }
        }

        /// <summary>
        ///     Updates the UI to reflect the connected state
        /// </summary>
        /// <param name="connected">If the UI should look connected or not</param>
        public void UpdateUi(bool connected)
        {
            tsslConnected.ForeColor = connected ? Color.Green : Color.Red;
            tsslConnected.Text = connected ? String.Format("Verbonden met {0}", _messenger.Port) : "Niet Verbonden";
            gbControls.Enabled = connected;
            bConnect.Enabled = !connected;
            bDisconnect.Enabled = connected;

            tReceiveMessages.Enabled = connected;
        }

        /// <summary>
        ///     Connects to the EV3 using the EV3Messenger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bConnect_Click(object sender, EventArgs e)
        {
            if (_messenger.Connect(cbSerialPorts.Text)) UpdateUi(true);
            else
            {
                MessageBox.Show(String.Format(
                    "Kon geen verbinding maken met een EV3 op poort {0}\nWeet je zeker dat de verbinding goed ingesteld is?",
                    cbSerialPorts.Text), "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Disconnects from the EV3 using the EV3Messenger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bDisconnect_Click(object sender, EventArgs e)
        {
            _messenger.Disconnect();
            UpdateUi(false);
        }

        /// <summary>
        ///     The eventhandler for the start and stop button, if the sender is the start button it sends tru to LogicBox else it
        ///     sends false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bStartStop_Click(object sender, EventArgs e)
        {
            bool start = sender == bStart;
            _messenger.SendMessage(LogicBox, start);
        }

        /// <summary>
        ///     Checks and handles new BT Messages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tReceiveMessages_Tick(object sender, EventArgs e)
        {
            if (Connected)
            {
                EV3Message message = _messenger.ReadMessage();
                if (message == null) return;

                switch (message.MailboxTitle)
                {
                    case "Color":
                        HandleColorUpdate((Colors) message.ValueAsNumber);
                        break;

                    default:
                        tsslStatus.Text = message.ValueAsText;
                        _synthesizer.SpeakAsync(message.ValueAsText);
                        break;
                }
            }
            else UpdateUi(false);
        }

        /// <summary>
        ///     Gets or creates the ListViewItem with the right color text
        /// </summary>
        /// <param name="color">The color that you want</param>
        /// <returns>A ListViewItem with 2 SubItems: Count and Name</returns>
        private ListViewItem GetListViewItem(Colors color)
        {
            return
                lvResults.Items.Cast<ListViewItem>().FirstOrDefault(item => item.SubItems[1].Text == ColorToText(color)) ??
                lvResults.Items.Add(new ListViewItem(new[] {"0", ColorToText(color)}));
        }

        /// <summary>
        ///     Increments the Count of the ListViewItem that has the same name as the color
        /// </summary>
        /// <param name="color">The color that needs to be incremented</param>
        private void HandleColorUpdate(Colors color)
        {
            ListViewItem listViewItem = GetListViewItem(color);
            int count;
            if (!Int32.TryParse(listViewItem.SubItems[0].Text, out count)) count = 0;
            listViewItem.SubItems[0].Text = (count + 1).ToString("G");

            TrashCount++;
            _synthesizer.SpeakAsync("Processing " + ColorToText(color));
            lvResults.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        /// <summary>
        ///     Returns the description of the specified color means
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        private static string ColorToText(Colors color)
        {
            switch (color)
            {
                case Colors.White:
                case Colors.Blue:
                    return "Liquid waste";

                case Colors.Red:
                    return "Explosive waste";

                default:
                    return "Nuclear waste";
            }
        }

        /// <summary>
        ///     Removes the selected items from the ListView and decreases TrashCount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiProcessWaste_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection items = lvResults.SelectedItems;
            if (items.Count <= 0) return;

            foreach (ListViewItem item in items)
            {
                int count = Int32.Parse(item.SubItems[0].Text);
                TrashCount -= count;
                lvResults.Items.Remove(item);
            }
        }

        /// <summary>
        ///     All the possible colors that the EV3 can detect
        /// </summary>
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