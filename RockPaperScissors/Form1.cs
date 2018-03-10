using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RockPaperScissors
{
    
    public partial class RockPaperScissors : Form
    {
        public RockPaperScissors()
        {
            InitializeComponent();
        }

        private void message_box(string message, string title )
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, title, buttons);
            if (result == System.Windows.Forms.DialogResult.No)
            {
                this.Close();
            }
            else
            {
                pictureBox1.Image = new Bitmap(@"D:\Programy\C#\RockPaperScissors\RockPaperScissors\pytanie.jpg");
                pictureBox2.Image = new Bitmap(@"D:\Programy\C#\RockPaperScissors\RockPaperScissors\pytanie.jpg");
            }

        }

        picture image = new picture();
        int pic1 = 0;
        int pic2 = 0;

        private void who_win()
        {
            Random rand = new Random();
            int random_number = rand.Next(10, 100);
            for (int i = 0; i < random_number; i++)
            {
                pictureBox1.Image = image.get_picture(ref pic1);
                pictureBox2.Image = image.get_picture(ref pic2);
            }
            if (pic1 == pic2)
            {
                message_box("Game is dead-head! \n Play again?", "The winner is...");
            }
            //wygrane lewego
            if ((pic1 == 1 && pic2 == 2) || (pic1 == 2 && pic2 == 0) || (pic1==0 && pic2==1))
            {
                message_box("Left player win!\n Play again?", "The winner is...");
            }
            //wygrane prawego
            if ((pic2 == 1 && pic1 == 2) || (pic2 == 2 && pic1 == 0) || (pic2 == 0 && pic1 == 1))
            {
                message_box("Right player win!\n Play again?", "The winner is...");
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            who_win();   
        }
    }
}
