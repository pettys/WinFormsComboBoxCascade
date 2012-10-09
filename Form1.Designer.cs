namespace CascadingComboSpike
{
	partial class Form1
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
			this._numberClass = new System.Windows.Forms.ComboBox();
			this._number = new System.Windows.Forms.ComboBox();
			this._letter = new System.Windows.Forms.ComboBox();
			this._sector = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _numberClass
			// 
			this._numberClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._numberClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._numberClass.FormattingEnabled = true;
			this._numberClass.Items.AddRange(new object[] {
            "<select one>",
            "Even numbers",
            "Odd numbers",
            "Multiples of 3",
            "Prime numbers"});
			this._numberClass.Location = new System.Drawing.Point(92, 35);
			this._numberClass.Name = "_numberClass";
			this._numberClass.Size = new System.Drawing.Size(121, 21);
			this._numberClass.TabIndex = 0;
			// 
			// _number
			// 
			this._number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._number.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._number.FormattingEnabled = true;
			this._number.Location = new System.Drawing.Point(92, 62);
			this._number.Name = "_number";
			this._number.Size = new System.Drawing.Size(121, 21);
			this._number.TabIndex = 1;
			// 
			// _letter
			// 
			this._letter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._letter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._letter.FormattingEnabled = true;
			this._letter.Location = new System.Drawing.Point(92, 89);
			this._letter.Name = "_letter";
			this._letter.Size = new System.Drawing.Size(121, 21);
			this._letter.TabIndex = 2;
			// 
			// _sector
			// 
			this._sector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._sector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._sector.FormattingEnabled = true;
			this._sector.Location = new System.Drawing.Point(92, 116);
			this._sector.Name = "_sector";
			this._sector.Size = new System.Drawing.Size(121, 21);
			this._sector.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Location = new System.Drawing.Point(15, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Number class";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Location = new System.Drawing.Point(42, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Number";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Location = new System.Drawing.Point(52, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Letter";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label4.Location = new System.Drawing.Point(52, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Sector";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(410, 312);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._sector);
			this.Controls.Add(this._letter);
			this.Controls.Add(this._number);
			this.Controls.Add(this._numberClass);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox _numberClass;
		private System.Windows.Forms.ComboBox _number;
		private System.Windows.Forms.ComboBox _letter;
		private System.Windows.Forms.ComboBox _sector;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}

