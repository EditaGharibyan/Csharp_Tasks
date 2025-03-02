using System.Runtime.Intrinsics;

namespace _3D_Vector
{
    public class Vector3D
    {
        private int x;
        private int y;
        private int z;
        public Vector3D(int xx, int yy, int zz)
        {
            x = xx;
            y = yy;
            z = zz;
        }
        public override string ToString()
        {
            return $"x={x} y={y} z={z}";
        }
        public static Vector3D operator +(Vector3D obj, Vector3D obj1)
        {
            obj.x = obj.x + obj1.x;
            obj.y = obj.y + obj1.y;
            obj.z = obj.z + obj1.z;

            return obj;
        }
        public static Vector3D operator -(Vector3D obj, Vector3D obj1)
        {
            obj.x = obj.x - obj1.x;
            obj.y = obj.y - obj1.y;
            obj.z = obj.z - obj1.z;

            return obj;
        }
        public static int operator *(Vector3D obj, Vector3D obj1)
        {
            int sc = obj.x * obj1.x + obj.y * obj1.y + obj.z * obj1.z;
            return sc;
        }
        public static double operator /(Vector3D obj, Vector3D obj1)
        {
            double scd = obj.x / obj1.x + obj.y / obj1.y + obj.z / obj1.z;
            return scd;
        }
        public static bool operator ==(Vector3D obj, Vector3D obj1)
        {
            return obj.x == obj1.x && obj.y == obj1.y && obj.z == obj1.z;

        }
        public static bool operator !=(Vector3D obj, Vector3D obj1)
        {
            return !(obj == obj1);

        }
        public static bool operator true(Vector3D obj)
        {

            return (obj.x != 0 && obj.y != 0 && obj.z != 0);
        }
        public static bool operator false(Vector3D obj)
        {

            return (obj.x == 0 || obj.y == 0 || obj.z == 0);
        }
        public override bool Equals(Object v)
        {
            if (v is Vector3D other)
            {
                return this.x == other.x && this.y == other.y && this.z == other.z;
            }
            return false;
        }
        public override int GetHashCode()
        {
            int hash = x.GetHashCode() ^ y.GetHashCode() ^ z.GetHashCode();
            return hash;
        }
        public static bool operator <(Vector3D v, Vector3D v1)
        {
            return v.x < v1.x && v.y < v1.y && v.z < v1.z;
        }
        public static bool operator >(Vector3D v, Vector3D v1)
        {
            return v.x > v1.x && v.y > v1.y && v.z > v1.z;
        }
        public static bool operator <=(Vector3D v, Vector3D v1)
        {
            return v.x <= v1.x && v.y <= v1.y && v.z <= v1.z;
        }
        public static bool operator >=(Vector3D v, Vector3D v1)
        {
            return v.x >= v1.x && v.y >= v1.y && v.z >= v1.z;
        }
    }
    internal class Vector3D
    {
        static void Main(string[] args)
        {
            Vector3D v = new Vector3D(1, 1, 1);
            Console.WriteLine($"v{v.ToString()}");
            Vector3D v1 = new Vector3D(1, 2, 3);
            Console.WriteLine($"v{v1.ToString()}");
            Vector3D v2 = v + v1;
            Console.WriteLine($"v{v.ToString()}");
            Console.WriteLine($"v{v1.ToString()}");
            Vector3D v3 = v - v1;
            int v4 = v * v1;
            Console.WriteLine($"v4={v4}");
            string tostr = v2.ToString();
            string tostr1 = v3.ToString();
            Console.WriteLine($"tostring V+V2: {tostr}");

        }
    }
}
