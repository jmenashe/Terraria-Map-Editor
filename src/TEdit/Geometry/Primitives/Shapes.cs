/* 
Copyright (c) 2011 BinaryConstruct
 
This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
 */

using Microsoft.Xna.Framework.Graphics;
using System;
using System.Windows;
using TEdit.Utility;

namespace TEdit.Geometry.Primitives
{
    public static class GeometryUtils
    {
        public static Microsoft.Xna.Framework.Rectangle Frame(
             this Texture2D tex,
             int horizontalFrames = 1,
             int verticalFrames = 1,
             int frameX = 0,
             int frameY = 0,
             int sizeOffsetX = 0,
             int sizeOffsetY = 0)
        {
            int num1 = tex.Width / horizontalFrames;
            int num2 = tex.Height / verticalFrames;
            return new Microsoft.Xna.Framework.Rectangle(num1 * frameX, num2 * frameY, num1 + sizeOffsetX, num2 + sizeOffsetY);
        }

    }


    [Serializable]
    public class Rectangle<T> where T : struct
    {
        public T X1;
        public T X2;
        public T Y1;
        public T Y2;

        public Rectangle(T x1, T y1, T x2, T y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public T Left { get { return GenericOperator.Operator.GreaterThan(X2, X1) ? X1 : X2; } }
        public T Right { get { return GenericOperator.Operator.GreaterThan(X2, X1) ? X2 : X1; } }
        public T Top { get { return GenericOperator.Operator.GreaterThan(Y2, Y1) ? Y1 : Y2; } }
        public T Bottom { get { return GenericOperator.Operator.GreaterThan(Y2, Y1) ? Y2 : Y1; } }
        public T Height { get { return GenericOperator.Operator.Subtract(Right, Left); } }
        public T Width { get { return GenericOperator.Operator.Subtract(Bottom, Top); } }

        public bool Contains(T x, T y)
        {
            T zero = default(T);
            T xabs = GenericOperator.Operator.Subtract(x, Left);
            T yabs = GenericOperator.Operator.Subtract(y, Top);
            if (GenericOperator.Operator.LessThan(xabs, zero))
                return false;

            if (GenericOperator.Operator.LessThan(yabs, zero))
                return false;

            return GenericOperator.Operator.LessThan(xabs, Width) && GenericOperator.Operator.LessThan(yabs, Height);
        }

        public static Rectangle<T> FromLrtb(T left, T right, T top, T bottom)
        {
            return new Rectangle<T>(left, top, right, bottom);
        }
    }

    [Serializable]
    public class RectangleInt32 : Rectangle<int>
    {
        public RectangleInt32(int x1, int y1, int x2, int y2)
            : base(x1, x2, y1, y2)
        { }
    }
    [Serializable]
    public class RectangleFloat : Rectangle<float>
    {
        public RectangleFloat(float x1, float y1, float x2, float y2)
            : base(x1, x2, y1, y2)
        { }
    }
}
