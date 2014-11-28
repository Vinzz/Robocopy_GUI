namespace RoboCopy_GUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Source_folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Destination_folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSource = new System.Windows.Forms.Button();
            this.btnDestination = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textSource = new System.Windows.Forms.TextBox();
            this.textDestination = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.checkMirror = new System.Windows.Forms.CheckBox();
            this.checkCreateDest = new System.Windows.Forms.CheckBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.ChkDontRetry = new System.Windows.Forms.CheckBox();
            this.Source_FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSourceFile = new System.Windows.Forms.Button();
            this.checkProgress = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSource
            // 
            this.btnSource.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSource.Image = ((System.Drawing.Image)(resources.GetObject("btnSource.Image")));
            this.btnSource.Location = new System.Drawing.Point(424, 17);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(25, 25);
            this.btnSource.TabIndex = 1;
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnDestination
            // 
            this.btnDestination.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDestination.Image = ((System.Drawing.Image)(resources.GetObject("btnDestination.Image")));
            this.btnDestination.Location = new System.Drawing.Point(424, 56);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(25, 25);
            this.btnDestination.TabIndex = 2;
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination";
            // 
            // textSource
            // 
            this.textSource.AcceptsReturn = true;
            this.textSource.Location = new System.Drawing.Point(71, 20);
            this.textSource.Name = "textSource";
            this.textSource.Size = new System.Drawing.Size(347, 20);
            this.textSource.TabIndex = 5;
            this.textSource.TextChanged += new System.EventHandler(this.TextSourceTextChanged);
            // 
            // textDestination
            // 
            this.textDestination.Location = new System.Drawing.Point(71, 59);
            this.textDestination.Name = "textDestination";
            this.textDestination.Size = new System.Drawing.Size(347, 20);
            this.textDestination.TabIndex = 6;
            this.textDestination.TextChanged += new System.EventHandler(this.TextDestinationTextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(224, 113);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(51, 28);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // checkMirror
            // 
            this.checkMirror.AutoSize = true;
            this.checkMirror.Checked = true;
            this.checkMirror.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMirror.Location = new System.Drawing.Point(12, 117);
            this.checkMirror.Name = "checkMirror";
            this.checkMirror.Size = new System.Drawing.Size(52, 17);
            this.checkMirror.TabIndex = 8;
            this.checkMirror.Text = "Mirror";
            this.checkMirror.UseVisualStyleBackColor = true;
            // 
            // checkCreateDest
            // 
            this.checkCreateDest.AutoSize = true;
            this.checkCreateDest.Checked = true;
            this.checkCreateDest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCreateDest.Location = new System.Drawing.Point(12, 94);
            this.checkCreateDest.Name = "checkCreateDest";
            this.checkCreateDest.Size = new System.Drawing.Size(140, 17);
            this.checkCreateDest.TabIndex = 9;
            this.checkCreateDest.Text = "Create destination folder";
            this.checkCreateDest.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(439, 108);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(27, 25);
            this.btnHelp.TabIndex = 10;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // ChkDontRetry
            // 
            this.ChkDontRetry.AutoSize = true;
            this.ChkDontRetry.Location = new System.Drawing.Point(12, 137);
            this.ChkDontRetry.Name = "ChkDontRetry";
            this.ChkDontRetry.Size = new System.Drawing.Size(69, 17);
            this.ChkDontRetry.TabIndex = 11;
            this.ChkDontRetry.Text = "Retry = 0";
            this.ChkDontRetry.UseVisualStyleBackColor = true;
            // 
            // btnSourceFile
            // 
            this.btnSourceFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSourceFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSourceFile.Image")));
            this.btnSourceFile.Location = new System.Drawing.Point(455, 17);
            this.btnSourceFile.Name = "btnSourceFile";
            this.btnSourceFile.Size = new System.Drawing.Size(25, 25);
            this.btnSourceFile.TabIndex = 12;
            this.btnSourceFile.UseVisualStyleBackColor = true;
            this.btnSourceFile.Click += new System.EventHandler(this.BtnSourceFileClick);
            // 
            // checkProgress
            // 
            this.checkProgress.AutoSize = true;
            this.checkProgress.Location = new System.Drawing.Point(87, 137);
            this.checkProgress.Name = "checkProgress";
            this.checkProgress.Size = new System.Drawing.Size(94, 17);
            this.checkProgress.TabIndex = 13;
            this.checkProgress.Text = "ShowProgress";
            this.checkProgress.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 166);
            this.Controls.Add(this.checkProgress);
            this.Controls.Add(this.btnSourceFile);
            this.Controls.Add(this.ChkDontRetry);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.checkCreateDest);
            this.Controls.Add(this.checkMirror);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textDestination);
            this.Controls.Add(this.textSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.btnSource);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "RoboCopy GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button btnSourceFile;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog Source_FileDialog;

        #endregion

        private System.Windows.Forms.FolderBrowserDialog Source_folderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog Destination_folderBrowserDialog;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSource;
        private System.Windows.Forms.TextBox textDestination;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox checkMirror;
        private System.Windows.Forms.CheckBox checkCreateDest;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.CheckBox ChkDontRetry;
        
        
        void TextSourceTextChanged(object sender, System.EventArgs e)
        {
            toolTip1.SetToolTip(this.textSource, textSource.Text);
        }
        
        void TextDestinationTextChanged(object sender, System.EventArgs e)
        {
            toolTip1.SetToolTip(this.textDestination, textDestination.Text);
        }

        private System.Windows.Forms.CheckBox checkProgress;
    }
}

