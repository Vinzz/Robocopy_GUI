namespace RoboCopy_GUI
{
    partial class Infos
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Infos));
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(32, 20);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(245, 13);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Log will be stored in %TEMP%\\Robocopy_GUI.log";
        	this.label1.Click += new System.EventHandler(this.label1_Click);
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(32, 50);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(376, 13);
        	this.label2.TabIndex = 1;
        	this.label2.Text = "Last command will be stored in %TEMP%\\Robocopy_GUI_Last_Command.bat";
        	// 
        	// Form2
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(437, 72);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "Form2";
        	this.Text = "Robocopy_GUI";
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
