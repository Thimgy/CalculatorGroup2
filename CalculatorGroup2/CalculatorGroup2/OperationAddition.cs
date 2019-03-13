using System;


    public class OperationAddition
    {
        public float PerformAddition(float nb1, float nb2)
        {
            return nb1 + nb2;
        }

    internal float PerformAddition(string v1, string v2)
    {
        throw new NotImplementedException();
    }
}

    public class OperationSubstraction
    {
        public float PerformSubstraction(float nb1, float nb2)
        {
            return nb1 - nb2;
        }
    }

    public class OperationMultiplication
    {
        public float PerformationMultiplication(float nb1, float nb2)
        {
            return nb1 * nb2;
        }
    }

    public class OperationDivision
    {
        public float PerformationDivision(float nb1, float nb2)
        {
            return nb1 / nb2;
        }
    }

