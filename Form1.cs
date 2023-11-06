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
        } //!string.IsNullOrWhiteSpace(TxtName.Text), используется для проверки,
          //что поле TxtName не является пустым
          //или не содержит только пробелы.
          //Если это условие выполняется
          //(то есть поле не пустое и не содержит только пробелы),
          //то код в фигурных скобках не выполняется и переходит к следующей строке.
          
        //Вторая часть условия,
          //!lstNames.Items.Contains(TxtName.Text),
          //проверяет,что значение поля TxtName не содержится уже в списке
          //lstNames. Если это условие выполняется
          //(то есть значение еще не содержится в списке),
          //то код в фигурных скобках выполняется
          //и добавляет значение поля TxtName в список lstNames
          //с помощью метода Add.
          //
        private void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57) //Этот код обрабатывает событие KeyPress, которое возникает при нажатии
                                                    //на клавишу с символом. Первое условие if проверяет,
                                                    //является ли нажатая клавиша числом (в данном случае от 0 до 9)
                                                    //Если это так, выводится сообщение о нажатой клавише.
                                                    //Затем, в операторе switch проверяется, является ли нажатая клавиша 1 4 7 .
                                                    //Если это так, выводится сообщение и событие помечается как обработанное,
                                                    //что означает, что оно не будет передано другим обработчикам событий.
            {
                MessageBox.Show($"Form.KeyPress: ‘{e.KeyChar}' pressed.");

                switch (e.KeyChar)
                { //case в C# - это ключевое слово, которое используется в операторе switch
                  //для определения различных вариантов выполнения кода в зависимости от значения выражения. 
                    case (char)49: //код для цифры 1
                    case (char)52: //код для цыфры 4
                    case (char)55: //код для цыфры 7
                        MessageBox.Show($"Form.KeyPress: ‘{e.KeyChar}' consumed.");
                        e.Handled = true;
                        break;
                } //e.Handled = true; - это выражение, которое используется в блоке case
                  //оператора switch для указания того, что текущий блок кода был обработан
                  //и выполнение оператора switch должно завершиться.
                  //Это часто используется вместе с ключевым словом break,
                  //которое также прерывает выполнение оператора switch
                  //и переходит за его пределы. В данном случае,
                  //выражение e.Handled = true; может быть использовано для обработки событий в приложении,
                  //например, для предотвращения дальнейшей обработки события после выполнения определенных действий.

            }
        }
        //
        //Для вызова этого обработчика событий Form.KeyPreview должно быть установлено значение true.
        private void Button1_MouseEnter(object sender, EventArgs e) //Данный код предназначен для обработки события
                                                                    //"наведение курсора мыши на кнопку"
        {
            Cursor.Hide(); //скрывается курсор мыши
        }

        private void Button1_MouseLeave_1(object sender, EventArgs e)
        {
            Cursor.Show(); //Это означает, что при уведении курсора мыши с кнопки (событие "MouseLeave"),
                           //будет отображаться курсор мыши (с помощью метода Cursor.Show()).
        }

        private void Button1_Click_1(object sender, EventArgs e)//Это означает, что при нажатии на кнопку (событие "Click"),
                                                                //(true)курсор мыши будет перемещен на координаты кнопки button2 (false)
                                                                //и текст на кнопке button1 (true) будет изменен на "Print".
        {
            Cursor.Position = PointToScreen(button2.Location);
            button1.Text = "&Print";
        }

        private void Button2_Click_1(object sender, EventArgs e)//Это означает, что при нажатии на кнопку (событие "Click"),
                                                                //(true or print)курсор мыши будет перемещен на координаты кнопки button2 (false)
                                                                //и при нажатие курсора мыши на кнопку button2 (false),
                                                                //при последующем наведении курсора мыши на кнопку, курсор будет изменён на руку
        {
            Cursor.Position = PointToScreen(button1.Location);
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            label1.Text = "&Print";
            label1.TabIndex = 9;
            button1.TabIndex = 10;//Это означает, что при нажатии на метку label1 (событие "Click"),
                                  //текст на этой метке будет изменен на "Print"
                                  //и установлен индекс перехода (TabIndex) на 9.
                                  //Также будет установлен индекс перехода для кнопки button1 на 10.
                                  //Индекс перехода определяет порядок,
                                  //в котором элементы управления получают фокус при нажатии на клавишу Tab.
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Print && Close"; //это означает, что при нажатии на метку button3 (событие клик)
                                             //текст на этой метке будет изменён на (Print & Close)

        }
    }
}
