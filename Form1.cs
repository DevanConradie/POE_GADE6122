using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADES2
{
    
    public partial class Form1 : Form
    {
        GameEngine newInstance;
      
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAttackUp_Click(object sender, EventArgs e)
        {

        }

        private void btnAttackRight_Click(object sender, EventArgs e)
        {

        }

        private void btnAttackLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnAttackDown_Click(object sender, EventArgs e)
        {

        }

      

        private void btnUp_Click(object sender, EventArgs e)
        {
            newInstance.MovePlayer(Character.Movement.UP);
            {
                newInstance.BuildMap();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            newInstance.MovePlayer(Character.Movement.RIGHT);
            {
                newInstance.BuildMap();
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            newInstance.MovePlayer(Character.Movement.LEFT);
            {
                newInstance.BuildMap();
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            newInstance.MovePlayer(Character.Movement.DOWN);
            {
                newInstance.BuildMap();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newInstance = new GameEngine();
            rtxtMap.Text = newInstance.BuildMap();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            newInstance.Save();
           
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            newInstance.Load();
            
        }
    }
}
