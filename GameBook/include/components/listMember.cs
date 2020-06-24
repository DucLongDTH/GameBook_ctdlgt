using System.Drawing;
using System.Windows.Forms;

namespace GameBook.include.components
{
    public partial class listMember : UserControl
    {
        public listMember()
        {
            InitializeComponent();
        }
        public listMember(Image gameLogo, string gameTitle, string releaseDate, string gameVersion, string gameCategory, string gamePrice)
        {
            InitializeComponent();
            this.gameLogo = gameLogo;
            this.gameTitle = gameTitle;
            this.releaseDate = releaseDate;
            this.gameVersion = gameVersion;
            this.gameCategory = gameCategory;
            this.gamePrice = gamePrice;
        }
        public Image gameLogo { get => picbLogo.Image; set => picbLogo.Image = value; }

        public string gameTitle { get => lbGameTitle.Text; set => lbGameTitle.Text = value; }

        public string releaseDate { get => lbReleaseDate.Text; set => lbReleaseDate.Text = value; }

        public string gameVersion { get => lbVersion.Text; set => lbVersion.Text = value; }

        public string gameCategory { get => lbCategory.Text; set => lbCategory.Text = value; }

        public string gamePrice { get => lbPrice.Text; set => lbPrice.Text = value; }
    }
}
