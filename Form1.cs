using System;
using System.Windows.Forms;

namespace PasswordGenerator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public void button1_Click(object sender, EventArgs e)
		{
			int passLenght = (int)numericUpDown1.Value;
			int passQuantity = (int)numericUpDown2.Value;
			//bool symbols = checkBox1.Checked;
			Random rand = new Random();
			//Random type = new Random();
			for (int k = 0; k < passQuantity; k++)
			{
				for (int i = 0; i < passLenght; i++)
				{
						char value = (char)rand.Next(33, 125);
						if (value == '\\' || value == '/')
						{
							value = (char)rand.Next(33, 91);
							richTextBox1.Text += value.ToString();
						}
						else
						{
							richTextBox1.Text += value.ToString();
						}
						continue;
				}
				richTextBox1.Text += "\n";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
		}
	}
}

