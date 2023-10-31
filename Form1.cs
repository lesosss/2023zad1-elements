using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_задание
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        { //добавление имени в элемент управления lstNames
            //обработчик будет добавлять имя,
            //заданное элементом управления TextBox txtName,
            //в элемент управления ListBox lstNames. 
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
                lstNames.Items.Add(txtName.Text);
        }

        private void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                MessageBox.Show($"Form.KeyPress: ‘{e.KeyChar}' pressed.");

                switch (e.KeyChar)
                {
                    case (char)49:
                    case (char)52:
                    case (char)55:
                        MessageBox.Show($"Form.KeyPress: ‘{e.KeyChar}' consumed.");
                        e.Handled = true;
                        break;
                }

            }
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void Button1_MouseLeave_1(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Cursor.Position = PointToScreen(button2.Location);
            button1.Text = "&Print";
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Cursor.Position = PointToScreen(button1.Location);
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            label1.Text = "&Print";
            label1.TabIndex = 9;
            button1.TabIndex = 10;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Print && Close";
        }
    }
}
