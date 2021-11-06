using System;

namespace les3
{
    class Program
    {
        private class Rectangle
        {
            private float x;
            private float y;
            private float width;
            private float height;

            public Rectangle(float x, float y, float height, float width)
            {
                this.x = x;
                this.y = y;
                this.height = height;
                this.width = width;
            }

           
            public Rectangle(float size)
            {
                this.width = size;
                this.height = size;
            }
            public Rectangle(float width, float height)
            {
                this.width = width;
                this.height = height;
            }

            public Rectangle(float x, float y, float size)
            {
                this.x = x;
                this.y = y;
                this.height = size;
                this.width = size;
            }

            public void MoveTo(float x, float y)
            {
                this.x = x;
                this.y = y;
            }

            public bool IsSquare()
            {
                return this.width == this.height;
            }

            public void Set(float x, float y, float width, float height)
            {
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
            }

            public float GetWidth()
            {
                return this.width;
            }

            public float GetHeight()
            {
                return this.height;
            }
        }

        static void Main(string[] args)
        {
            Rectangle rechthoek = new Rectangle(100, 100, 50, 50);
            Rectangle vierkant = new Rectangle(50, 50, 50);
            Rectangle vierkantBeweeg = new Rectangle(50);
            Rectangle rechthoekBeweeg = new Rectangle(20, 30);

            vierkantBeweeg.MoveTo(50, 50);
            rechthoekBeweeg.Set(100, 100, rechthoek.GetWidth(), rechthoek.GetHeight());
            vierkant.IsSquare();

            Console.WriteLine(vierkant);
        }
    }
}
