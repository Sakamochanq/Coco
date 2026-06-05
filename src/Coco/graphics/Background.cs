using System.Drawing;

namespace Coco.graphics
{
    internal class Background
    {
        private void Desk(Graphics g, int x, int y, int w, int h, Font font)
        {
            Rectangle rect = new Rectangle(x, y, w, h);

            g.FillRectangle(Brushes.LightGray, rect);

            g.DrawRectangle(Pens.Black, rect);

            StringFormat sf = new StringFormat();

            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            string moji = "机";
            g.DrawString(moji, font, Brushes.Black, rect, sf);
        }

        public void Draw(Graphics g, Font font)
        {
            // 背景
            g.Clear(Color.WhiteSmoke);

            int w = 100;
            int h = 60;

            // 上段
            Desk(g, 40, 20, w, h, font);
            Desk(g, 150, 20, w, h, font);
            Desk(g, 260, 20, w, h, font);
            Desk(g, 370, 20, w, h, font);
            Desk(g, 480, 20, w, h, font);

            // 中段
            Desk(g, 150, 150, w, h, font);
            Desk(g, 260, 150, w, h, font);
            Desk(g, 370, 150, w, h, font);

            Desk(g, 150, 220, w, h, font);
            Desk(g, 260, 220, w, h, font);
            Desk(g, 370, 220, w, h, font);

            // 下段
            Desk(g, 150, 360, w, h, font);
            Desk(g, 260, 360, w, h, font);
            Desk(g, 370, 360, w, h, font);

            // 出入口
            Font exit = new Font("Meiryo", 15);
            g.DrawString("出入口", exit, Brushes.Black, 560, 390);
        }
    }
}