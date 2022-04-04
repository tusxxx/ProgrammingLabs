using System;


namespace ProgrammingLabs
{
    class Start
    {
        static void Main(string[] args)
        {
            SquareMatrix Matrix1 = new SquareMatrix();
            Matrix1.FillRandom();
            SquareMatrix Matrix2 = new SquareMatrix();
            Matrix2.FillRandom();

            float Result = Matrix1 * Matrix2;
            Console.WriteLine(Result);
            Result = Matrix1 - Matrix2;
            Console.WriteLine(Result);

            ShallowCloneMatrix ClonedMatrix = new ShallowCloneMatrix();
            ClonedMatrix._Determinant = 2;
            ShallowCloneMatrix ClonedMatrix2 = (ShallowCloneMatrix)ClonedMatrix.Clone();
            ClonedMatrix._Determinant = 1;
            Console.WriteLine(ClonedMatrix._Determinant);
            Console.WriteLine(ClonedMatrix2._Determinant);
        }
    }
}
