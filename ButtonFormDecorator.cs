using System;
using System.Windows.Forms;
using ButtonDecorator.Pattern;

namespace ButtonDecorator
{
    public partial class ButtonFormDecorator : Form
    {
        BeatyButton beatyButton;
        ImageDecorator imageDecorator;
        BorderDecorator borderDecorator;

        Button button;

        public ButtonFormDecorator()
        {
            this.button = new Button();
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            beatyButton = new BeatyButton(this, this.button);
            beatyButton.Draw();
        }

        private void AddImage_Click(object sender, EventArgs e)
        {
            if (beatyButton == null) return;

            imageDecorator = new ImageDecorator(this, this.button);

            imageDecorator.Draw();
        }

        private void AddBorder_Click(object sender, EventArgs e)
        {
            if (beatyButton == null) return;

            borderDecorator = new BorderDecorator(this, this.button);

            borderDecorator.Draw();
        }
    }
}
