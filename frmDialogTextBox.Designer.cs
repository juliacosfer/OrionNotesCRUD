
namespace OrionNotesCRUD
{
	partial class frmDialogTextBox
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnAddArqv = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(68, 13);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(204, 20);
			this.txtName.TabIndex = 1;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// btnAddArqv
			// 
			this.btnAddArqv.BackColor = System.Drawing.Color.MediumPurple;
			this.btnAddArqv.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddArqv.Enabled = false;
			this.btnAddArqv.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
			this.btnAddArqv.FlatAppearance.BorderSize = 2;
			this.btnAddArqv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle;
			this.btnAddArqv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
			this.btnAddArqv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddArqv.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddArqv.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnAddArqv.Location = new System.Drawing.Point(29, 44);
			this.btnAddArqv.Name = "btnAddArqv";
			this.btnAddArqv.Size = new System.Drawing.Size(230, 45);
			this.btnAddArqv.TabIndex = 5;
			this.btnAddArqv.Text = "Adicionar Arquivo";
			this.btnAddArqv.UseVisualStyleBackColor = false;
			this.btnAddArqv.Click += new System.EventHandler(this.btnAddArqv_Click);
			// 
			// frmDialogTextBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 96);
			this.Controls.Add(this.btnAddArqv);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(300, 135);
			this.MinimumSize = new System.Drawing.Size(300, 135);
			this.Name = "frmDialogTextBox";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmDialogTextBox";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnAddArqv;
	}
}