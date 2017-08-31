using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonDecorator.Pattern
{
    public class BorderDecorator: Decorator
    {
        public BorderDecorator(Form form, Button button):base(form, button)
        {

        }

        public override void Draw()
        {
            base.Draw();
            DrawBorder();
        }

        public void DrawBorder()
        {
            this.Button.FlatStyle = FlatStyle.Flat;
            this.Button.FlatAppearance.BorderColor = Color.Red;
            this.Button.FlatAppearance.BorderSize = 2;
        }
    }
}
