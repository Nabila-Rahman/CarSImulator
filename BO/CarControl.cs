using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Windows.Forms;
using System.Drawing;
using DAL;

namespace BO
{
    public class CarControl
    {
        Car myCar;
        SpeedDataControl spc;

        public CarControl(Form uiForm, List<Rectangle> colliders)
        {
            myCar = new Car(uiForm);
            myCar.colliders = colliders;
            spc = new SpeedDataControl();
        }


        public Car GetMyCar()
        {
            return myCar;
        }
        
        public void processInput(Direction dir)
        {
            myCar.setDirection(dir);
        }

        public void setSpeed(string speed)
        {
            int tem = 0;

            if (int.TryParse(speed, out tem))
            {
                spc.saveSpeed(tem);
                //myCar.setSpeed(tem);
            }
            else
            {
                spc.saveSpeed(tem);
            }
        }

        public int getSpeed()
        {
            return spc.loadSpeed();
        }
    }
}
