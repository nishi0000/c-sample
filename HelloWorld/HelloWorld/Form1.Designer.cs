namespace HelloWorld
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            helloButton = new Button();
            helloLabel = new Label();
            SuspendLayout();
            // 
            // helloButton
            // 
            helloButton.Location = new Point(282, 304);
            helloButton.Name = "helloButton";
            helloButton.Size = new Size(186, 97);
            helloButton.TabIndex = 0;
            helloButton.Text = "クリック！";
            helloButton.UseVisualStyleBackColor = true;
            helloButton.Click += HelloButtonClicked;
            // 
            // helloLabel
            // 
            helloLabel.Location = new Point(303, 127);
            helloLabel.Name = "helloLabel";
            helloLabel.Size = new Size(122, 49);
            helloLabel.TabIndex = 1;
            helloLabel.Text = "?????";
            helloLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(helloLabel);
            Controls.Add(helloButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button helloButton;
        private Label helloLabel;
    }
}
