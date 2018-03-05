namespace IpWebCam
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.PictureBox();
            this.ipTextBox = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.connectButton = new MetroFramework.Controls.MetroTile();
            this.disButton = new MetroFramework.Controls.MetroTile();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.outputBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Adress";
            // 
            // outputBox
            // 
            this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBox.Location = new System.Drawing.Point(200, 35);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(664, 423);
            this.outputBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outputBox.TabIndex = 3;
            this.outputBox.TabStop = false;
            // 
            // ipTextBox
            // 
            this.ipTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.ipTextBox.CustomButton.Image = null;
            this.ipTextBox.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.ipTextBox.CustomButton.Name = "";
            this.ipTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ipTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ipTextBox.CustomButton.TabIndex = 1;
            this.ipTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ipTextBox.CustomButton.UseSelectable = true;
            this.ipTextBox.CustomButton.Visible = false;
            this.ipTextBox.Lines = new string[0];
            this.ipTextBox.Location = new System.Drawing.Point(12, 33);
            this.ipTextBox.MaxLength = 32767;
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.PasswordChar = '\0';
            this.ipTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ipTextBox.SelectedText = "";
            this.ipTextBox.SelectionLength = 0;
            this.ipTextBox.SelectionStart = 0;
            this.ipTextBox.ShortcutsEnabled = true;
            this.ipTextBox.Size = new System.Drawing.Size(182, 23);
            this.ipTextBox.TabIndex = 0;
            this.ipTextBox.UseSelectable = true;
            this.ipTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ipTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(174)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.metroToggle1);
            this.panel1.Controls.Add(this.disButton);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.ipTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 481);
            this.panel1.TabIndex = 10;
            // 
            // connectButton
            // 
            this.connectButton.ActiveControl = null;
            this.connectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.connectButton.Location = new System.Drawing.Point(12, 62);
            this.connectButton.Name = "connectButton";
            this.connectButton.PaintTileCount = false;
            this.connectButton.Size = new System.Drawing.Size(87, 74);
            this.connectButton.Style = MetroFramework.MetroColorStyle.Green;
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.connectButton.UseSelectable = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disButton
            // 
            this.disButton.ActiveControl = null;
            this.disButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.disButton.Location = new System.Drawing.Point(105, 62);
            this.disButton.Name = "disButton";
            this.disButton.PaintTileCount = false;
            this.disButton.Size = new System.Drawing.Size(87, 74);
            this.disButton.Style = MetroFramework.MetroColorStyle.Red;
            this.disButton.TabIndex = 3;
            this.disButton.Text = "Disconnect";
            this.disButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.disButton.UseSelectable = true;
            this.disButton.Click += new System.EventHandler(this.disButton_Click);
            // 
            // metroToggle1
            // 
            this.metroToggle1.Appearance = System.Windows.Forms.Appearance.Button;
            this.metroToggle1.AutoCheck = false;
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.DisplayStatus = false;
            this.metroToggle1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroToggle1.Location = new System.Drawing.Point(107, 154);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(50, 23);
            this.metroToggle1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroToggle1.TabIndex = 11;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseCustomBackColor = true;
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.Click += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Flashlight";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.outputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.outputBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox outputBox;
        private MetroFramework.Controls.MetroTextBox ipTextBox;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile disButton;
        private MetroFramework.Controls.MetroTile connectButton;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroToggle metroToggle1;
    }
}

