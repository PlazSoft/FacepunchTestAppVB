using System;
using System.Diagnostics;
using System.Windows.Forms;
using Steamworks.Data;
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
                Steamworks.SteamClient.Init(714030, true); // 252490 test ID    714030 StudyX    'Yargis 369040 <<<<<<<<<<<<<<<
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

        private async void btnUpload_Click_1(object sender, EventArgs e)
        {
            string folderLocation =   Application.StartupPath +  @"\TestUpload\"; //@"C:\ProgramData\StudyX\";
            string previewLocation = Application.StartupPath + @"\TestUpload\icon-1719737_640.png";
            //Process.Start(previewLocation); // verify the path exists
            //Process.Start(folderLocation); // verify the path exists
            
            publishReasult = await Steamworks.Ugc.Editor.NewCommunityFile
                .WithTitle("My New Item " + theRandom.Next())
                .WithDescription("test")
                .WithTag("StudyFile")
                .WithContent(folderLocation)   //If you comment out this line it works. So it must be something related to the content.
                .WithPreviewFile(previewLocation)    //Even if you comment out this line it still has issues.
                .SubmitAsync();
            MemoEdit1.Text = publishReasult.Result.ToString() + "\n";

            Process.Start(@"steam://openurl/https://steamcommunity.com/sharedfiles/filedetails/?id=" + publishReasult.FileId.ToString()); //Opens the item on steam

        }

         private  async void  btnGetSubscribedWorkshop_Click(object sender, EventArgs e)
        {
            var q = Query.All
                                .WithTag("StudyFile")
                                .MatchAllTags(); //.MatchAnyTag();

            var result = await q.GetPageAsync(1);

            Console.WriteLine($"ResultCount: {result?.ResultCount}");
            Console.WriteLine($"TotalCount: {result?.TotalCount}");

            foreach (Item entry in result.Value.Entries)
            {
                Console.WriteLine($" {entry.Title}");
            }

            
        }

        private async void btnGetWorkshopItemInfo_Click(object sender, EventArgs e)
        {
            var itemInfo = await Item.GetAsync(2134710276);

            Console.WriteLine($"Title: {itemInfo?.Title}");
            Console.WriteLine($"IsInstalled: {itemInfo?.IsInstalled}");
            Console.WriteLine($"IsDownloading: {itemInfo?.IsDownloading}");
            Console.WriteLine($"IsDownloadPending: {itemInfo?.IsDownloadPending}");
            Console.WriteLine($"IsSubscribed: {itemInfo?.IsSubscribed}");
            Console.WriteLine($"NeedsUpdate: {itemInfo?.NeedsUpdate}");
            Console.WriteLine($"Description: {itemInfo?.Description}");
        }
    }
}
