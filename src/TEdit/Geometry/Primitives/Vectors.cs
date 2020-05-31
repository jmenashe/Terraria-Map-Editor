/* 
Copyright (c) 2011 BinaryConstruct
 
This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
 */

using LinAlg = MathNet.Numerics.LinearAlgebra;
using DenseSingle = MathNet.Numerics.LinearAlgebra.Single.DenseVector;
using DenseDouble = MathNet.Numerics.LinearAlgebra.Double.DenseVector;
using System;

namespace TEdit.Geometry.Primitives
{
    #region Byte
    [Serializable]
    public class Vector2Byte : Vector2<Byte>
    {
        public Vector2Byte(Byte x, Byte y) : base(x, y) { }
    }
    [Serializable]
    public class Vector3Byte : Vector3<Byte>
    {
        public Vector3Byte(Byte x, Byte y, Byte z) : base(x, y, z) { }
    }
    #endregion

    #region Short
    [Serializable]
    public class Vector2Short : Vector2<Int16>
    {
        public Vector2Short(Int16 x, Int16 y) : base(x, y) { }
    }
    [Serializable]
    public class Vector3Int16 : Vector3<Int16>
    {
        public Vector3Int16(Int16 x, Int16 y, Int16 z) : base(x, y, z) { }
    }
    #endregion

    #region Int32
    [Serializable]
    public class Vector2Int32 : Vector2<int>
    {
        public Vector2Int32() : this(0, 0) { }
        public Vector2Int32(int x, int y) : base(x, y) { }
    }
    [Serializable]
    public class Vector3Int32 : Vector3<int>
    {
        public Vector3Int32(int x, int y, int z) : base(x, y, z) { }
    }
    #endregion

    #region Single
    [Serializable]
    public class Vector2 : DenseSingle
    {
        public float X
        {
            get => this.At(0);
            set => this.At(0, value);
        }
        public float Y
        {
            get => this.At(1);
            set => this.At(1, value);
        }

        public Vector2(float x, float y): base(new float[] { x, y }) { }

    }

    [Serializable]
    public class Vector3 : DenseSingle
    {
        public float X
        {
            get => this.At(0);
            set => this.At(0, value);
        }
        public float Y
        {
            get => this.At(1);
            set => this.At(1, value);
        }
        public float Z
        {
            get => this.At(2);
            set => this.At(2, value);
        }

        public Vector3(float x, float y, float z) : base(new float[] { x, y, z }) { }

    }
    #endregion
}