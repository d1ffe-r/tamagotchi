using System;
using System.Timers;
using System.Windows.Forms;

namespace tamagotchi
{
    public partial class Form1 : Form

    {
        Dog dog;
        static System.Timers.Timer tamagotchiTimer = new System.Timers.Timer(6000);
        public Form1()
        {
            InitializeComponent();
            dog = new Dog();
            tamagotchiTimer.Elapsed += Tick;
            tamagotchiTimer.Enabled = true;
        }
        private static void Tick(object sender, ElapsedEventArgs e)
        {
            dog.increaseHungry(5);
            dog.decreaseEnergy(5);
            dog.decreaseHappy(5);
        }
        private void initUI()
        {
            this.progressBarHungry.Value = dog.getHungry();
            this.progressBarEnergy.Value = dog.getEnergy();
            this.progressBarHappy.Value = dog.getHappy();
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
