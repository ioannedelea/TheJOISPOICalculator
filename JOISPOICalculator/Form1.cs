using System.Text.RegularExpressions;
using System.Windows.Forms;
using WK.Libraries.SharpClipboardNS;

namespace JOISPOICalculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            Clipboard.Clear();
            lstSelectedPlayers.SelectedIndexChanged += lstSelectedPlayers_SelectedIndexChanged;

            // Initialize the state of the button
            UpdateButtonState();
        }

        List<string> players = new List<string>();
        List<int> indexes = new List<int>();

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (lstSelectedPlayers.Items.Count == 0)
            {
                MessageBox.Show("List of players is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }

            foreach (string player in players)
            {
                indexes.Add(Int32.Parse(Regex.Match(player, @"\d+").Value));
            }

            int[] playersIdsArr = indexes.ToArray();

            int binaryResult = 0;

            foreach (int number in playersIdsArr)
            {
                binaryResult |= (1 << (number - 1));
            }

            //string binaryString = Convert.ToString(binaryResult, 2).PadLeft(32, '0');

            //MessageBox.Show("Decimal representation: " + binaryResult.ToString());

            string cscmds = "tv_listen_voice_indices_h " + binaryResult.ToString() + ";" + "tv_listen_voice_indices " + binaryResult.ToString();

            textBox1.Text = cscmds;
            Clipboard.SetText(textBox1.Text);

        }

        private void sharpClipboard1_ClipboardChanged(object sender, WK.Libraries.SharpClipboardNS.SharpClipboard.ClipboardChangedEventArgs e)
        {
            if (e.ContentType == SharpClipboard.ContentTypes.Text && sharpClipboard1.ClipboardText.Trim().StartsWith("spec_player"))
            {
                string playersIds = Regex.Match(sharpClipboard1.ClipboardText, @"\d+").Value;
                lstSelectedPlayers.Items.Add(sharpClipboard1.ClipboardText.Trim());
                players = lstSelectedPlayers.Items.Cast<String>().ToList();
                lstSelectedPlayers.SelectedIndex = lstSelectedPlayers.Items.Count - 1;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstSelectedPlayers.Items.Clear();
            textBox1.Text = "";
            Clipboard.Clear();
            UpdateButtonState();
        }

        private void lstSelectedPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonState();
        }


        private void UpdateButtonState()
        {
            bool listBoxEmpty = lstSelectedPlayers.Items.Count == 0;
            button1.Enabled = !listBoxEmpty;
            btnConvert.Enabled = !listBoxEmpty;
        }
    }
}
