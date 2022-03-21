using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLabs
{
    class SquareMatrix: IComparable, IOriginator
    {
        private int[,] _Matrix;
        public float _Determinant = new Random().Next(1, 10);
        public SquareMatrix()
        {
             _Matrix = new int[3,3];
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

        public object GetMemento()
        {
            return new Memento { _Matrix = this._Matrix };
        }

        public void SetMemento(object Memento)
        {
            if (Memento is Memento)
            {
                var Mem = Memento as Memento;
                _Matrix = Mem._Matrix;
            }
        }
    }

    class Memento
    {
        public int[,] _Matrix { get; set; }
    }

    public interface IOriginator
    {
        object GetMemento();
        void SetMemento(object memento);
    }

    public class Caretaker
    {
        private object Memento;
        public void SaveState(IOriginator originator)
        {
            Memento = originator.GetMemento();
        }

        public void RestoreState(IOriginator originator)
        {
            originator.SetMemento(Memento);
        }
    }

}
