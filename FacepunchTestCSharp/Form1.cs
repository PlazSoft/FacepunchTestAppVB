using System;
using System.Windows.Forms;
using Steamworks.Ugc;


namespace FacepunchTestCSharp
{
    public partial class Form1 : Form
    {
        private PublishResult publishReasult;
        private Random theRandom = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Steamworks.SteamClient.Init(714030, true); // 252490 test ID    714030 StudyX    'Yargis 369040
            }
            catch (Exception f)
            {
                MessageBox.Show(f.ToString());
                this.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Steamworks.SteamClient.Shutdown();
        }

        private async void btnUpload_Click(object sender, EventArgs e)
        {

        }

        private void MemoEdit1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnUpload_Click_1(object sender, EventArgs e)
        {
            //Process.Start(@"TestUpload\icon-1719737_640.png"); // verify the path exists
            //Process.Start(@"TestUpload\"); // verify the path exists
            string previewLocation = @"\TestUpload\icon-1719737_640.png";
            publishReasult = await Steamworks.Ugc.Editor.NewCommunityFile
                .WithTitle("My New Item" + theRandom.Next())
                .WithDescription("test")
                .WithTag("StudyFile")
                .WithContent(@"TestUpload\")
                .SubmitAsync();
            // WithPreviewFile(previewLocation).      
            MemoEdit1.Text = publishReasult.Result.ToString() + "\n";
            
        }
    }
}
