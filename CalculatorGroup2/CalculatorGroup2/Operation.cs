using System;

namespace Operation
{
    public class OperationAddition
    {
        public static float PerformAddition(float nb1, float nb2)
        {
            return nb1 + nb2;
        }
    }

    public class OperationSubstraction
    {
        public static float PerformSubstraction(float nb1, float nb2)
        {
            return nb1 - nb2;
        }
    }

    public class OperationMultiplication
    {
        public static float PerformationMultiplication(float nb1, float nb2)
        {
            return nb1 * nb2;
        }
    }

    public class OperationDivision
    {
        public static float PerformationDivision(float nb1, float nb2)
        {
            return nb1 / nb2;
        }
    }
    public class OperationSquare
    {
        public static float PerformationSquare(float nb1)
        {
            return (float)Math.Pow(nb1, 2);
        }
    }

    public class OperationRoot
    {
        public static float PerformationRoot(float nb1)
        {
            return (float) Math.Sqrt(nb1);
        }
    }

    public class OperationMod
    {
        public static float PerformationMod(float nb1, float nb2)
        {
            return (float) nb1%nb2;
        }
    }

}
