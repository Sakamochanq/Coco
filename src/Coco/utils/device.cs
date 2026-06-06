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

        [Category("Appearance")]
        [Description("機材の識別IDです")]
        public int ID { get; set; }

        [Category("Appearance")]
        [Description("機材名です")]
        public string Name { get; set; }

        [Category("Appearance")]
        [Description("使用者名です")]
        public string User { get; set; }

        [Category("Appearance")]
        [DisplayName("Color")]
        [Description("オブジェクトの背景色です")]
        public Color ObjectColor { get; set; } = Color.DeepSkyBlue;

        public override string ToString()
        {
            return ID.ToString();
        }
    }
}
