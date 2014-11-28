
namespace RoboCopy_GUI
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using System.Xml;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
            this.ComsumeInitFile();

            this.toolTip1.SetToolTip(this.btnSource, "Browse for a folder to copy");
            this.toolTip1.SetToolTip(this.btnSourceFile, "Browse for a file to copy");
            this.toolTip1.SetToolTip(this.btnOK, "Launch the copy");
            this.toolTip1.SetToolTip(this.btnDestination, "Browse for a destination folder");
            this.toolTip1.SetToolTip(this.btnHelp, "About");
        }

        void BtnSourceFileClick(object sender, System.EventArgs e)
        {
            if (this.Source_FileDialog.ShowDialog() == DialogResult.OK)
                this.textSource.Text = this.Source_FileDialog.FileName;
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            this.Source_folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            if (this.Source_folderBrowserDialog.ShowDialog() == DialogResult.OK)
                this.textSource.Text = this.Source_folderBrowserDialog.SelectedPath;
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            this.Destination_folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            if (this.Destination_folderBrowserDialog.ShowDialog() == DialogResult.OK)
                this.textDestination.Text = this.Destination_folderBrowserDialog.SelectedPath;
        }

        private void ComsumeInitFile()
        {
            try
            {
                System.Reflection.Assembly currentAssembly = System.Reflection.Assembly.GetAssembly(typeof(MainForm));
                FileInfo assemblyFileInfo = new FileInfo(currentAssembly.Location);

                if (File.Exists(assemblyFileInfo.DirectoryName + @"\init.xml"))
                {
                    XmlDocument doc = new XmlDocument();
                    StreamReader sr = new StreamReader(assemblyFileInfo.DirectoryName + @"\init.xml", true);
                    doc.Load(sr);

                    XmlNode docElement = doc.DocumentElement;

                    XmlNode node;
                    node = docElement.SelectSingleNode("/Robocopy_GUI/Source");
                    this.textSource.Text = node.InnerText;

                    node = docElement.SelectSingleNode("/Robocopy_GUI/Destination");
                    this.textDestination.Text = node.InnerText;

                    sr.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n" + ex.StackTrace, ex.Source);
            }
        }
        private void DumpInputs()
        {
            try
            {
                System.Reflection.Assembly currentAssembly = System.Reflection.Assembly.GetAssembly(typeof(MainForm));
                FileInfo assemblyFileInfo = new FileInfo(currentAssembly.Location);

                System.Xml.XmlTextWriter xw = new System.Xml.XmlTextWriter(assemblyFileInfo.DirectoryName + @"\init.xml", null);

                xw.Formatting = System.Xml.Formatting.Indented;
                xw.Indentation = 2;
                xw.WriteStartDocument();
                xw.WriteStartElement("Robocopy_GUI");


                xw.WriteStartElement("Source");
                xw.WriteString(this.textSource.Text);
                xw.WriteEndElement();

                xw.WriteStartElement("Destination");
                xw.WriteString(this.textDestination.Text);
                xw.WriteEndElement();


                xw.WriteEndElement();
                xw.WriteEndDocument();
                xw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace, ex.Source);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string stArgs;

            // Remove extra "" added by "Copy as path" explorer extension
            this.textSource.Text = this.textSource.Text.Trim('"');
            this.textDestination.Text = this.textDestination.Text.Trim('"');

            this.DumpInputs();

            // check if the source is a file or a directory
            bool bIsFile = true;

            if (Directory.Exists(this.textSource.Text))
                bIsFile = false;

            // Extract the source directory name, and copy it in the destination
            string stSourceName = this.textSource.Text;
            if (bIsFile == true)
                stSourceName = Path.GetDirectoryName(this.textSource.Text);
            string[] stMatchPath = Regex.Split(stSourceName, @"\\");
            string[] stMatchPathDest = Regex.Split(this.textDestination.Text, @"\\");
            if (this.checkCreateDest.Checked)
            {
                if (string.Compare(stMatchPath[stMatchPath.Length - 1], stMatchPathDest[stMatchPathDest.Length - 1], true) != 0)
                    this.textDestination.Text += @"\" + stMatchPath[stMatchPath.Length - 1];
            }

            if (bIsFile == false)
            {
                stArgs = "\"" + this.textSource.Text + "\"" + " " +
                         "\"" + this.textDestination.Text + "\"" + " ";
            }
            else
            {
                stArgs = "\"" + Path.GetDirectoryName(this.textSource.Text) + "\"" + " " +
                    "\"" + this.textDestination.Text + "\"" + " " + "\"" + Path.GetFileName(this.textSource.Text) + "\"" + " ";
            }

            if (this.ChkDontRetry.Checked)
                stArgs += " /R:0";

            if (this.checkMirror.Checked && bIsFile == false)
                stArgs += " /MIR";

            if (!this.checkProgress.Checked)
                stArgs += " /NP";

            stArgs += "  /ETA /Z /TEE /LOG:\"" + Environment.GetEnvironmentVariable("TEMP") + @"\Robocopy_GUI" + stMatchPath[stMatchPath.Length - 1] + ".log\"";

            System.IO.StreamWriter stLog = null;
            System.IO.Stream sr = null;

            sr = System.IO.File.Open(Environment.GetEnvironmentVariable("TEMP") + @"\Robocopy_GUI_Last_Command.bat", System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.Write);
            stLog = new System.IO.StreamWriter(sr);
            stLog.Write("Robocopy.exe " + stArgs);

            stLog.Dispose();
            stLog.Close();
            stLog = null;


            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "Robocopy.exe";
            proc.StartInfo.Arguments = stArgs;

            proc.Start();

            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Infos oAbout = new Infos();

            oAbout.Show();
        }
    }
}
