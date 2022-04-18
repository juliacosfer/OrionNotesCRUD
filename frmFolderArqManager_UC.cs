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
	public partial class frmFolderArqManager_UC : UserControl
	{
		private List<string> namesArqv;
		private List<string> paths;
		private string folderPath;
		private void LoadListBox() {
			lstArquivos.Items.Clear();
			foreach (string name in this.namesArqv) lstArquivos.Items.Add(name);
		}

		public void addArqList(string arqPath)
		{
			this.paths.Add(arqPath);
			this.namesArqv.Add(arqPath.Remove(0, this.folderPath.Length + 1));
		}

		public frmFolderArqManager_UC(List<string> arqs, List<string> names, string path)
		{
			InitializeComponent();
			this.namesArqv = names;
			this.paths = arqs;
			this.folderPath = path;

			LoadListBox();
		}

		private void btnAddArqv_Click(object sender, EventArgs e)
		{
			frmDialogTextBox x = new frmDialogTextBox(this.folderPath, this);
			x.ShowDialog();
			this.LoadListBox();
		}

		private void lstArquivos_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedArq = this.paths[lstArquivos.SelectedIndex];

			txtArquivo.Enabled = true;
			btnSave.Enabled = true;
			btnDelete.Enabled = true;

			txtArquivo.Text = "";

			txtArquivo.Text = File.ReadAllText(selectedArq);
		}
	}
}
