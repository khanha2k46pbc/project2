using Project_2.Draw_Bouding_Box;
using Project_2.Move_Images;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class ModeSelectionForm : Form
    {
        public ModeSelectionForm()
        {
            InitializeComponent();
        }

        private void buttonMoveImages_Click(object sender, EventArgs e)
        {
            using (MoveImagesForm moveImagesForm = new MoveImagesForm())
            {
                this.Hide();
                moveImagesForm.ShowDialog();
                this.Show();
            }            
        }

        private void buttonDrawBoudingBox_Click(object sender, EventArgs e)
        {
            using (DrawBoudingBoxForm drawBoudingBoxForm = new DrawBoudingBoxForm())
            {
                this.Hide();
                drawBoudingBoxForm.ShowDialog();
                this.Show();
            }
        }
    }
}
