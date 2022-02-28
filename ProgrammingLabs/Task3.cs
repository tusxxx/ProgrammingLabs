using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLabs
{
    class SquareMatrix: IComparable
    {
        private int[][] _Matrix;
        public SquareMatrix(int[][] SquareArray)
        {
            _Matrix = SquareArray;
        }


        public static int operator /(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix) {
            
        }

        public static int operator *(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix) {
            
        }

        public static int operator +(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix) {
            
        }

        public static int operator -(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix) {
            
        }
        
        public static int operator -(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix) {
            
        }
        
        public static int operator ==(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix) {
            
        }
        
        public static int operator !=(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix) {
            
        }

        public override bool Equals(object other)
        {
            
        }

        public override int GetHashCode()
        {

        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
