namespace QwertyToMIDI
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            pictureBox_Icon = new PictureBox();
            checkBox_Startup = new CheckBox();
            button_Ok = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Icon).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_Icon
            // 
            pictureBox_Icon.Image = (Image)resources.GetObject("pictureBox_Icon.Image");
            pictureBox_Icon.Location = new Point(12, 12);
            pictureBox_Icon.Name = "pictureBox_Icon";
            pictureBox_Icon.Size = new Size(239, 96);
            pictureBox_Icon.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox_Icon.TabIndex = 0;
            pictureBox_Icon.TabStop = false;
            // 
            // checkBox_Startup
            // 
            checkBox_Startup.AutoSize = true;
            checkBox_Startup.Location = new Point(12, 114);
            checkBox_Startup.Name = "checkBox_Startup";
            checkBox_Startup.Size = new Size(125, 19);
            checkBox_Startup.TabIndex = 1;
            checkBox_Startup.Text = "Run with Windows";
            checkBox_Startup.UseVisualStyleBackColor = true;
            checkBox_Startup.CheckedChanged += checkBox_Startup_CheckedChanged;
            // 
            // button_Ok
            // 
            button_Ok.Location = new Point(176, 206);
            button_Ok.Name = "button_Ok";
            button_Ok.Size = new Size(75, 23);
            button_Ok.TabIndex = 2;
            button_Ok.Text = "OK";
            button_Ok.UseVisualStyleBackColor = true;
            button_Ok.Click += button_Ok_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 241);
            Controls.Add(button_Ok);
            Controls.Add(checkBox_Startup);
            Controls.Add(pictureBox_Icon);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            Text = "Settings";
            Load += SettingsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_Icon;
        private CheckBox checkBox_Startup;
        private Button button_Ok;
    }
}