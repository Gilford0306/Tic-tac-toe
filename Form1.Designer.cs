using System.Drawing;
using System.Windows.Forms;

namespace Tic_tac_toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = Color.DeepSkyBlue;

            btn1 = new Button();
            btn1.ForeColor = Color.Blue;
            btn1.Size = new Size(90, 100);
            btn1.Location = new Point(50, 50);
            btn1.BackColor = Color.Yellow;
            btn1.Font = new Font("Times New Roman", 23, FontStyle.Bold | FontStyle.Italic);
            btn1.Click += (e, sender) =>
            {

                if (btn1.Text == "0" || btn1.Text == string.Empty)
                    btn1.Text = "X";
                else btn1.Text = "0";
                btn_end.Click += (e1, sender1) => { btn1.Enabled = false; };
            };
            this.Controls.Add(btn1);
            ///

            btn2 = new Button();
            btn2.ForeColor = Color.Blue;
            btn2.Size = new Size(90, 100);
            btn2.Location = new Point(150, 50);
            btn2.BackColor = Color.Yellow;
            btn2.Font = new Font("Times New Roman", 23, FontStyle.Bold | FontStyle.Italic);
            btn2.Click += (e, sender) =>
            {

                if (btn2.Text == "0" || btn2.Text == string.Empty)
                    btn2.Text = "X";
                else btn2.Text = "0";
                btn_end.Click += (e1, sender1) => { btn2.Enabled = false; };
            };
            this.Controls.Add(btn2);
            ///////
            btn3 = new Button();
            btn3.ForeColor = Color.Blue;
            btn3.Size = new Size(90, 100);
            btn3.Location = new Point(250, 50);
            btn3.BackColor = Color.Yellow;
            btn3.Font = new Font("Times New Roman", 23, FontStyle.Bold | FontStyle.Italic);
            btn3.Click += (e, sender) =>
            {

                if (btn3.Text == "0" || btn3.Text == string.Empty)
                    btn3.Text = "X";
                else btn3.Text = "0";
                btn_end.Click += (e1, sender1) => { btn3.Enabled = false; };
            };
            this.Controls.Add(btn3);

            ////////
            btn4 = new Button();
            btn4.ForeColor = Color.Blue;
            btn4.Size = new Size(90, 100);
            btn4.Location = new Point(50, 160);
            btn4.BackColor = Color.Yellow;
            btn4.Font = new Font("Times New Roman", 23, FontStyle.Bold | FontStyle.Italic);
            btn4.Click += (e, sender) =>
            {

                if (btn4.Text == "0" || btn4.Text == string.Empty)
                    btn4.Text = "X";
                else btn4.Text = "0";
                btn_end.Click += (e1, sender1) => { btn4.Enabled = false; };
            };
            this.Controls.Add(btn4);
            /////

            btn5 = new Button();
            btn5.ForeColor = Color.Blue;
            btn5.Size = new Size(90, 100);
            btn5.Location = new Point(150, 160);
            btn5.BackColor = Color.Yellow;
            btn5.Font = new Font("Times New Roman", 23, FontStyle.Bold | FontStyle.Italic);
            btn5.Click += (e, sender) =>
            {

                if (btn5.Text == "0" || btn5.Text == string.Empty)
                    btn5.Text = "X";
                else btn5.Text = "0";
                btn_end.Click += (e1, sender1) => { btn5.Enabled = false; };
            };
            this.Controls.Add(btn5);
            ///////
            btn6 = new Button();
            btn6.ForeColor = Color.Blue;
            btn6.Size = new Size(90, 100);
            btn6.Location = new Point(250, 160);
            btn6.BackColor = Color.Yellow;
            btn6.Font = new Font("Times New Roman", 23, FontStyle.Bold | FontStyle.Italic);
            btn6.Click += (e, sender) =>
            {

                if (btn6.Text == "0" || btn6.Text == string.Empty)
                    btn6.Text = "X";
                else btn6.Text = "0";
                btn_end.Click += (e1, sender1) => { btn6.Enabled = false; };
            };
            this.Controls.Add(btn6);
            //    //////////
            btn7 = new Button();
            btn7.ForeColor = Color.Blue;
            btn7.Size = new Size(90, 100);
            btn7.Location = new Point(50, 270);
            btn7.BackColor = Color.Yellow;
            btn7.Font = new Font("Times New Roman", 23, FontStyle.Bold | FontStyle.Italic);
            btn7.Click += (e, sender) =>
            {

                if (btn7.Text == "0" || btn7.Text == string.Empty)
                    btn7.Text = "X";
                else btn7.Text = "0";
                btn_end.Click += (e1, sender1) => { btn7.Enabled = false; };
            };
            this.Controls.Add(btn7);
            /////

            btn8 = new Button();
            btn8.ForeColor = Color.Blue;
            btn8.Size = new Size(90, 100);
            btn8.Location = new Point(150, 270);
            btn8.BackColor = Color.Yellow;
            btn8.Font = new Font("Times New Roman", 23, FontStyle.Bold | FontStyle.Italic);
            btn8.Click += (e, sender) =>
            {

                if (btn8.Text == "0" || btn8.Text == string.Empty)
                    btn8.Text = "X";
                else btn8.Text = "0";
                btn_end.Click += (e1, sender1) => { btn8.Enabled = false; };
            };
            this.Controls.Add(btn8);
            ///////
            btn9 = new Button();
            btn9.ForeColor = Color.Blue;
            btn9.Size = new Size(90, 100);
            btn9.Location = new Point(250, 270);
            btn9.BackColor = Color.Yellow;
            btn9.Font = new Font("Times New Roman", 23, FontStyle.Bold | FontStyle.Italic);
            btn9.Click += (e, sender) =>
            {

                if (btn9.Text == "0" || btn9.Text == string.Empty)
                    btn9.Text = "X";
                else btn9.Text = "0";
                btn_end.Click += (e1, sender1) => { btn9.Enabled = false; };
            };
            this.Controls.Add(btn9);


            btn_end = new Button();
            btn_end.Text = "End move";
            btn_end.ForeColor = Color.Blue;
            btn_end.Size = new Size(150, 160);
            btn_end.Location = new Point(500, 150);
            btn_end.BackColor = Color.Yellow;
            btn_end.Font = new Font("Times New Roman", 23, FontStyle.Bold | FontStyle.Italic);


            this.Controls.Add(btn_end);



        }
        Button btn_end;
        Button btn1;
        Button btn2;
        Button btn3;
        Button btn4;
        Button btn5;
        Button btn6;
        Button btn7;
        Button btn8;
        Button btn9;
        #endregion
    }
}