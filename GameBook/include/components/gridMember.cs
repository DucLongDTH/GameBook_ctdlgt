using System.Drawing;
using System.Windows.Forms;

namespace GameBook.include.components
{
    public partial class gridMember : UserControl
    {
        public gridMember()
        {
            InitializeComponent();
        }

        public gridMember(Image gameLogo, string gameTitle)
        {
            InitializeComponent();
            this.gameLogo = gameLogo;
            this.gameTitle = gameTitle;
        }

        public Image gameLogo { get => picbLogoGame.Image; set => picbLogoGame.Image = value; }

        public string gameTitle { get => lbGameTitle.Text; set => lbGameTitle.Text = value; }
    }
}
