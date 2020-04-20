namespace EmploymentApp
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
			if(disposing && (components != null))
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
			this._txtLastName = new System.Windows.Forms.Label();
			this._txtEnterLastName = new System.Windows.Forms.TextBox();
			this._txtEnterName = new System.Windows.Forms.TextBox();
			this._txtName = new System.Windows.Forms.Label();
			this._rdiMale = new System.Windows.Forms.RadioButton();
			this._txtSex = new System.Windows.Forms.Label();
			this._rdiFemale = new System.Windows.Forms.RadioButton();
			this._grpInfo = new System.Windows.Forms.GroupBox();
			this._txtPosition = new System.Windows.Forms.Label();
			this._cmbHowMuchExp = new System.Windows.Forms.ComboBox();
			this._cmbScopeEducation = new System.Windows.Forms.ComboBox();
			this._cmbLevelEnglish = new System.Windows.Forms.ComboBox();
			this._txtScopeEducation = new System.Windows.Forms.Label();
			this._txtHowMuchExp = new System.Windows.Forms.Label();
			this._txtLevelEnglish = new System.Windows.Forms.Label();
			this._chkExperience = new System.Windows.Forms.CheckBox();
			this._chkHighEducation = new System.Windows.Forms.CheckBox();
			this._chkEnglishProficiency = new System.Windows.Forms.CheckBox();
			this._txtExperience = new System.Windows.Forms.Label();
			this._txtHighEducation = new System.Windows.Forms.Label();
			this._txtEnglishProficiency = new System.Windows.Forms.Label();
			this._cmbPosition = new System.Windows.Forms.ComboBox();
			this._btnSave = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this._grpInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// _txtLastName
			// 
			this._txtLastName.AutoSize = true;
			this._txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtLastName.Location = new System.Drawing.Point(6, 16);
			this._txtLastName.Name = "_txtLastName";
			this._txtLastName.Size = new System.Drawing.Size(96, 24);
			this._txtLastName.TabIndex = 0;
			this._txtLastName.Text = "Фамилия:";
			// 
			// _txtEnterLastName
			// 
			this._txtEnterLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtEnterLastName.Location = new System.Drawing.Point(103, 16);
			this._txtEnterLastName.Name = "_txtEnterLastName";
			this._txtEnterLastName.Size = new System.Drawing.Size(128, 26);
			this._txtEnterLastName.TabIndex = 1;
			this._txtEnterLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtEnterLastName_KeyPress);
			// 
			// _txtEnterName
			// 
			this._txtEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtEnterName.Location = new System.Drawing.Point(103, 48);
			this._txtEnterName.Name = "_txtEnterName";
			this._txtEnterName.Size = new System.Drawing.Size(128, 26);
			this._txtEnterName.TabIndex = 3;
			this._txtEnterName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtEnterName_KeyPress);
			// 
			// _txtName
			// 
			this._txtName.AutoSize = true;
			this._txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtName.Location = new System.Drawing.Point(6, 48);
			this._txtName.Name = "_txtName";
			this._txtName.Size = new System.Drawing.Size(96, 24);
			this._txtName.TabIndex = 2;
			this._txtName.Text = "         Имя:";
			// 
			// _rdiMale
			// 
			this._rdiMale.AutoSize = true;
			this._rdiMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._rdiMale.Location = new System.Drawing.Point(61, 83);
			this._rdiMale.Name = "_rdiMale";
			this._rdiMale.Size = new System.Drawing.Size(84, 20);
			this._rdiMale.TabIndex = 4;
			this._rdiMale.TabStop = true;
			this._rdiMale.Text = "Мужской";
			this._rdiMale.UseVisualStyleBackColor = true;
			// 
			// _txtSex
			// 
			this._txtSex.AutoSize = true;
			this._txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtSex.Location = new System.Drawing.Point(6, 79);
			this._txtSex.Name = "_txtSex";
			this._txtSex.Size = new System.Drawing.Size(49, 24);
			this._txtSex.TabIndex = 5;
			this._txtSex.Text = "Пол:";
			// 
			// _rdiFemale
			// 
			this._rdiFemale.AutoSize = true;
			this._rdiFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._rdiFemale.Location = new System.Drawing.Point(146, 83);
			this._rdiFemale.Name = "_rdiFemale";
			this._rdiFemale.Size = new System.Drawing.Size(85, 20);
			this._rdiFemale.TabIndex = 6;
			this._rdiFemale.TabStop = true;
			this._rdiFemale.Text = "Женский";
			this._rdiFemale.UseVisualStyleBackColor = true;
			// 
			// _grpInfo
			// 
			this._grpInfo.Controls.Add(this._btnSave);
			this._grpInfo.Controls.Add(this._cmbPosition);
			this._grpInfo.Controls.Add(this._chkExperience);
			this._grpInfo.Controls.Add(this._txtPosition);
			this._grpInfo.Controls.Add(this._chkHighEducation);
			this._grpInfo.Controls.Add(this._chkEnglishProficiency);
			this._grpInfo.Controls.Add(this._txtLevelEnglish);
			this._grpInfo.Controls.Add(this._txtExperience);
			this._grpInfo.Controls.Add(this._cmbHowMuchExp);
			this._grpInfo.Controls.Add(this._txtHighEducation);
			this._grpInfo.Controls.Add(this._txtHowMuchExp);
			this._grpInfo.Controls.Add(this._txtEnglishProficiency);
			this._grpInfo.Controls.Add(this._cmbScopeEducation);
			this._grpInfo.Controls.Add(this._txtScopeEducation);
			this._grpInfo.Controls.Add(this._txtLastName);
			this._grpInfo.Controls.Add(this._cmbLevelEnglish);
			this._grpInfo.Controls.Add(this._rdiFemale);
			this._grpInfo.Controls.Add(this._txtEnterLastName);
			this._grpInfo.Controls.Add(this._txtSex);
			this._grpInfo.Controls.Add(this._txtName);
			this._grpInfo.Controls.Add(this._rdiMale);
			this._grpInfo.Controls.Add(this._txtEnterName);
			this._grpInfo.ForeColor = System.Drawing.SystemColors.ControlText;
			this._grpInfo.Location = new System.Drawing.Point(-1, 12);
			this._grpInfo.Name = "_grpInfo";
			this._grpInfo.Size = new System.Drawing.Size(804, 155);
			this._grpInfo.TabIndex = 7;
			this._grpInfo.TabStop = false;
			// 
			// _txtPosition
			// 
			this._txtPosition.AutoSize = true;
			this._txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtPosition.Location = new System.Drawing.Point(6, 114);
			this._txtPosition.Name = "_txtPosition";
			this._txtPosition.Size = new System.Drawing.Size(112, 24);
			this._txtPosition.TabIndex = 19;
			this._txtPosition.Text = "Должность";
			// 
			// _cmbHowMuchExp
			// 
			this._cmbHowMuchExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbHowMuchExp.FormattingEnabled = true;
			this._cmbHowMuchExp.Location = new System.Drawing.Point(704, 72);
			this._cmbHowMuchExp.Name = "_cmbHowMuchExp";
			this._cmbHowMuchExp.Size = new System.Drawing.Size(87, 21);
			this._cmbHowMuchExp.TabIndex = 18;
			// 
			// _cmbScopeEducation
			// 
			this._cmbScopeEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbScopeEducation.FormattingEnabled = true;
			this._cmbScopeEducation.Location = new System.Drawing.Point(704, 48);
			this._cmbScopeEducation.Name = "_cmbScopeEducation";
			this._cmbScopeEducation.Size = new System.Drawing.Size(87, 21);
			this._cmbScopeEducation.TabIndex = 17;
			// 
			// _cmbLevelEnglish
			// 
			this._cmbLevelEnglish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbLevelEnglish.FormattingEnabled = true;
			this._cmbLevelEnglish.Location = new System.Drawing.Point(704, 24);
			this._cmbLevelEnglish.Name = "_cmbLevelEnglish";
			this._cmbLevelEnglish.Size = new System.Drawing.Size(87, 21);
			this._cmbLevelEnglish.TabIndex = 16;
			// 
			// _txtScopeEducation
			// 
			this._txtScopeEducation.AutoSize = true;
			this._txtScopeEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtScopeEducation.Location = new System.Drawing.Point(491, 43);
			this._txtScopeEducation.Name = "_txtScopeEducation";
			this._txtScopeEducation.Size = new System.Drawing.Size(207, 24);
			this._txtScopeEducation.TabIndex = 15;
			this._txtScopeEducation.Text = "              Образование:";
			// 
			// _txtHowMuchExp
			// 
			this._txtHowMuchExp.AutoSize = true;
			this._txtHowMuchExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtHowMuchExp.Location = new System.Drawing.Point(491, 67);
			this._txtHowMuchExp.Name = "_txtHowMuchExp";
			this._txtHowMuchExp.Size = new System.Drawing.Size(209, 24);
			this._txtHowMuchExp.TabIndex = 14;
			this._txtHowMuchExp.Text = "                             Опыт:";
			// 
			// _txtLevelEnglish
			// 
			this._txtLevelEnglish.AutoSize = true;
			this._txtLevelEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtLevelEnglish.Location = new System.Drawing.Point(491, 19);
			this._txtLevelEnglish.Name = "_txtLevelEnglish";
			this._txtLevelEnglish.Size = new System.Drawing.Size(210, 24);
			this._txtLevelEnglish.TabIndex = 13;
			this._txtLevelEnglish.Text = "Уровень английского:";
			// 
			// _chkExperience
			// 
			this._chkExperience.AutoSize = true;
			this._chkExperience.Location = new System.Drawing.Point(452, 75);
			this._chkExperience.Name = "_chkExperience";
			this._chkExperience.Size = new System.Drawing.Size(15, 14);
			this._chkExperience.TabIndex = 12;
			this._chkExperience.UseVisualStyleBackColor = true;
			// 
			// _chkHighEducation
			// 
			this._chkHighEducation.AutoSize = true;
			this._chkHighEducation.Location = new System.Drawing.Point(452, 51);
			this._chkHighEducation.Name = "_chkHighEducation";
			this._chkHighEducation.Size = new System.Drawing.Size(15, 14);
			this._chkHighEducation.TabIndex = 11;
			this._chkHighEducation.UseVisualStyleBackColor = true;
			// 
			// _chkEnglishProficiency
			// 
			this._chkEnglishProficiency.AutoSize = true;
			this._chkEnglishProficiency.Location = new System.Drawing.Point(452, 27);
			this._chkEnglishProficiency.Name = "_chkEnglishProficiency";
			this._chkEnglishProficiency.Size = new System.Drawing.Size(15, 14);
			this._chkEnglishProficiency.TabIndex = 10;
			this._chkEnglishProficiency.UseVisualStyleBackColor = true;
			// 
			// _txtExperience
			// 
			this._txtExperience.AutoSize = true;
			this._txtExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtExperience.Location = new System.Drawing.Point(237, 67);
			this._txtExperience.Name = "_txtExperience";
			this._txtExperience.Size = new System.Drawing.Size(195, 24);
			this._txtExperience.TabIndex = 9;
			this._txtExperience.Text = "Опыт на должности:";
			// 
			// _txtHighEducation
			// 
			this._txtHighEducation.AutoSize = true;
			this._txtHighEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtHighEducation.Location = new System.Drawing.Point(237, 43);
			this._txtHighEducation.Name = "_txtHighEducation";
			this._txtHighEducation.Size = new System.Drawing.Size(209, 24);
			this._txtHighEducation.TabIndex = 8;
			this._txtHighEducation.Text = "Высшее образование:";
			// 
			// _txtEnglishProficiency
			// 
			this._txtEnglishProficiency.AutoSize = true;
			this._txtEnglishProficiency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtEnglishProficiency.Location = new System.Drawing.Point(237, 19);
			this._txtEnglishProficiency.Name = "_txtEnglishProficiency";
			this._txtEnglishProficiency.Size = new System.Drawing.Size(199, 24);
			this._txtEnglishProficiency.TabIndex = 7;
			this._txtEnglishProficiency.Text = "Знание английского:";
			// 
			// _cmbPosition
			// 
			this._cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbPosition.FormattingEnabled = true;
			this._cmbPosition.Location = new System.Drawing.Point(124, 117);
			this._cmbPosition.Name = "_cmbPosition";
			this._cmbPosition.Size = new System.Drawing.Size(176, 21);
			this._cmbPosition.TabIndex = 20;
			// 
			// _btnSave
			// 
			this._btnSave.Location = new System.Drawing.Point(716, 114);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(75, 23);
			this._btnSave.TabIndex = 21;
			this._btnSave.Text = "Готово";
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(9, 173);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(781, 215);
			this.dataGridView.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this._grpInfo);
			this.Name = "Form1";
			this.Text = "Трудоустройство";
			this._grpInfo.ResumeLayout(false);
			this._grpInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label _txtLastName;
		private System.Windows.Forms.TextBox _txtEnterLastName;
		private System.Windows.Forms.TextBox _txtEnterName;
		private System.Windows.Forms.Label _txtName;
		private System.Windows.Forms.RadioButton _rdiMale;
		private System.Windows.Forms.Label _txtSex;
		private System.Windows.Forms.RadioButton _rdiFemale;
		private System.Windows.Forms.GroupBox _grpInfo;
		private System.Windows.Forms.CheckBox _chkEnglishProficiency;
		private System.Windows.Forms.Label _txtExperience;
		private System.Windows.Forms.Label _txtHighEducation;
		private System.Windows.Forms.Label _txtEnglishProficiency;
		private System.Windows.Forms.CheckBox _chkExperience;
		private System.Windows.Forms.CheckBox _chkHighEducation;
		private System.Windows.Forms.ComboBox _cmbHowMuchExp;
		private System.Windows.Forms.ComboBox _cmbScopeEducation;
		private System.Windows.Forms.ComboBox _cmbLevelEnglish;
		private System.Windows.Forms.Label _txtScopeEducation;
		private System.Windows.Forms.Label _txtHowMuchExp;
		private System.Windows.Forms.Label _txtLevelEnglish;
		private System.Windows.Forms.Label _txtPosition;
		private System.Windows.Forms.ComboBox _cmbPosition;
		private System.Windows.Forms.Button _btnSave;
		private System.Windows.Forms.DataGridView dataGridView;
	}
}

