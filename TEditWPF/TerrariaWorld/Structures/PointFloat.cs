﻿namespace TEditWPF.TerrariaWorld.Structures
{
    public struct PointFloat
    {
        public PointFloat(float x, float y)
        {
            _x = x;
            _y = y;
        }

        private float _x;
        public float X
        {
            get { return _x; }
            set { _x = value; }
        }

        private float _y;
        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }

        #region Operator Overrides

        private static bool MatchFields(PointFloat a, PointFloat m)
        {
            return (a.X == m.X && a.Y == m.Y);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj is PointFloat)
                return MatchFields(this, (PointFloat)obj);

            return false;
        }

        public bool Equals(PointFloat p)
        {
            return MatchFields(this, p);
        }

        public static bool operator ==(PointFloat a, PointFloat b)
        {
            return MatchFields(a, b);
        }

        public static bool operator !=(PointFloat a, PointFloat b)
        {
            return !(a == b);
        }

        public static PointFloat operator +(PointFloat a, PointFloat b)
        {
            return new PointFloat(a.X + b.X, a.Y + b.Y);
        }

        public static PointFloat operator -(PointFloat a, PointFloat b)
        {
            return new PointFloat(a.X - b.X, a.Y - b.Y);
        }

        public static PointFloat operator /(PointFloat a, PointFloat b)
        {
            return new PointFloat(a.X / b.X, a.Y / b.Y);
        }

        public static PointFloat operator *(PointFloat a, PointFloat b)
        {
            return new PointFloat(a.X * b.X, a.Y * b.Y);
        }

        public override int GetHashCode()
        {
            int result = 17;
            result = result * 37 + X.GetHashCode();
            result = result * 37 + Y.GetHashCode();
            return result;
        }

        #endregion
    }
}