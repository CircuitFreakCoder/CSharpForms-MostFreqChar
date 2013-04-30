using System;
using System.Windows.Forms;

namespace mfc
{
    public partial class MostFreqCharForm : Form
    {
        public MostFreqCharForm()
        {
            InitializeComponent();
        }

       

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int max = 0;
            int count = 0;
            int[] counts = new int[textBoxInput.Text.Length];

            for (int i = 0; i < textBoxInput.Text.Length; i++) {
                for (int j = 0; j < textBoxInput.Text.Length; j++) {
                    if (textBoxInput.Text[i] == textBoxInput.Text[j])
                        counts[i] = ++count;                
                }
                count = 0;

                if (counts[i] > counts[max])
                    max = i;
            }

            textBoxOutput.Text = textBoxInput.Text[max].ToString();



        }
    }
}
