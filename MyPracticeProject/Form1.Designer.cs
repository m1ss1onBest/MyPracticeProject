namespace MyPracticeProject
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelMain = new System.Windows.Forms.Label();
            this.labelMainInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_INFO = new System.Windows.Forms.Label();
            this.pictureBoxLineUnder = new System.Windows.Forms.PictureBox();
            this.labelLogoInfo = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.customTextBoxUserName = new MyPracticeProject.CustomTextBox();
            this.customTextBoxUserPassword = new MyPracticeProject.CustomTextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.buttonAsGuest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLineUnder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.Font = new System.Drawing.Font("e-Ukraine Head", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMain.Location = new System.Drawing.Point(498, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(291, 70);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "labelMain";
            this.labelMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelMainInfo
            // 
            this.labelMainInfo.Font = new System.Drawing.Font("e-Ukraine Head", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainInfo.Location = new System.Drawing.Point(430, 79);
            this.labelMainInfo.Name = "labelMainInfo";
            this.labelMainInfo.Size = new System.Drawing.Size(424, 43);
            this.labelMainInfo.TabIndex = 1;
            this.labelMainInfo.Text = "labelMainInfo";
            this.labelMainInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(135)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label_INFO);
            this.panel1.Controls.Add(this.pictureBoxLineUnder);
            this.panel1.Controls.Add(this.labelLogoInfo);
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 719);
            this.panel1.TabIndex = 2;
            // 
            // label_INFO
            // 
            this.label_INFO.Font = new System.Drawing.Font("e-Ukraine Head", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_INFO.ForeColor = System.Drawing.Color.White;
            this.label_INFO.Location = new System.Drawing.Point(45, 9);
            this.label_INFO.Name = "label_INFO";
            this.label_INFO.Size = new System.Drawing.Size(252, 46);
            this.label_INFO.TabIndex = 3;
            this.label_INFO.Text = "label_INFO";
            this.label_INFO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxLineUnder
            // 
            this.pictureBoxLineUnder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLineUnder.BackgroundImage")));
            this.pictureBoxLineUnder.Location = new System.Drawing.Point(45, 311);
            this.pictureBoxLineUnder.Name = "pictureBoxLineUnder";
            this.pictureBoxLineUnder.Size = new System.Drawing.Size(333, 10);
            this.pictureBoxLineUnder.TabIndex = 3;
            this.pictureBoxLineUnder.TabStop = false;
            // 
            // labelLogoInfo
            // 
            this.labelLogoInfo.Font = new System.Drawing.Font("e-Ukraine Head", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogoInfo.ForeColor = System.Drawing.Color.White;
            this.labelLogoInfo.Location = new System.Drawing.Point(45, 324);
            this.labelLogoInfo.Name = "labelLogoInfo";
            this.labelLogoInfo.Size = new System.Drawing.Size(333, 309);
            this.labelLogoInfo.TabIndex = 3;
            this.labelLogoInfo.Text = "labelLogoInfo";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(84, 57);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(252, 247);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelUserName
            // 
            this.labelUserName.Font = new System.Drawing.Font("e-Ukraine Head", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserName.Location = new System.Drawing.Point(430, 169);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(424, 32);
            this.labelUserName.TabIndex = 4;
            this.labelUserName.Text = "labelUserName";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // customTextBoxUserName
            // 
            this.customTextBoxUserName.BorderColor = System.Drawing.Color.Black;
            this.customTextBoxUserName.BorderSize = 3;
            this.customTextBoxUserName.Font = new System.Drawing.Font("e-Ukraine Head", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customTextBoxUserName.Location = new System.Drawing.Point(498, 216);
            this.customTextBoxUserName.Name = "customTextBoxUserName";
            this.customTextBoxUserName.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxUserName.PasswordChar = '\0';
            this.customTextBoxUserName.Size = new System.Drawing.Size(291, 38);
            this.customTextBoxUserName.TabIndex = 5;
            this.customTextBoxUserName.Underlined = true;
            // 
            // customTextBoxUserPassword
            // 
            this.customTextBoxUserPassword.BorderColor = System.Drawing.Color.Black;
            this.customTextBoxUserPassword.BorderSize = 3;
            this.customTextBoxUserPassword.Font = new System.Drawing.Font("e-Ukraine Head", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customTextBoxUserPassword.Location = new System.Drawing.Point(498, 319);
            this.customTextBoxUserPassword.Name = "customTextBoxUserPassword";
            this.customTextBoxUserPassword.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxUserPassword.PasswordChar = '\0';
            this.customTextBoxUserPassword.Size = new System.Drawing.Size(291, 38);
            this.customTextBoxUserPassword.TabIndex = 7;
            this.customTextBoxUserPassword.Underlined = true;
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("e-Ukraine Head", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(430, 272);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(424, 32);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "labelPassword";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogIn.Font = new System.Drawing.Font("e-Ukraine Head", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogIn.ForeColor = System.Drawing.Color.White;
            this.buttonLogIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLogIn.Location = new System.Drawing.Point(498, 529);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(291, 64);
            this.buttonLogIn.TabIndex = 8;
            this.buttonLogIn.Text = "buttonLogIn";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            // 
            // buttonAsGuest
            // 
            this.buttonAsGuest.BackColor = System.Drawing.Color.White;
            this.buttonAsGuest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAsGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAsGuest.Font = new System.Drawing.Font("e-Ukraine Head", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAsGuest.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.buttonAsGuest.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAsGuest.Location = new System.Drawing.Point(498, 599);
            this.buttonAsGuest.Name = "buttonAsGuest";
            this.buttonAsGuest.Size = new System.Drawing.Size(123, 26);
            this.buttonAsGuest.TabIndex = 9;
            this.buttonAsGuest.Text = "buttonAsGuest";
            this.buttonAsGuest.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAsGuest.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 719);
            this.Controls.Add(this.buttonAsGuest);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.customTextBoxUserPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.customTextBoxUserName);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelMainInfo);
            this.Controls.Add(this.labelMain);
            this.Font = new System.Drawing.Font("e-Ukraine Head", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLineUnder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonAsGuest;

        private System.Windows.Forms.Button buttonLogIn;

        private MyPracticeProject.CustomTextBox customTextBoxUserPassword;
        private System.Windows.Forms.Label labelPassword;

        private MyPracticeProject.CustomTextBox customTextBoxUserName;

        private System.Windows.Forms.Label labelUserName;

        private System.Windows.Forms.Label label_INFO;

        private System.Windows.Forms.PictureBox pictureBoxLineUnder;

        private System.Windows.Forms.Label labelLogoInfo;

        private System.Windows.Forms.PictureBox pictureBoxLogo;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Label labelMainInfo;

        private System.Windows.Forms.Label labelMain;

        #endregion
    }
}

