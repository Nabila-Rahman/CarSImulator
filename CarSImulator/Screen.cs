using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BO;

namespace CarSImulator
{
    public partial class Screen : Form
    {

        List<Rectangle> colliders;
        Pen myPen;
        CarControl myCarControl;
        Rectangle field;

        public Screen()
        {
            InitializeComponent();

            colliders = new List<Rectangle>();
            this.DoubleBuffered = true;
            myCarControl = new CarControl(this, colliders);
            myPen = new Pen(Color.Green, 5);

            // add world colliders
            colliders.Add(new Rectangle(0, 0, this.Width / 3, this.Height / 3));
            colliders.Add(new Rectangle(this.Width / 3 * 2, 0, this.Width / 3, this.Height / 3));
            colliders.Add(new Rectangle(0, this.Height / 3 * 2, this.Width / 3, this.Height / 3));
            colliders.Add(new Rectangle(this.Width / 3 * 2, this.Height / 3 * 2, this.Width / 3, this.Height / 3));

        
        }

        void drawStreets(PaintEventArgs e)
        {
            myPen.Color = Color.LawnGreen;

            field = new Rectangle(0,0,this.Width/3,this.Height/3);
            e.Graphics.FillRectangle(myPen.Brush,field);

                
            field = new Rectangle(this.Width / 3*2, 0, this.Width / 3, this.Height / 3);
            e.Graphics.FillRectangle(myPen.Brush, field);


            field = new Rectangle(0, this.Height / 3*2, this.Width / 3, this.Height / 3);
            e.Graphics.FillRectangle(myPen.Brush, field);


            field = new Rectangle(this.Width / 3*2, this.Height / 3 * 2, this.Width / 3, this.Height / 3);
            e.Graphics.FillRectangle(myPen.Brush, field);

            myPen.Color = Color.White;
            for(int i=0 ; i <10; i++)
            {
                e.Graphics.FillRectangle(myPen.Brush, i * 97, Height / 2 - 6, 40, 12);
            }

            for (int i = 0; i < 10; i++)
            {
                e.Graphics.FillRectangle(myPen.Brush, Width / 2 - 6, i*72, 12, 40);
            }


        }


        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.DimGray);
            drawStreets(e);
            

            myCarControl.GetMyCar().DrawCar(myPen,e.Graphics);
        }

        private void downB_Click(object sender, EventArgs e)
        {
            myCarControl.processInput(Direction.down);
        }

        private void upB_Click(object sender, EventArgs e)
        {
            myCarControl.processInput(Direction.up);
        }

        private void leftB_Click(object sender, EventArgs e)
        {
            myCarControl.processInput(Direction.left);
        }

        private void rightB_Click(object sender, EventArgs e)
        {
            myCarControl.processInput(Direction.right);
        }

        private void speedB_Click(object sender, EventArgs e)
        {
            myCarControl.setSpeed(speedTB.Text);
            myCarControl.GetMyCar().setSpeed(myCarControl.getSpeed());
        }

        private void Screen_Load(object sender, EventArgs e)
        {

        }
    }
}
