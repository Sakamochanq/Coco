using System.ComponentModel;
using System.Drawing;

namespace Coco.utils
{
    internal class device
    {
        [Category("Coordinate")]
        [Description("オブジェクトの座標・サイズです。")]
        [ReadOnly(true)]
        public Rectangle Cord { get; set; }

        [Category("Basic")]
        [Description("機材の識別IDです")]
        public int ID { get; set; }

        [Category("Basic")]
        [Description("機材名です")]
        public string Name { get; set; }

        [Category("Basic")]
        [Description("使用者名です")]
        public string User { get; set; }

        public override string ToString()
        {
            return ID.ToString();
        }
    }
}
