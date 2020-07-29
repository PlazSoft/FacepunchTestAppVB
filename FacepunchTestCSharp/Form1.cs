using System;
using System.Diagnostics;
using System.Windows.Forms;
using Steamworks;
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
            Steamworks.SteamUGC.OnDownloadItemResult += updateDownloadedItems;
        }

        private void updateDownloadedItems(Steamworks.Result steamResult)
        {
            
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
            Query q = Query.All
                                .WithTag("StudyFile")
                                .MatchAllTags(); //.MatchAnyTag();

            ResultPage? result = await q.GetPageAsync(1);

            MemoEdit1.Text +=($"ResultCount: {result?.ResultCount}\r\n");
            MemoEdit1.Text += ($"TotalCount: {result?.TotalCount}\r\n");

            long iterationNum = 0;
            foreach (Item entry in result.Value.Entries)
            {
                iterationNum++;
                MemoEdit1.Text += ($"   " + iterationNum + $". {entry.Title}    {entry.Id}\r\n");
                
                var itemInfo = await Item.GetAsync(entry.Id);

                //TODO: Add code to download item here::::::::::::::::::

                //Steamworks.Ugc.DownloadItem(entry.Id); //specify the publishedFileID
                //Item.download(entry.Id); //Or maybe something like this?
                Steamworks.SteamUGC.Download(entry.Id);
                

            }

            
        }

        private async void btnGetWorkshopItemInfo_Click(object sender, EventArgs e)
        {
            var itemInfo = await Item.GetAsync(2134710276);

            MemoEdit1.Text += ($"Title: {itemInfo?.Title}\r\n");
            MemoEdit1.Text += ($"IsInstalled: {itemInfo?.IsInstalled}\r\n");
            MemoEdit1.Text += ($"IsDownloading: {itemInfo?.IsDownloading}\r\n");
            MemoEdit1.Text += ($"IsDownloadPending: {itemInfo?.IsDownloadPending}\r\n");
            MemoEdit1.Text += ($"IsSubscribed: {itemInfo?.IsSubscribed}\r\n");
            MemoEdit1.Text += ($"NeedsUpdate: {itemInfo?.NeedsUpdate}\r\n");
            MemoEdit1.Text += ($"Description: {itemInfo?.Description}\r\n");
        }
    }
}
