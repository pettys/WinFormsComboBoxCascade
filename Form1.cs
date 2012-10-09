using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CascadingComboSpike
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			_numberClass.SelectedIndex = 0;
			new ComboCascader(_numberClass, _number, FillNumberFromNumberClass);
			new ComboCascader(_number, _letter, FillLetterFromNumber);
			new ComboCascader(_letter, _sector, FillSector);
		}

		#region Methods that load data into comboboxes

		private void FillNumberFromNumberClass()
		{
			_number.Items.Clear();
			switch (_numberClass.SelectedIndex)
			{
				case 0: // <select one>
					break;
				case 1: // Even numbers
					_number.Items.AddRange(Enumerable.Range(1, 9).Where(n => n % 2 == 0).Cast<object>().ToArray());
					break;
				case 2: //Odd numbers
					_number.Items.AddRange(Enumerable.Range(1, 9).Where(n => n % 2 == 1).Cast<object>().ToArray());
					break;
				case 3: //Multiples of 3
					_number.Items.AddRange(Enumerable.Range(1, 9).Where(n => n % 3 == 0).Cast<object>().ToArray());
					break;
				case 4: //Prime numbers
					_number.Items.AddRange(new[] { 2, 3, 5, 7 }.Cast<object>().ToArray());
					break;
				default:
					throw new Exception("Out of range, I guess.");
			}
		}

		private void FillLetterFromNumber()
		{
			_letter.Items.Clear();
			if (_number.SelectedItem == null)
			{
				return;
			}
			int selectedNumber = (int)_number.SelectedItem;
			int start = selectedNumber - 1 + (int)'A';
			int end = start + 4;
			for (int i = start; i <= end; i++)
			{
				_letter.Items.Add(((char)i).ToString());
			}
		}

		private void FillSector()
		{
			_sector.Items.Clear();
			if (_number.SelectedItem == null || _letter.SelectedItem == null)
			{
				return;
			}
			int number = (int)_number.SelectedItem;
			string letter = (string)_letter.SelectedItem;
			foreach (char part in "abcd")
			{
				_sector.Items.Add(string.Format("{0}{1}-{2}", number, letter, part));
			}
		}

		#endregion

	}

}
