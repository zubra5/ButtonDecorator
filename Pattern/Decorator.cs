using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonDecorator.Pattern
{
    public abstract class Decorator : Component
    {
        protected Component Component { get; set; }

        protected Decorator(Form form, Button button) : base(form, button)
        {

        }

        public void SetComponent(Component component)
        {
            Component = component;
        }

        public override void Draw()
        {
            if (Component != null)
            {
                Component.Draw();
            }
        }
    }
}
