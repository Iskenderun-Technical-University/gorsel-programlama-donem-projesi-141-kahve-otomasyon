﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (nameCombo.SelectedItem.ToString() == "neskafe")
            {
                if (typeCombo.SelectedItem.ToString() == "sıcak")
                {
                    paymentText.Text = (float.Parse(quanityCombo.Text) * 15).ToString();
                }
                if (typeCombo.SelectedItem.ToString() == "soguk")
                {
                    paymentText.Text = (float.Parse(quanityCombo.Text) * 10).ToString();
                }
                if (typeCombo.SelectedItem.ToString() == "normal")
                {
                    paymentText.Text = (float.Parse(quanityCombo.Text) * 5).ToString();

                }
                gunaDataGridView1.Rows.Add(idText.Text, nameCombo.Text, typeCombo.Text, quanityCombo.Text, paymentText.Text);

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
            nameCombo.Text = "";
            typeCombo.SelectedIndex = -1;
            quanityCombo.SelectedIndex = -1;
            paymentText.Text = "";

        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
