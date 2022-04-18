
namespace OrionNotesCRUD
{
	partial class frmFolderArqManager_UC
	{
		/// <summary> 
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Designer de Componentes

		/// <summary> 
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.lstArquivos = new System.Windows.Forms.ListBox();
			this.txtArquivo = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAddArqv = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstArquivos
			// 
			this.lstArquivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstArquivos.FormattingEnabled = true;
			this.lstArquivos.Location = new System.Drawing.Point(12, 15);
			this.lstArquivos.Name = "lstArquivos";
			this.lstArquivos.Size = new System.Drawing.Size(296, 524);
			this.lstArquivos.TabIndex = 0;
			this.lstArquivos.SelectedIndexChanged += new System.EventHandler(this.lstArquivos_SelectedIndexChanged);
			// 
			// txtArquivo
			// 
			this.txtArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtArquivo.Enabled = false;
			this.txtArquivo.Location = new System.Drawing.Point(325, 16);
			this.txtArquivo.Multiline = true;
			this.txtArquivo.Name = "txtArquivo";
			this.txtArquivo.Size = new System.Drawing.Size(466, 523);
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
			this.btnSave.Location = new System.Drawing.Point(325, 547);
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
			this.btnDelete.Location = new System.Drawing.Point(561, 547);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(230, 45);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "DELETAR";
			this.btnDelete.UseVisualStyleBackColor = false;
			// 
			// btnAddArqv
			// 
			this.btnAddArqv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddArqv.BackColor = System.Drawing.Color.MediumPurple;
			this.btnAddArqv.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddArqv.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
			this.btnAddArqv.FlatAppearance.BorderSize = 2;
			this.btnAddArqv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle;
			this.btnAddArqv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
			this.btnAddArqv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddArqv.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddArqv.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnAddArqv.Location = new System.Drawing.Point(45, 545);
			this.btnAddArqv.Name = "btnAddArqv";
			this.btnAddArqv.Size = new System.Drawing.Size(230, 45);
			this.btnAddArqv.TabIndex = 4;
			this.btnAddArqv.Text = "Adicionar Arquivo";
			this.btnAddArqv.UseVisualStyleBackColor = false;
			this.btnAddArqv.Click += new System.EventHandler(this.btnAddArqv_Click);
			// 
			// frmFolderArqManager_UC
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.Controls.Add(this.btnAddArqv);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtArquivo);
			this.Controls.Add(this.lstArquivos);
			this.MaximumSize = new System.Drawing.Size(800, 600);
			this.MinimumSize = new System.Drawing.Size(600, 300);
			this.Name = "frmFolderArqManager_UC";
			this.Size = new System.Drawing.Size(800, 600);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstArquivos;
		private System.Windows.Forms.TextBox txtArquivo;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAddArqv;
	}
}
