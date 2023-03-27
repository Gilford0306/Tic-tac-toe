using System.Drawing;
using System.Windows.Forms;

namespace Tic_tac_toe
{ partial class Form1
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

        this.Controls.Add(btn1);
            ///

            btn2 = new Button();
            btn2.ForeColor = Color.Blue;
            btn2.Size = new Size(90, 100);
            btn2.Location = new Point(150, 50);
            btn2.BackColor = Color.Yellow;
            btn2.Font = new Font("Times New Roman", 23, FontStyle.Bold | FontStyle.Italic);

            this.Controls.Add(btn2);
            ///////
            btn3 = new Button();
            btn3.ForeColor = Color.Blue;
            btn3.Size = new Size(90, 100);
            btn3.Location = new Point(250, 50);
            btn3.BackColor = Color.Yellow;
            btn3.Font = new Font("Times New Roman", 23, FontStyle.Bold | FontStyle.Italic);
 
            this.Controls.Add(btn3);

            ////////
            btn4 = new Button();
            btn4.ForeColor = Color.Blue;
            btn4.Size = new Size(90, 100);
            btn4.Location = new Point(50, 160);
            btn4.BackColor = Color.Yellow;
            btn4.Font = new Font("Times New Roman", 23, FontStyle.Bold | FontStyle.Italic);

            this.Controls.Add(btn4);
            /////

            btn5 = new Button();
            btn5.ForeColor = Color.Blue;
            btn5.Size = new Size(90, 100);
            btn5.Location = new Point(150, 160);
            btn5.BackColor = Color.Yellow;
            btn5.Font = new Font("Times New Roman", 23, FontStyle.Bold | FontStyle.Italic);

            this.Controls.Add(btn5);
            ///////
            btn6 = new Button();
            btn6.ForeColor = Color.Blue;
            btn6.Size = new Size(90, 100);
            btn6.Location = new Point(250, 160);
            btn6.BackColor = Color.Yellow;
            btn6.Font = new Font("Times New Roman", 23, FontStyle.Bold | FontStyle.Italic);

            this.Controls.Add(btn6);
            //    //////////
            btn7 = new Button();
            btn7.ForeColor = Color.Blue;
            btn7.Size = new Size(90, 100);
            btn7.Location = new Point(50, 270);
            btn7.BackColor = Color.Yellow;
            btn7.Font = new Font("Times New Roman", 23, FontStyle.Bold | FontStyle.Italic);

            this.Controls.Add(btn7);
            /////

            btn8 = new Button();
            btn8.ForeColor = Color.Blue;
            btn8.Size = new Size(90, 100);
            btn8.Location = new Point(150, 270);
            btn8.BackColor = Color.Yellow;
            btn8.Font = new Font("Times New Roman", 23, FontStyle.Bold | FontStyle.Italic);

            this.Controls.Add(btn8);
            ///////
            btn9 = new Button();
            btn9.ForeColor = Color.Blue;
            btn9.Size = new Size(90, 100);
            btn9.Location = new Point(250, 270);
            btn9.BackColor = Color.Yellow;
            btn9.Font = new Font("Times New Roman", 23, FontStyle.Bold | FontStyle.Italic);

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