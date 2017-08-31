using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonDecorator.Pattern
{
    public class BeatyButton : Component
    {

        public BeatyButton(Form form, Button button):base(form, button)
        {

        }
        public override void Draw()
        {
            Button.BackColor = Color.BurlyWood;
            Button.Width = 200;
            Button.Height = 30;
            Button.Location = new Point(100,100);
            Button.Text = "Hi! I am Beaty Button";
            Form.Controls.Add(Button);
        }
    }
}
