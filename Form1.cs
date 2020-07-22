using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;

namespace ZCA3
{
	public partial class Form : System.Windows.Forms.Form
	{
		private Grid grid;
		private Thread thread;
		private string neighborhood = "";
		private float radius = 2;
		private int iterations = 0;
		public Form()
		{
			InitializeComponent();
			grid = new Grid((int)numericUpDownX.Value, (int)numericUpDownY.Value, checkBox.Checked);
			GetImageAndRefresh();
		}

		private void GenerateButton_Click(object sender, EventArgs e)
		{
			if (grid.Generated)
			{
				return;
			}
			if (!grid.IsContainNucleation())
			{
				MessageBox.Show("Nie można wygenerować struktury, gdy nie ma zarodków.");
				return;
			}
			InterfaceEnabled(false);
			switch (comboBox.SelectedItem.ToString())
			{
				case "von Neumanna":
					neighborhood = "von neumann";
					break;
				case "Moore'a":
					neighborhood = "moore";
					break;
				case "Pentagonalne":
					neighborhood = "pentagonal";
					break;
				case "Heksagonalne prawe":
					neighborhood = "hexagonal right";
					break;
				case "Heksagonalne lewe":
					neighborhood = "hexagonal left";
					break;
				case "Heksagonalne losowe":
					neighborhood = "hexagonal random";
					break;
				case "Z promieniem":
					neighborhood = "radius";
					break;
				case "Z promieniem i przesunięciem":
					neighborhood = "offset radius";
					break;
			}
			radius = (float)numericUpDownRadiusNeighborhood.Value;
			timer1.Start();
		}

		private void PictureBox_Click(object sender, EventArgs e)
		{
			if (grid.Generated)
			{
				return;
			}
			MouseEventArgs mouseEvent = (MouseEventArgs)e;
			int x = mouseEvent.Location.X / (pictureBox.Image.Width / grid.GetXSize());
			int y = mouseEvent.Location.Y / (pictureBox.Image.Height / grid.GetYSize());
			grid.ChangeColor(x, y);
			GetImageAndRefresh();
		}

		private void NucleationButton_Click(object sender, EventArgs e)
		{
			grid = new Grid((int)numericUpDownX.Value, (int)numericUpDownY.Value, checkBox.Checked);
			radioButtonEdges.Enabled = false;
			radioButtonEnergy.Enabled = false;
			buttonMonteCarlo.Enabled = false;
			radioButtonNormal.Checked = true;
			try
			{
				switch (tabControl1.SelectedTab.Name)
				{
					case "tabPage1":
						grid.Nucleation((int)numericUpDownNucX.Value, (int)numericUpDownNucY.Value);
						break;
					case "tabPage2":
						grid.Nucleation((int)numericUpDownRand1.Value);
						break;
					case "tabPage3":
						grid.Nucleation((float)numericUpDownRadiusNucleation.Value, (int)numericUpDownRand2.Value);
						break;
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
			GetImageAndRefresh();
		}

		private void GetImageAndRefresh()
		{
			if (radioButtonNormal.Checked)
			{
				pictureBox.Image = grid.GetResizedBitmap(pictureBox.Width, pictureBox.Height);
			}
			else if (radioButtonEdges.Checked)
			{
				GenerateEdges();
			}
			else
			{
				pictureBox.Image = grid.GetResizedBitmapEnergy(pictureBox.Width, pictureBox.Height);
			}
		}

		private void NumericUpDownX_ValueChanged(object sender, EventArgs e)
		{

			numericUpDownNucX.Maximum = numericUpDownX.Value;
			numericUpDownRand1.Maximum = numericUpDownX.Value * numericUpDownY.Value;
			numericUpDownRand2.Maximum = numericUpDownX.Value * numericUpDownY.Value;
			numericUpDownRadiusNeighborhood.Maximum = numericUpDownRadiusNucleation.Maximum = MaximumRadius();
		}

		private void NumericUpDownY_ValueChanged(object sender, EventArgs e)
		{
			numericUpDownNucY.Maximum = numericUpDownY.Value;
			numericUpDownRand1.Maximum = numericUpDownX.Value * numericUpDownY.Value;
			numericUpDownRand2.Maximum = numericUpDownX.Value * numericUpDownY.Value;
			numericUpDownRadiusNeighborhood.Maximum = numericUpDownRadiusNucleation.Maximum = MaximumRadius();
		}

		private int MaximumRadius()
		{
			int max;
			if (numericUpDownX.Value >= numericUpDownY.Value)
			{
				max = (int)numericUpDownX.Value / 2 - 1;
			}
			else
			{
				max = (int)numericUpDownY.Value / 2 - 1;
			}
			return max;
		}

		private void ExportButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "Obraz PNG|*.PNG";
			dialog.FileName = "Mikrostruktura";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				pictureBox.Image.Save(dialog.FileName, ImageFormat.Png);
			}
		}

		private void CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			GetImageAndRefresh();
		}

		private void GenerateEdges()
		{
			Bitmap image1 = grid.GetResizedBitmap(pictureBox.Width, pictureBox.Height);
			Bitmap image2 = grid.GetResizedBitmap(pictureBox.Width, pictureBox.Height);
			for (int i = 0; i < image1.Width - 1; i++)
			{
				for (int j = 0; j < image1.Height - 1; j++)
				{

					int r = Math.Abs(image1.GetPixel(i, j).R - image1.GetPixel(i + 1, j + 1).R) + Math.Abs(image1.GetPixel(i + 1, j).R - image1.GetPixel(i, j + 1).R);
					int g = Math.Abs(image1.GetPixel(i, j).G - image1.GetPixel(i + 1, j + 1).G) + Math.Abs(image1.GetPixel(i + 1, j).G - image1.GetPixel(i, j + 1).G);
					int b = Math.Abs(image1.GetPixel(i, j).B - image1.GetPixel(i + 1, j + 1).B) + Math.Abs(image1.GetPixel(i + 1, j).B - image1.GetPixel(i, j + 1).B);
					if (r > 255) r = 255;
					if (g > 255) g = 255;
					if (b > 255) b = 255;
					image1.SetPixel(i, j, Color.FromArgb(r, g, b));
				}
			}

			for (int i = 0; i < image2.Width - 1; i++)
			{
				for (int j = 0; j < image2.Height - 1; j++)
				{
					Color color = image1.GetPixel(i, j);
					if (color.R != 0 || color.G != 0 || color.B != 0)
					{
						image2.SetPixel(i, j, Color.Black);
					}
				}
			}
			pictureBox.Image = image2;
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{

			if (!grid.Generated)
			{
				grid.GenerateNextTimestep(neighborhood, radius);
				GetImageAndRefresh();
			}
			else
			{
				GetImageAndRefresh();
				timer1.Stop();
				InterfaceEnabled(true);
				radioButtonEdges.Enabled = true;
				buttonMonteCarlo.Enabled = true;
			}
		}

		private void InterfaceEnabled(bool enabled)
		{
			if (enabled)
			{
				label5.Visible = false;
				NucleationButton.Enabled = true;
				GenerateButton.Enabled = true;
				exportButton.Enabled = true;
				buttonMonteCarlo.Enabled = true;
				groupBox3.Enabled = true;
				groupBox4.Enabled = true;
				pictureBox.Enabled = true;
			}
			else
			{
				label5.Visible = true;
				NucleationButton.Enabled = false;
				GenerateButton.Enabled = false;
				exportButton.Enabled = false;
				buttonMonteCarlo.Enabled = false;
				groupBox3.Enabled = false;
				groupBox4.Enabled = false;
				pictureBox.Enabled = false;
			}
		}

		private void ButtonMonteCarlo_Click(object sender, EventArgs e)
		{
			radioButtonEnergy.Enabled = true;
			InterfaceEnabled(false);
			iterations = (int)numericUpDownIterations.Value;
			timer2.Start();
		}

		private void RadioButtonEdges_CheckedChanged(object sender, EventArgs e)
		{
			if (!radioButtonEdges.Checked)
			{
				return;
			}
			InterfaceEnabled(false);
			thread = new Thread(GetImageAndRefresh);
			thread.Start();
			timer1.Start();
		}

		private void RadioButtonNormal_CheckedChanged(object sender, EventArgs e)
		{
			if (!radioButtonNormal.Checked || !grid.Generated)
			{
				return;
			}
			InterfaceEnabled(false);
			thread = new Thread(GetImageAndRefresh);
			thread.Start();
			timer1.Start();
		}

		private void RadioButtonEnergy_CheckedChanged(object sender, EventArgs e)
		{
			if (!radioButtonEnergy.Checked)
			{
				return;
			}
			InterfaceEnabled(false);
			thread = new Thread(GetImageAndRefresh);
			thread.Start();
			timer1.Start();
		}

		private void Timer2_Tick(object sender, EventArgs e)
		{
			if (iterations <= 0)
			{
				timer2.Stop();
				InterfaceEnabled(true);
			}
			else
			{
				grid.GenerateNextMonteCarloTimestep(neighborhood, (double)numericUpDownKT.Value, radius);
				iterations--;
			}
			GetImageAndRefresh();
		}
	}
}
