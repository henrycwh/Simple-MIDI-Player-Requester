namespace midi_palyer_simple_edition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Generate_midi = new Button();
            Play_midi = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Generate_midi
            // 
            Generate_midi.Location = new Point(12, 454);
            Generate_midi.Name = "Generate_midi";
            Generate_midi.Size = new Size(138, 29);
            Generate_midi.TabIndex = 0;
            Generate_midi.Text = "Generate_midi";
            Generate_midi.UseVisualStyleBackColor = true;
            Generate_midi.Click += Generate_midi_Click;
            // 
            // Play_midi
            // 
            Play_midi.Location = new Point(261, 454);
            Play_midi.Name = "Play_midi";
            Play_midi.Size = new Size(94, 29);
            Play_midi.TabIndex = 1;
            Play_midi.Text = "Play_midi";
            Play_midi.UseVisualStyleBackColor = true;
            Play_midi.Click += Play_midi_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(417, 495);
            Controls.Add(label1);
            Controls.Add(Play_midi);
            Controls.Add(Generate_midi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Generate_midi;
        private Button Play_midi;
        private Label label1;
    }
}