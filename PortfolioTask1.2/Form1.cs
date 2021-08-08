using System;
using System.Windows.Forms;
using GreetingsLibrary;
using FarewellLibrary;

namespace PortfolioTask1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Greetings greetings = new Greetings();
        Farewell farewell = new Farewell();

        private void button1_Click(object sender, EventArgs e)
        {
            labelHelloBye.Text = greetings.SayHello("Mr.President");
        }

        private void btnBye_Click(object sender, EventArgs e)
        {
            labelHelloBye.Text = farewell.SayGoodBye("Mr.President");
        }
    }
}
