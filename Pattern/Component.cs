using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonDecorator.Pattern
{
    public abstract class Component
    {
        public Form Form { get; set; }

        public Button Button { get; set; }

        protected Component(Form form, Button button)
        {
            this.Form = form;
            this.Button = button;
        }

        public abstract void Draw();    
    }
}
