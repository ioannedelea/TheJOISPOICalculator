using System.Diagnostics;
using System.Reflection.Emit;
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

            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);

            lblSuccess1.Visible = false;
            
   

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

            textBox1.SelectAll();
            textBox1.Focus();

            Clipboard.SetText(textBox1.Text);

            lblSuccess2.Visible = true;
            System.Threading.Tasks.Task.Delay(1000).ContinueWith(_ =>
            {
                Invoke(new MethodInvoker(() => { lblSuccess2.Visible = false; }));
            });


        }

        private void sharpClipboard1_ClipboardChanged(object sender, WK.Libraries.SharpClipboardNS.SharpClipboard.ClipboardChangedEventArgs e)
        {


            if (!lstSelectedPlayers.Items.Contains(sharpClipboard1.ClipboardText.Trim()) && e.ContentType == SharpClipboard.ContentTypes.Text && IsValidSpecPlayer(sharpClipboard1.ClipboardText.Trim()))
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


        private bool IsValidSpecPlayer(string input)
        {
            string pattern = @"^spec_player \d+$";
            return Regex.IsMatch(input, pattern);
        }

        private void UpdateButtonState()
        {
            bool listBoxEmpty = lstSelectedPlayers.Items.Count == 0;
            button1.Enabled = !listBoxEmpty;
            btnConvert.Enabled = !listBoxEmpty;
            btnDelSelected.Enabled = !listBoxEmpty;
        }

        private void btnDelSelected_Click(object sender, EventArgs e)
        {
            if (lstSelectedPlayers.SelectedItem != null)
            {
                lstSelectedPlayers.Items.Remove(lstSelectedPlayers.SelectedItem);
                lstSelectedPlayers.SelectedIndex = lstSelectedPlayers.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("No item selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopyInitialCMDS_Click(object sender, EventArgs e)
        {

            lblSuccess1.Visible = true;
            System.Threading.Tasks.Task.Delay(1000).ContinueWith(_ =>
            {
                Invoke(new MethodInvoker(() => { lblSuccess1.Visible = false; }));
            });


            txtInitialCMDS.SelectAll();
            txtInitialCMDS.Focus();
            Clipboard.SetText(txtInitialCMDS.Text);
        }

        private void lnkDiscord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://discord.gg/uwh3KMERQW") { UseShellExecute = true });

            //System.Diagnostics.Process.Start("https://discord.gg/uwh3KMERQW");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.youtube.com/joispoi24?sub_confirmation=1") { UseShellExecute = true });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.instagram.com/joispoi24/") { UseShellExecute = true });
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(fileName: "https://www.twitch.tv/joispoi24") { UseShellExecute = true });

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(fileName: "https://x.com/JOISPOI24") { UseShellExecute = true });

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(fileName: "https://www.tiktok.com/@joispoi24") { UseShellExecute = true });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSuccess1.Visible = false;
        }
    }
}
