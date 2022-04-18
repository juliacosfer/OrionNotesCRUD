
namespace OrionNotesCRUD
{
	partial class frmFolderArqManager
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
			this.lstArquivos = new System.Windows.Forms.ListBox();
			this.txtArquivo = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstArquivos
			// 
			this.lstArquivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstArquivos.FormattingEnabled = true;
			this.lstArquivos.Location = new System.Drawing.Point(12, 16);
			this.lstArquivos.Name = "lstArquivos";
			this.lstArquivos.Size = new System.Drawing.Size(280, 537);
			this.lstArquivos.TabIndex = 0;
			// 
			// txtArquivo
			// 
			this.txtArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtArquivo.Enabled = false;
			this.txtArquivo.Location = new System.Drawing.Point(309, 16);
			this.txtArquivo.Multiline = true;
			this.txtArquivo.Name = "txtArquivo";
			this.txtArquivo.Size = new System.Drawing.Size(466, 484);
			this.txtArquivo.TabIndex = 1;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.BackColor = System.Drawing.Color.MediumAquamarine;
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.Enabled = false;
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
			this.btnSave.FlatAppearance.BorderSize = 2;
			this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSave.Location = new System.Drawing.Point(309, 508);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(230, 45);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "SALVAR";
			this.btnSave.UseVisualStyleBackColor = false;
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.BackColor = System.Drawing.Color.Salmon;
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.Enabled = false;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
			this.btnDelete.FlatAppearance.BorderSize = 2;
			this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(545, 508);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(230, 45);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "DELETAR";
			this.btnDelete.UseVisualStyleBackColor = false;
			// 
			// frmFolderArqManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtArquivo);
			this.Controls.Add(this.lstArquivos);
			this.Name = "frmFolderArqManager";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstArquivos;
		private System.Windows.Forms.TextBox txtArquivo;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDelete;
	}

}