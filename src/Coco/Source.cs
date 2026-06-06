using Coco.graphics;
using Coco.utils;
using System.Collections.Generic;
using System.Drawing;
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

        private List<device> devices = new List<device>();

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            // 背景の描画
            background.Draw(e.Graphics, this.Font);

            // デバイスの描画
            foreach (device device in devices)
            {
                e.Graphics.FillRectangle(Brushes.DeepSkyBlue, device.Cord);
                e.Graphics.DrawRectangle(Pens.Black, device.Cord);
            }

        }

        private void AddObjectButton1_Click(object sender, System.EventArgs e)
        {
            // 配置をずらす為のオフセット
            int offset = devices.Count * 20;

            // 新規オブジェクトの追加
            device pc = new device
            {
                ID = 001,
                Name = "PC",
                User = "",
                Cord = new Rectangle(100 + offset, 100 + offset, 70, 40)
            };

            // デバイスリストに追加
            devices.Add(pc);

            // 画面を再描画
            pictureBox.Invalidate();

        }

        private void AddObjectButton2_Click(object sender, System.EventArgs e)
        {
            AddObjectButton1_Click(sender, e);
        }
    }
}
