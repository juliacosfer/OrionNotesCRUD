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
	public partial class frmDialogTextBox : Form
	{
		private string folderPath;
		frmFolderArqManager_UC antG;

		public frmDialogTextBox(string path, frmFolderArqManager_UC ant)
		{
			InitializeComponent();

			this.folderPath = path;
			antG = ant;
		}

		private void txtName_TextChanged(object sender, EventArgs e)
		{
			if (!txtName.Text.Equals("")) btnAddArqv.Enabled = true;
			else btnAddArqv.Enabled = false;
		}

		private void btnAddArqv_Click(object sender, EventArgs e)
		{
			string n = "\\" + txtName.Text + ".txt";
			File.Create(this.folderPath + n).Close();
			antG.addArqList(this.folderPath + n);
			this.Close();
		}
	}
}
