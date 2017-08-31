using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonDecorator.Pattern
{
    public class ImageDecorator : Decorator
    {
        public Image Image { get; set; }


        public ImageDecorator(Form form, Button button) : base(form, button)
        {
            Image = new Bitmap(Properties.Resources.pchelka, new Size(10, 10));
        }

        public override void Draw()
        {
            base.Draw();
            DrawImage();
        }

        public void DrawImage()
        {
            this.Button.Image = this.Image;
            this.Button.ImageAlign = ContentAlignment.MiddleLeft;
        }
    }
}
