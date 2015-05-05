using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entity;

namespace DAL
{
    public class SpeedDataControl
    {

        public bool saveSpeed(int speed)
        {
            try
            {
                StreamWriter w = new StreamWriter("D:\\CarSpeed.txt");
                w.WriteLine(speed);
                w.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public int loadSpeed()
        {
            try
            {
                StreamReader r = new StreamReader("D:\\CarSpeed.txt");
                int speed = Convert.ToInt32(r.ReadLine());
                r.Close();
                return speed;
            }
            catch (Exception)
            {

                return -int.MaxValue;
            }

        }


    }
}
