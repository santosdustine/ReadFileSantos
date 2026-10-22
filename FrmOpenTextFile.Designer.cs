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
            SuspendLayout();
            // 
            // lvShowText
            // 
            lvShowText.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvShowText.Location = new Point(12, 22);
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new Size(369, 214);
            lvShowText.TabIndex = 0;
            lvShowText.UseCompatibleStateImageBehavior = false;
            lvShowText.View = View.List;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(127, 258);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(140, 43);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmOpenTextFile
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(393, 320);
            Controls.Add(btnOpen);
            Controls.Add(lvShowText);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmOpenTextFile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmOpenTextFile";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvShowText;
        private Button btnOpen;
        private OpenFileDialog openFileDialog1;
    }
}
