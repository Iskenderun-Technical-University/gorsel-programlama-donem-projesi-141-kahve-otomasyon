using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev._22
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridView1.CurrentRow != null)
            {
                idText.Text = gunaDataGridView1.CurrentRow.Cells[0].Value.ToString();
                nameCombo.Text = gunaDataGridView1.CurrentRow.Cells[1].Value.ToString();
                typeCombo.Text = gunaDataGridView1.CurrentRow.Cells[2].Value.ToString();
                quanityCombo.Text = gunaDataGridView1.CurrentRow.Cells[3].Value.ToString();
                paymentText.Text = gunaDataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (nameCombo.SelectedIndex <= -1) return;
            if (typeCombo.SelectedIndex <= -1) return;

            if (nameCombo.SelectedItem.ToString() == "neskafe")
            {
                if (typeCombo.SelectedItem.ToString() == "sıcak")
                {
                    paymentText.Text = (float.Parse(quanityCombo.Text) * 20).ToString();
                }
                if (typeCombo.SelectedItem.ToString() == "soguk")
                {
                    paymentText.Text = (float.Parse(quanityCombo.Text) * 10).ToString();
                }
                if (typeCombo.SelectedItem.ToString() == "normal")
                {
                    paymentText.Text = (float.Parse(quanityCombo.Text) * 5).ToString();

                }


            }

            if (nameCombo.SelectedItem.ToString() == "sutlu kahve")
                if (typeCombo.SelectedItem.ToString() == "sıcak")
                {
                    paymentText.Text = (float.Parse(quanityCombo.Text) * 25).ToString();
                }
            if (typeCombo.SelectedItem.ToString() == "soguk")
            {
                paymentText.Text = (float.Parse(quanityCombo.Text) * 30).ToString();
            }

            if (typeCombo.SelectedItem.ToString() == "normal")
            {
                paymentText.Text = (float.Parse(quanityCombo.Text) * 30).ToString();
            }

            if (nameCombo.SelectedItem.ToString() == "cay")
            {
                if (typeCombo.SelectedItem.ToString() == "sıcak")
                {
                    paymentText.Text = (float.Parse(quanityCombo.Text) * 20).ToString();
                }
                if (typeCombo.SelectedItem.ToString() == "soguk")
                {
                    paymentText.Text = (float.Parse(quanityCombo.Text) * 10).ToString();
                }
                if (typeCombo.SelectedItem.ToString() == "normal")
                {
                    paymentText.Text = (float.Parse(quanityCombo.Text) * 5).ToString();



                }

            }
            gunaDataGridView1.Rows.Add(idText.Text, nameCombo.Text, typeCombo.Text, quanityCombo.Text, paymentText.Text);
        }
       
      
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            idText.Text = "";
            nameCombo.SelectedIndex = -1;
            typeCombo.SelectedIndex = -1;
            quanityCombo.SelectedIndex = -1;
            paymentText.Text = "";

        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if(gunaDataGridView1.CurrentRow != null)
            {
                gunaDataGridView1.Rows.Remove(gunaDataGridView1.CurrentRow);
            }
        }

        private void gunaCirclePictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            if (gunaDataGridView1.CurrentRow != null)
            {
                gunaDataGridView1.CurrentRow.Cells[0].Value = idText.Text;
                gunaDataGridView1.CurrentRow.Cells[1].Value = nameCombo.Text;
                gunaDataGridView1.CurrentRow.Cells[2].Value = typeCombo.Text;
                gunaDataGridView1.CurrentRow.Cells[3].Value = quanityCombo.Text;
                gunaDataGridView1.CurrentRow.Cells[4].Value = paymentText.Text;
            }
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
           // ((Form)printDocument1).WindowState = FormWindowState.Maximized;
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();

            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            float margin = 40;
            Font f= new Font("Arial",18, FontStyle.Bold);
            string namecofi = "İçeceK Adı" + nameCombo.Text;
            //string tayp = "" + nameCombo.Text;
            // string namecofi = "İçeceK Adı" + nameCombo.Text;
            //string namecofi = "İçeceK Adı" + nameCombo.Text;
            // e.Graphics.DrawImage(namecofi, f, Brushes.DarkKhaki, e.PageBounds.Left - fontsiz1.Width - margin, margin + fontsiz1.Height+ namecofi.Height);
            float UZUNLUK = 80;
            // e.Graphics.DrawRectangle(Pens.Black.mar)

            float colHeight = 60;
            float colHeight1 = 300;
            float colHeight2 = 125 + colHeight1;
            float colHeight3 = 125 + colHeight2;
            float colHeight4 = 125 + colHeight3;
            float colHeight5 = 125 + colHeight4;


            e.Graphics.DrawLine(Pens.Black, margin, UZUNLUK  + colHeight ,e.PageBounds.Width - margin, UZUNLUK+ colHeight);
            e.Graphics.DrawString("İskendarun teknik kofi",f,Brushes.Red, e.PageBounds.Width - margin-margin*2 -colHeight2,UZUNLUK);


            float rowsHeight = 60;
            for (int x = 0; x < gunaDataGridView1.Rows.Count; x += 1)
            {
                e.Graphics.DrawString(gunaDataGridView1.Rows[x].Cells[1].Value.ToString(), f,Brushes.Navy, e.PageBounds.Width - margin * 2 - colHeight2,UZUNLUK + rowsHeight);

                e.Graphics.DrawString(gunaDataGridView1.Rows[x].Cells[2].Value.ToString(), f, Brushes.Navy, e.PageBounds.Width - margin * 4 - colHeight2, UZUNLUK + rowsHeight);
                e.Graphics.DrawString(gunaDataGridView1.Rows[x].Cells[3].Value.ToString(), f, Brushes.Navy, e.PageBounds.Width - margin * 6 - colHeight2, UZUNLUK + rowsHeight);
                e.Graphics.DrawString(gunaDataGridView1.Rows[x].Cells[4].Value.ToString(), f, Brushes.Navy, e.PageBounds.Width - margin * 8- colHeight2, UZUNLUK + rowsHeight);
            }

        }
    }
}

