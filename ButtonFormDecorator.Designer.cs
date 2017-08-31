namespace ButtonDecorator
{
    partial class ButtonFormDecorator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu1 = new System.Windows.Forms.MenuStrip();
            this.AddButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddImage = new System.Windows.Forms.ToolStripMenuItem();
            this.AddBorder = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu1
            // 
            this.Menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddButton,
            this.AddImage,
            this.AddBorder});
            this.Menu1.Location = new System.Drawing.Point(0, 0);
            this.Menu1.Name = "Menu1";
            this.Menu1.Size = new System.Drawing.Size(671, 24);
            this.Menu1.TabIndex = 0;
            this.Menu1.Text = "Add new button";
            // 
            // AddButton
            // 
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 20);
            this.AddButton.Text = "Add button";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddImage
            // 
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(77, 20);
            this.AddImage.Text = "Add image";
            this.AddImage.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // AddBorder
            // 
            this.AddBorder.Name = "AddBorder";
            this.AddBorder.Size = new System.Drawing.Size(79, 20);
            this.AddBorder.Text = "Add Border";
            this.AddBorder.Click += new System.EventHandler(this.AddBorder_Click);
            // 
            // ButtonFormDecorator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 261);
            this.Controls.Add(this.Menu1);
            this.MainMenuStrip = this.Menu1;
            this.Name = "ButtonFormDecorator";
            this.Text = "Decorator Pattern";
            this.Menu1.ResumeLayout(false);
            this.Menu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu1;
        private System.Windows.Forms.ToolStripMenuItem AddButton;
        private System.Windows.Forms.ToolStripMenuItem AddImage;
        private System.Windows.Forms.ToolStripMenuItem AddBorder;
    }
}

