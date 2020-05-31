using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEdit.Geometry.Primitives
{
    [Serializable]
    public class Vector2<T> where T : struct
    {
        public T X { get; set; }
        public T Y { get; set; }

        public Vector2(T x, T y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        #region Equality

        public bool Equals(Vector2<T> other)
        {
            return other.X.Equals(X) && other.Y.Equals(Y);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (obj.GetType() != typeof(Vector2<T>)) return false;
            return Equals((Vector2<T>)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X.GetHashCode() * 397) ^ Y.GetHashCode();
            }
        }

        public static bool operator ==(Vector2<T> left, Vector2<T> right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Vector2<T> left, Vector2<T> right)
        {
            return !left.Equals(right);
        }

        #endregion
    }

    [Serializable]
    public class Vector3<T> where T : struct
    {
        public T X { get; set; }
        public T Y { get; set; }
        public T Z { get; set; }

        public Vector3(T x, T y, T z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        }

        #region Equality

        public bool Equals(Vector3<T> other)
        {
            return other.X.Equals(X) && other.Y.Equals(Y) && other.Z.Equals(Z);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (obj.GetType() != typeof(Vector3<T>)) return false;
            return Equals((Vector3<T>)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = X.GetHashCode();
                result = (result * 397) ^ Y.GetHashCode();
                result = (result * 397) ^ Z.GetHashCode();
                return result;
            }
        }

        public static bool operator ==(Vector3<T> left, Vector3<T> right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Vector3<T> left, Vector3<T> right)
        {
            return !left.Equals(right);
        }
        #endregion
    }
}