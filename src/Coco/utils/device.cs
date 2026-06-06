using System.ComponentModel;
using System.Drawing;

namespace Coco.utils
{
    internal class device
    {
        [Category("Layout")]
        [Description("オブジェクトの座標・サイズです。")]
        [ReadOnly(true)]
        public Rectangle Cord { get; set; }

        [Category("Data")]
        [Description("機材の識別IDです")]
        public int ID { get; set; }

        [Category("Data")]
        [Description("機材名です")]
        public string Name { get; set; }

        [Category("Data")]
        [Description("使用者名です")]
        public string User { get; set; }

        [Category("Appearance")]
        [DisplayName("BackColor")]
        [Description("オブジェクトの背景色です")]
        public Color ObjectColor { get; set; } = Color.Gainsboro;

        [Category("Appearance")]
        [DisplayName("ForeColor")]
        [Description("文字の色です")]
        public Color TextColor { get; set; } = Color.Black;

        [Category("Appearance")]
        [DisplayName("TextSize")]
        [Description("文字サイズです")]
        public float TextSize { get; set; } = 10f;

        public override string ToString()
        {
            return ID.ToString();
        }
    }
}
