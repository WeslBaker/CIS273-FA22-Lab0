using System;
namespace Vector
{
	public struct Vector
	{
		 public double X { get; set; }
        public double Y { get; set; }

        public double Magnitude
        {
            get
            {
                return (double)Math.Sqrt(X * X + Y * Y);
            }
        }
        public double Direction
        {
            get
            {
                return Math.Atan2(Y, X) * (180 / Math.PI);
            }
        }

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Vector Add(Vector v)
        {
            Vector result = new Vector(this.X + v.X, this.Y + v.Y);
            return result;
        }
        public Vector Subtract(Vector v)
        {
            Vector result = new Vector(this.X - v.X, this.Y - v.Y);
            return result;
        }

        public double Dot(Vector v)
        {
            return this.X * v.X + this.Y * v.Y;
        }
        public double AngleBetween(Vector v)
        {
            return Math.Abs(this.Direction - v.Direction);
        }

        public override string ToString()
        {
            return $"<{this.X}, {this.Y}>";
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return a.Add(b);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return a.Subtract(b);
        }

        public static double operator *(Vector a, Vector b)
        {
            return a.Dot(b);
        }

        public static double AngleBetween(Vector a, Vector b)
        {
            return a.AngleBetween(b);
        }
    }
}

