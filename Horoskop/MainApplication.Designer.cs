namespace Horoskop
{
    partial class MainApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApplication));
            this.zodiacNameLabel = new System.Windows.Forms.Label();
            this.predictionsLabel = new System.Windows.Forms.Label();
            this.zodiacCombo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.editButton = new MetroFramework.Controls.MetroButton();
            this.zodiacIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.zodiacIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // zodiacNameLabel
            // 
            this.zodiacNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zodiacNameLabel.AutoSize = true;
            this.zodiacNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.zodiacNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 38F, System.Drawing.FontStyle.Bold);
            this.zodiacNameLabel.Location = new System.Drawing.Point(120, 79);
            this.zodiacNameLabel.Name = "zodiacNameLabel";
            this.zodiacNameLabel.Size = new System.Drawing.Size(561, 68);
            this.zodiacNameLabel.TabIndex = 2;
            this.zodiacNameLabel.Text = "Моля, изберете зодия";
            // 
            // predictionsLabel
            // 
            this.predictionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.predictionsLabel.AutoSize = true;
            this.predictionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.predictionsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.predictionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.predictionsLabel.Location = new System.Drawing.Point(111, 208);
            this.predictionsLabel.MaximumSize = new System.Drawing.Size(603, 0);
            this.predictionsLabel.MinimumSize = new System.Drawing.Size(603, 0);
            this.predictionsLabel.Name = "predictionsLabel";
            this.predictionsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.predictionsLabel.Size = new System.Drawing.Size(603, 30);
            this.predictionsLabel.TabIndex = 3;
            this.predictionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zodiacCombo
            // 
            this.zodiacCombo.Cursor = System.Windows.Forms.Cursors.Default;
            this.zodiacCombo.DropDownHeight = 150;
            this.zodiacCombo.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.zodiacCombo.FormattingEnabled = true;
            this.zodiacCombo.IntegralHeight = false;
            this.zodiacCombo.ItemHeight = 29;
            this.zodiacCombo.Items.AddRange(new object[] {
            "Овен",
            "Телец",
            "Близнаци",
            "Рак",
            "Лъв",
            "Дева",
            "Везни",
            "Скорпион",
            "Стрелец",
            "Козирог",
            "Водолей",
            "Риби"});
            this.zodiacCombo.Location = new System.Drawing.Point(290, 409);
            this.zodiacCombo.Name = "zodiacCombo";
            this.zodiacCombo.Size = new System.Drawing.Size(220, 35);
            this.zodiacCombo.Style = MetroFramework.MetroColorStyle.Purple;
            this.zodiacCombo.TabIndex = 6;
            this.zodiacCombo.Tag = "";
            this.zodiacCombo.SelectedIndexChanged += new System.EventHandler(this.zodiacCombo_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(290, 387);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Избери зодия:";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(8, 412);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(183, 29);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Редактирай предсказанията";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // zodiacIcon
            // 
            this.zodiacIcon.Location = new System.Drawing.Point(72, 79);
            this.zodiacIcon.Name = "zodiacIcon";
            this.zodiacIcon.Size = new System.Drawing.Size(64, 64);
            this.zodiacIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.zodiacIcon.TabIndex = 9;
            this.zodiacIcon.TabStop = false;
            // 
            // MainApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zodiacIcon);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.zodiacCombo);
            this.Controls.Add(this.predictionsLabel);
            this.Controls.Add(this.zodiacNameLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainApplication";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Дневен хороскоп";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zodiacIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label zodiacNameLabel;
        private System.Windows.Forms.Label predictionsLabel;
        private MetroFramework.Controls.MetroComboBox zodiacCombo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton editButton;
        private System.Windows.Forms.PictureBox zodiacIcon;
    }
}

