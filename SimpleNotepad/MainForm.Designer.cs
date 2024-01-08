namespace SimpleNotepad
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox richTextBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            richTextBox = new RichTextBox();
            btnSave = new Button();
            btnOpen = new Button();
            lblCurrentFile = new Label();
            SuspendLayout();
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(1, 61);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(802, 393);
            richTextBox.TabIndex = 1;
            richTextBox.Text = "";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 40);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(165, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(131, 40);
            btnOpen.TabIndex = 3;
            btnOpen.Text = "Open File";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // lblCurrentFile
            // 
            lblCurrentFile.AutoSize = true;
            lblCurrentFile.Location = new Point(313, 17);
            lblCurrentFile.Name = "lblCurrentFile";
            lblCurrentFile.Size = new Size(0, 30);
            lblCurrentFile.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCurrentFile);
            Controls.Add(btnOpen);
            Controls.Add(btnSave);
            Controls.Add(richTextBox);
            Name = "MainForm";
            Text = "Simple Text Box";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnOpen;
        private Label lblCurrentFile;
    }
}
