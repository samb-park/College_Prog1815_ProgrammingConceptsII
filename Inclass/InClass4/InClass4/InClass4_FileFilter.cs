using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClass4
{
    public partial class InClass4_FileFilter : Form
    {
        public InClass4_FileFilter()
        {
            InitializeComponent();
        }

        string path = "", newPath = "";
        List<string> subFolderNames = new List<string>();

        // confirm the source folder exists, 
        // - create target folder if it doesn't exist
        private void btnConfirmPath_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            if (string.IsNullOrWhiteSpace(txtSourcePath.Text))
                lblMessage.Text += "no source path specified\n";
            else
            {
                path = txtSourcePath.Text;
                if (!Directory.Exists(path))
                    lblMessage.Text += "source path does not exist\n";
            }

            if (string.IsNullOrWhiteSpace(txtTargetPath.Text))
                lblMessage.Text += "no target path specified\n";
            else
            {
                newPath = txtTargetPath.Text;
                if (Directory.Exists(newPath) && chkClearTarget.Checked)
                    Directory.Delete(newPath, true);
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
            }
            if (lblMessage.Text == "")
            {
                btnListDirectories.Enabled = true;
                btnListFiles.Enabled = true;
            }
        }

        // list all subfolders in the source folder
        // - strip off the source path so the subfolder name can be used later
        private void btnListDirectories_Click(object sender, EventArgs e)
        {
            SearchOption subs = SearchOption.TopDirectoryOnly;
            if (chkSubDirectories.Checked) subs = SearchOption.AllDirectories;

            txtResults.Text = "";
            var directories = Directory.EnumerateDirectories(path, "*", subs);
            subFolderNames = new List<string>();
            foreach (var directory in directories)
            {
                if(directory == newPath)
				{
                    continue;
				}

                Int32 index = directory.LastIndexOf("\\") + 1;
                string name = directory.Substring(index);
                subFolderNames.Add(name);
                txtResults.Text += name + "\n";
            }
        }

        // for each subfolder found in the source folder (listed in subFolderNames):
        // - list all the files that fit the filter criteria
        // - loop through the resulting list of file names:
        //   - copy each file to the target folder
        //   - appending the original subfolder's name onto the file name
        private void btnListFiles_Click(object sender, EventArgs e)
        {
			lblMessage.Text = txtResults.Text = "";

            var directoriesChecked = chkSubDirectories.Checked;
            var subFolderNamesTemporary = subFolderNames;

            if (directoriesChecked)
			{
                chkSubDirectories.Checked = false;
                btnListDirectories_Click(sender, e);
                txtResults.Text = "";
            }

            chkSubDirectories.Checked = directoriesChecked;

            foreach (string subfolderName in subFolderNames)
			{
				//search  "path + subfoldername" recursively
				// - for a file matching wildcard string
				//copy the file to the target folder
				// - adding the sufolder's name to the filename
				//list the new filenames in lbl Message

				var sourcePath = path + "\\" + subfolderName;
				var files = Directory.EnumerateFiles(sourcePath, txtFilter.Text, SearchOption.AllDirectories);

				try
				{
					foreach (var file in files)
					{
						txtResults.Text += subfolderName + " " + Path.GetFileName(file) + "\n";
						var destination = newPath + "\\" + subfolderName + " " + Path.GetFileName(file);

						if (!File.Exists(destination))
						{
							File.Copy(file, destination);
						}
					}
				}
				catch (Exception ex)
				{
					lblMessage.Text = $"Exception Error {ex.Message}";

				}
			}

            subFolderNames = subFolderNamesTemporary;
        }

        

    }
}

