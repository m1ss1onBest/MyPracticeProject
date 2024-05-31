using System.ComponentModel;

namespace MyPracticeProject
{
    partial class FormManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.завданняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задача1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задача2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задача3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задача4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задача5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатковоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.згенеруватиПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихiдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.завданняToolStripMenuItem, this.проПрограмуToolStripMenuItem, this.додатковоToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // завданняToolStripMenuItem
            // 
            this.завданняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.задача1ToolStripMenuItem, this.задача2ToolStripMenuItem, this.задача3ToolStripMenuItem, this.задача4ToolStripMenuItem, this.задача5ToolStripMenuItem });
            this.завданняToolStripMenuItem.Name = "завданняToolStripMenuItem";
            this.завданняToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.завданняToolStripMenuItem.Text = "Завдання";
            // 
            // задача1ToolStripMenuItem
            // 
            this.задача1ToolStripMenuItem.Name = "задача1ToolStripMenuItem";
            this.задача1ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.задача1ToolStripMenuItem.Text = "Задача 1";
            // 
            // задача2ToolStripMenuItem
            // 
            this.задача2ToolStripMenuItem.Name = "задача2ToolStripMenuItem";
            this.задача2ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.задача2ToolStripMenuItem.Text = "Задача 2";
            // 
            // задача3ToolStripMenuItem
            // 
            this.задача3ToolStripMenuItem.Name = "задача3ToolStripMenuItem";
            this.задача3ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.задача3ToolStripMenuItem.Text = "Задача 3";
            // 
            // задача4ToolStripMenuItem
            // 
            this.задача4ToolStripMenuItem.Name = "задача4ToolStripMenuItem";
            this.задача4ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.задача4ToolStripMenuItem.Text = "Задача 4";
            // 
            // задача5ToolStripMenuItem
            // 
            this.задача5ToolStripMenuItem.Name = "задача5ToolStripMenuItem";
            this.задача5ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.задача5ToolStripMenuItem.Text = "Задача 5";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            // 
            // додатковоToolStripMenuItem
            // 
            this.додатковоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.згенеруватиПарольToolStripMenuItem, this.вихiдToolStripMenuItem });
            this.додатковоToolStripMenuItem.Name = "додатковоToolStripMenuItem";
            this.додатковоToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.додатковоToolStripMenuItem.Text = "Додатково";
            // 
            // згенеруватиПарольToolStripMenuItem
            // 
            this.згенеруватиПарольToolStripMenuItem.Name = "згенеруватиПарольToolStripMenuItem";
            this.згенеруватиПарольToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.згенеруватиПарольToolStripMenuItem.Text = "Згенерувати Пароль";
            // 
            // вихiдToolStripMenuItem
            // 
            this.вихiдToolStripMenuItem.Name = "вихiдToolStripMenuItem";
            this.вихiдToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.вихiдToolStripMenuItem.Text = "Вихiд";
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 596);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("e-Ukraine Head", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormManager_FormClosing);
            this.Load += new System.EventHandler(this.FormManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem задача1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задача2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задача3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задача4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задача5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатковоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem згенеруватиПарольToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихiдToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem завданняToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion
    }
}