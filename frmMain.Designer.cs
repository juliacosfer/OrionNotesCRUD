
namespace OrionNotesCRUD
{
	partial class frmMain
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

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.mstMenu = new System.Windows.Forms.MenuStrip();
			this.tsmMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.mstMenuAbrir = new System.Windows.Forms.ToolStripMenuItem();
			this.mstDeleteTab = new System.Windows.Forms.ToolStripMenuItem();
			this.tbcWokrPlace = new System.Windows.Forms.TabControl();
			this.mstMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// mstMenu
			// 
			this.mstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenu,
            this.mstDeleteTab});
			this.mstMenu.Location = new System.Drawing.Point(0, 0);
			this.mstMenu.Name = "mstMenu";
			this.mstMenu.Size = new System.Drawing.Size(834, 24);
			this.mstMenu.TabIndex = 0;
			this.mstMenu.Text = "Menu Main";
			// 
			// tsmMenu
			// 
			this.tsmMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstMenuAbrir});
			this.tsmMenu.Name = "tsmMenu";
			this.tsmMenu.Size = new System.Drawing.Size(52, 20);
			this.tsmMenu.Text = "Pastas";
			// 
			// mstMenuAbrir
			// 
			this.mstMenuAbrir.Name = "mstMenuAbrir";
			this.mstMenuAbrir.Size = new System.Drawing.Size(180, 22);
			this.mstMenuAbrir.Text = "Abrir";
			this.mstMenuAbrir.Click += new System.EventHandler(this.mstMenuAbrir_Click);
			// 
			// mstDeleteTab
			// 
			this.mstDeleteTab.Enabled = false;
			this.mstDeleteTab.Name = "mstDeleteTab";
			this.mstDeleteTab.Size = new System.Drawing.Size(78, 20);
			this.mstDeleteTab.Text = "Excluir Aba";
			this.mstDeleteTab.Click += new System.EventHandler(this.mstDeleteTab_Click);
			// 
			// tbcWokrPlace
			// 
			this.tbcWokrPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbcWokrPlace.Location = new System.Drawing.Point(12, 27);
			this.tbcWokrPlace.Name = "tbcWokrPlace";
			this.tbcWokrPlace.SelectedIndex = 0;
			this.tbcWokrPlace.Size = new System.Drawing.Size(810, 622);
			this.tbcWokrPlace.TabIndex = 1;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 661);
			this.Controls.Add(this.tbcWokrPlace);
			this.Controls.Add(this.mstMenu);
			this.MainMenuStrip = this.mstMenu;
			this.MaximumSize = new System.Drawing.Size(850, 700);
			this.MinimumSize = new System.Drawing.Size(850, 700);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gerenciador de Notas";
			this.mstMenu.ResumeLayout(false);
			this.mstMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mstMenu;
		private System.Windows.Forms.ToolStripMenuItem tsmMenu;
		private System.Windows.Forms.ToolStripMenuItem mstMenuAbrir;
		private System.Windows.Forms.TabControl tbcWokrPlace;
		private System.Windows.Forms.ToolStripMenuItem mstDeleteTab;
	}
}

