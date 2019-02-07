using System;
using System.Drawing;

namespace RockPaperScissors
{
    class picture
    {
        private Bitmap[] image = new Bitmap[3];
        public int[] tab = new int[3];
        private int index;
        public picture()
        {
            image[0] = new Bitmap(@"..\..\kamien.jpg");
            tab[0] = 0;
            image[1] = new Bitmap(@"..\..\nozyce.jpg");
            tab[1] = 1;
            image[2] = new Bitmap(@"..\..\papier.jpg");
            tab[2] = 2;
        }

        public Bitmap get_picture(ref int i)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            index = random.Next(0, 3);
            i = index;
            return image[index];
        }
    }
}
