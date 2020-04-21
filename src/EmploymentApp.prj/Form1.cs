using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmploymentApp
{
	public partial class Form1 : Form
	{
		private int countRows = 0;
		public Form1()
		{
			InitializeComponent();

			_txtLevelEnglish.Enabled = false;
			_cmbLevelEnglish.Enabled = false;

			_txtScopeEducation.Enabled = false;
			_cmbScopeEducation.Enabled = false;

			_txtHowMuchExp.Enabled = false;
			_cmbHowMuchExp.Enabled = false;

			_cmbLevelEnglish.Items.AddRange(new string[] { "Elementary", "Pre-Intermediate", "Intermediate", "Upper Intermediate", "Advanced", "Mastery" });
			_cmbScopeEducation.Items.AddRange(new string[] { "IT", "Техническое", "Гуманитарное", "Менеджмент"});
			_cmbHowMuchExp.Items.AddRange(new string[] {"Более 6 мес.", "Более года", "Более 3-х лет", "Более 5-ти лет" });

			_cmbPosition.Items.AddRange(new string[] {"Системный администратор", "Программист", "Менеджер", "Директор" });

			// Изменения в checkBox.
			_chkEnglishProficiency.CheckedChanged += _chk_CheckedChanged;
			_chkHighEducation.CheckedChanged += _chk_CheckedChanged;
			_chkExperience.CheckedChanged += _chk_CheckedChanged;

			// Создаем колонки для таблицы.
			DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn lastNameCol = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn sexCol = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn englishCol = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn educationCol = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn expCol = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn positionCol = new DataGridViewTextBoxColumn();

			nameCol.Name = "Имя";
			lastNameCol.Name = "Фамилия";
			sexCol.Name = "Пол";
			englishCol.Name = "Знание английского";
			educationCol.Name = "Высшее образование";
			expCol.Name = "Опыт на должности";
			positionCol.Name = "Должность";

			dataGridView.Columns.AddRange(new DataGridViewTextBoxColumn[] {nameCol, lastNameCol, sexCol, englishCol, educationCol, expCol, positionCol });

			
		}

		private void _chk_CheckedChanged(object sender, EventArgs e)
		{
			if(_chkEnglishProficiency.Checked == true)
			{
				_txtLevelEnglish.Enabled = true;
				_cmbLevelEnglish.Enabled = true;
			}
			else
			{
				_cmbLevelEnglish.SelectedItem = null;
				_txtLevelEnglish.Enabled = false;
				_cmbLevelEnglish.Enabled = false;
			}

			if(_chkHighEducation.Checked == true)
			{
				_txtScopeEducation.Enabled = true;
				_cmbScopeEducation.Enabled = true;
			}
			else
			{
				_cmbScopeEducation.SelectedItem = null;
				_txtScopeEducation.Enabled = false;
				_cmbScopeEducation.Enabled = false;
			}

			if(_chkExperience.Checked == true)
			{
				_txtHowMuchExp.Enabled = true;
				_cmbHowMuchExp.Enabled = true;
			}
			else
			{
				_cmbHowMuchExp.SelectedItem = null;
				_txtHowMuchExp.Enabled = false;
				_cmbHowMuchExp.Enabled = false;
			}
		}

		private void _btnSave_Click(object sender, EventArgs e)
		{
			//Проверка на заполнение важных полей.
			if(_txtEnterLastName.Text == "")
			{
				MessageBox.Show("'Фамилия' - обязательное поле для ввода", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if(_txtEnterName.Text == "")
			{
				MessageBox.Show("'Имя' - обязательное поле для ввода", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if(!_rdiFemale.Checked && !_rdiMale.Checked)
			{
				MessageBox.Show("'Пол' - обязательное поле для ввода", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if(_cmbPosition.SelectedItem == null)
			{
				MessageBox.Show("'Должность' - обязательное поле для ввода", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if(_cmbLevelEnglish.Enabled && _cmbLevelEnglish.SelectedItem == null) 
			{
				MessageBox.Show("Укажите уровень владения выбранных вами компетенций", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if(_cmbScopeEducation.Enabled && _cmbScopeEducation.SelectedItem == null)
			{
				MessageBox.Show("Укажите уровень владения выбранных вами компетенций", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if(_cmbHowMuchExp.Enabled && _cmbHowMuchExp.SelectedItem == null)
			{
				MessageBox.Show("Укажите уровень владения выбранных вами компетенций", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			// Если все нужные поля заполнены.
			else
			{
				var result = MessageBox.Show("Сохранить данные?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Для следующей проверки какую кнопку нажмет пользователь.

				if(result == DialogResult.Yes)
				{
					dataGridView.Rows.Add();

					dataGridView[0, countRows].Value = _txtEnterName.Text;
					dataGridView[1, countRows].Value = _txtEnterLastName.Text;
					dataGridView[2, countRows].Value = _rdiFemale.Checked ? "Женский" : "Мужской";
					dataGridView[3, countRows].Value = _cmbLevelEnglish.SelectedItem == null ? "-" : _cmbLevelEnglish.SelectedItem.ToString();
					dataGridView[4, countRows].Value = _cmbScopeEducation.SelectedItem == null ? "-" : _cmbScopeEducation.SelectedItem.ToString();
					dataGridView[5, countRows].Value = _cmbHowMuchExp.SelectedItem == null ? "-" : _cmbHowMuchExp.SelectedItem.ToString();
					dataGridView[6, countRows].Value = _cmbPosition.SelectedItem.ToString();

					countRows++;
				}
			}

		}

		private void _txtEnterLastName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
			{
				e.Handled = true;
			}
		}

		private void _txtEnterName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
			{
				e.Handled = true;
			}

		}
	}
}
