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

            float result = Matrix1 * Matrix2;
            Console.WriteLine(result);
            result = Matrix1 - Matrix2;
            Console.WriteLine(result);

            ShallowCloneMatrix ClonedMatrix = new ShallowCloneMatrix();
            ClonedMatrix._Determinant = 2;
            ShallowCloneMatrix ClonedMatrix2 = (ShallowCloneMatrix)ClonedMatrix.Clone();
            ClonedMatrix._Determinant = 1;
            Console.WriteLine(ClonedMatrix._Determinant);
            Console.WriteLine(ClonedMatrix2._Determinant);

        }
    }
}
