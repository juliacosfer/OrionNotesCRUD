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

namespace OrionNotesCRUD
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void mstMenuAbrir_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog a = new FolderBrowserDialog();
			a.ShowDialog();

			/*
			 * 
			 *		Orientar a objeto o código que pega o caminho da pasta
			 *		pra facilitar o uso em outras forms caso necessário
			 *
			 */

			string folderPath = a.SelectedPath;
			string[] arqsvar = Directory.GetFiles(folderPath, "*.txt");
			List<string> arqsPaths = new List<string>();
			List<string> names = new List<string>();

			foreach (string arq in arqsvar)
			{
				names.Add(arq.Remove(0, folderPath.Length + 1));
				arqsPaths.Add(arq);
			}
			

			frmFolderArqManager_UC windowfam = new frmFolderArqManager_UC(arqsPaths, names, folderPath);
			TabPage tb = new TabPage();
			tb.Name = folderPath;
			tb.Text = folderPath;
			tb.Controls.Add(windowfam);

			tbcWokrPlace.TabPages.Add(tb);
			mstDeleteTab.Enabled = true;
		}

		private void mstDeleteTab_Click(object sender, EventArgs e)
		{
			tbcWokrPlace.TabPages.Remove(tbcWokrPlace.SelectedTab);
		}
	}
}
