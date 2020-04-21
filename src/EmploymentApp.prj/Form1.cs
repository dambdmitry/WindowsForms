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
	public partial class MainForm : Form
	{
		private int _countRows = 0; //Для перехода на новую строку в таблице.
		public MainForm()
		{
			InitializeComponent();

			_txtLevelEnglish.Enabled = false;
			_cmbLevelEnglish.Enabled = false;

			_txtScopeEducation.Enabled = false;
			_cmbScopeEducation.Enabled = false;

			_txtHowMuchExp.Enabled = false;
			_cmbHowMuchExp.Enabled = false;

			//Заполнение comboBox'ов.
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

			_dataGridView.Columns.AddRange(new DataGridViewTextBoxColumn[] {nameCol, lastNameCol, sexCol, englishCol, educationCol, expCol, positionCol });

			
		}
		/// <summary>
		/// Метод выполняет проверку в checkBox'ах 
		/// При (.Checked == true) открывает доступ к соответствующим comboBox'ам 
		/// В ином случае закрывает их и обнуляет значения в comboBox.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _chk_CheckedChanged(object sender, EventArgs e)
		{
			if(_chkEnglishProficiency.Checked)
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

			if(_chkHighEducation.Checked)
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

			if(_chkExperience.Checked)
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
		/// <summary>
		/// Метод производит проверку на заполнение полей, обязательных для ввода(в т.ч. и компетенций если они отмечены в checkBox'е)
		/// После проверки в блоке "else" метод добавляет в таблицу данные, введенные пользователем.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnSave_Click(object sender, EventArgs e)
		{
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
			else
			{
				var result = MessageBox.Show("Сохранить данные?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Для следующей проверки какую кнопку нажмет пользователь.

				if(result == DialogResult.Yes)
				{
					_dataGridView.Rows.Add();

					_dataGridView[0, _countRows].Value = _txtEnterName.Text;
					_dataGridView[1, _countRows].Value = _txtEnterLastName.Text;
					_dataGridView[2, _countRows].Value = _rdiFemale.Checked ? "Женский" : "Мужской";
					_dataGridView[3, _countRows].Value = _cmbLevelEnglish.SelectedItem == null ? "-" : _cmbLevelEnglish.SelectedItem.ToString();
					_dataGridView[4, _countRows].Value = _cmbScopeEducation.SelectedItem == null ? "-" : _cmbScopeEducation.SelectedItem.ToString();
					_dataGridView[5, _countRows].Value = _cmbHowMuchExp.SelectedItem == null ? "Без опыта" : _cmbHowMuchExp.SelectedItem.ToString();
					_dataGridView[6, _countRows].Value = _cmbPosition.SelectedItem.ToString();

					_countRows++;
				}
			}

		}
		/// <summary>
		/// В поле "Фамилия" защищаемся от ввода некорректных символов.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _txtEnterLastName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
			{
				e.Handled = true;
			}
		}
		/// <summary>
		/// Аналогично методу "_txtEnterLastName_KeyPress", только с полем "Имя".
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _txtEnterName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
			{
				e.Handled = true;
			}

		}

	
	}
}
