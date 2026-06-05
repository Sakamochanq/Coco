using Coco.graphics;
using System.Windows.Forms;

namespace Coco
{
    public partial class Source : Form
    {
        public Source()
        {
            InitializeComponent();
        }

        private Background background = new Background();

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            background.Draw(e.Graphics, this.Font);
        }
    }
}
