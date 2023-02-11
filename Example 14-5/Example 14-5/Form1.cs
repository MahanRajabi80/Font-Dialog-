using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_14_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //----------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            fontDialog1.ShowColor = true;
            fontDialog1.FontMustExist = true;
        }
        //----------------------------------------------------------------
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode==Keys.F)
            {
                SetFont();
            }
        }
        //----------------------------------------------------------------
        private void btnFont_Click(object sender, EventArgs e)
        {
            SetFont();
        }
        //----------------------------------------------------------------
        private void SetFont()//new method
        {
            fontDialog1.Font = txtFont.Font;
            fontDialog1.Color = txtFont.ForeColor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFont.Font = fontDialog1.Font;
                txtFont.ForeColor = fontDialog1.Color;
            }
            txtFont.Focus();
        }
    }
}
