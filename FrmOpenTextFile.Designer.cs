namespace ReadFileSantos
{
    partial class FrmOpenTextFile
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
            lvShowText = new ListView();
            btnOpen = new Button();
            openFileDialog1 = new OpenFileDialog();
            lblOpenFile = new Label();
            SuspendLayout();
            // 
            // lvShowText
            // 
            lvShowText.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvShowText.Location = new Point(12, 37);
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new Size(369, 214);
            lvShowText.TabIndex = 0;
            lvShowText.UseCompatibleStateImageBehavior = false;
            lvShowText.View = View.List;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.Red;
            btnOpen.FlatAppearance.BorderSize = 0;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.ForeColor = Color.White;
            btnOpen.Location = new Point(122, 265);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(140, 43);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblOpenFile
            // 
            lblOpenFile.AutoSize = true;
            lblOpenFile.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpenFile.Location = new Point(12, 9);
            lblOpenFile.Name = "lblOpenFile";
            lblOpenFile.Size = new Size(117, 19);
            lblOpenFile.TabIndex = 2;
            lblOpenFile.Text = "Open Text File";
            // 
            // FrmOpenTextFile
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(393, 320);
            Controls.Add(lblOpenFile);
            Controls.Add(btnOpen);
            Controls.Add(lvShowText);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmOpenTextFile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmOpenTextFile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvShowText;
        private Button btnOpen;
        private OpenFileDialog openFileDialog1;
        private Label lblOpenFile;
    }
}
