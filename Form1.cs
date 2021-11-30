using System;
using System.Windows.Forms;

namespace JulianComboboxRandomizer
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i < 10; i++)
            {
                this.comboBox1.Items.Add(i);
            }
            for (int i = 90; i < 99; i++)
            {
                this.comboBox2.Items.Add(i);
            }
        }

        private void BtnRandomize_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBox1.SelectedItem == null || this.comboBox2.SelectedItem == null)
                {
                    this.ResultLabel.Text = "Empty arg";
                    return;
                }
                int min = Int32.Parse(this.comboBox1.SelectedItem.ToString());
                int max = Int32.Parse(this.comboBox2.SelectedItem.ToString());
                this.ResultLabel.Text = new Random().Next(min, max).ToString();
            }
            catch (ArgumentNullException)
            {
                this.ResultLabel.Text = "Empty arg";
            }
            catch (FormatException)
            {
                this.ResultLabel.Text = "Invalid arg";
            }
            catch (OverflowException)
            {
                this.ResultLabel.Text = "Invalid arg";
            }
        }
    }
}
