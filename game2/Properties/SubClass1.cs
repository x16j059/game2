using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game2.Properties
{
    class SubClass1
    {
    }
}

//コピペ部分
namespace Game2
{
    class TimeCounter
    {
        private Stopwatch sw;
        private long lastTime;
        private long ternTime;
        public TimeCounter()
        {
            sw = new System.Diagnostics.Stopwatch();
            lastTime = sw.ElapsedMilliseconds;
            ternTime = 3;
            sw.Start();
        }
        public long getCount()
        {
            long now = sw.ElapsedMilliseconds;
            long course = now - lastTime;
            long count = course / ternTime;
            lastTime += count * ternTime;
            return count;
        }

    }
    class Chara
    {
        public int X;
        public int Y;
        public Boolean Visible = true;
        Bitmap bitmap;

        public Chara(Bitmap b)
        {
            bitmap = b;
        }

        public void draw(Graphics g)
        {
            if (Visible)
                g.DrawImage(bitmap, X, Y);
        }
     /* Graphics g = e.Graphics;
            foreach (Chara chara in charaList)
            {
                chara.draw(g);
            }*/

}
}