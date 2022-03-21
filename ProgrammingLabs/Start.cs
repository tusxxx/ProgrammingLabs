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

            Caretaker Caretaker1 = new Caretaker();
            Caretaker1.SaveState(Matrix1);
            

            result = Matrix1 * Matrix2;
            Console.WriteLine(result);


        }
    }
}
