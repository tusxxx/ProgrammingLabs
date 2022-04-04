using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLabs
{
    class SquareMatrix: IComparable
    {
        public int X;
        private int[,] _Matrix;
        public float _Determinant = new Random().Next(1, 10);
        public DeepStructure DS;
        public SquareMatrix()
        {
            _Matrix = new int[3,3];
            DS = new DeepStructure();
        }

        public void FillRandom()
        {
            for (int stroke = 0; stroke < 3; ++stroke)
            {
                for (int column = 0; column < 3; ++column)
                {
                    _Matrix[stroke, column] = new Random().Next(1, 10);
                }
            }
            for (int stroke = 0; stroke < 3; ++stroke)
            {
                for (int column = 0; column < 3; ++column)
                {
                    Console.Write("{0} ", _Matrix[stroke, column]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Определитель: {0}", _Determinant);
            Console.WriteLine();
        }


        public static float operator /(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix) {
            return FirstMatrix._Determinant / SecondMatrix._Determinant;
        }

        
        public static float operator *(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix) {
            return FirstMatrix._Determinant * SecondMatrix._Determinant;
        }

        public static float operator +(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix) {
            return FirstMatrix._Determinant + SecondMatrix._Determinant;
        }

        public static float operator -(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix) {
            return FirstMatrix._Determinant - SecondMatrix._Determinant;
        }

        public static bool operator ==(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix) {
            return FirstMatrix._Determinant == SecondMatrix._Determinant;
        }

        public static bool operator !=(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix) {
            return FirstMatrix._Determinant != SecondMatrix._Determinant;
        }

        public override bool Equals(object Other)
        {
            if (Other == null)
            {
                return false;
            }

            if (!(Other is SquareMatrix))
            {
                return false;
            }

            return (this._Matrix == ((SquareMatrix)Other)._Matrix);
        }

        public override int GetHashCode()
        {
            int HashCode = 0;
            for (int stroke = 0; stroke < 3; ++stroke)
            {
                for (int column = 0; column < 3; ++column)
                {
                    HashCode += _Matrix[stroke, column];
                }
            }
            return HashCode;
        }

        public int CompareTo(object Object)
        {
            if (Object == null) {
                return 1;
            }

            SquareMatrix OtherMatrix = Object as SquareMatrix;
            if (OtherMatrix == null)
            {
                throw new ArgumentException("Object is not a Matrix");
            }

            return CompareTo(OtherMatrix);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    class ShallowCloneMatrix : SquareMatrix, ICloneable
    {
        public object Clone()
        {
            return (SquareMatrix)this.MemberwiseClone();
        }
    }

    class DeepStructure
    {
        public int A { get; set; }
    }
}
