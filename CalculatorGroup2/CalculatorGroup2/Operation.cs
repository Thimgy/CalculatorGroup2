using System;
using System.Collections.Generic;

namespace Operation
{
    /// <summary>
    /// Class defining priority and symbole to match with each operator
    /// </summary>
    public abstract class BinaryOperation
    {
        public static BinaryOperation addition = new OperationAddition();
        public static BinaryOperation substraction = new OperationSubstraction();
        public static BinaryOperation multiplication = new OperationMultiplication();
        public static BinaryOperation division = new OperationDivision();
        public static BinaryOperation modulo = new OperationMod();

        public static IEnumerable<BinaryOperation> ListOps()
        {
            yield return addition;
            yield return substraction;
            yield return multiplication;
            yield return division;
            yield return modulo;
        }

        public readonly string id;
        public readonly int priority;
        public BinaryOperation(string id, int priority)
        {
            this.id = id;
            this.priority = priority;
        }

        public abstract float Perform(float nb1, float nb2);
    }

    public class OperationAddition : BinaryOperation
    {
        public OperationAddition() : base("+", 0)
        { }

        public override float Perform(float nb1, float nb2)
        {
            return nb1 + nb2;
        }

        public static float PerformAddition(float nb1, float nb2)
        {
            return BinaryOperation.addition.Perform(nb1, nb2);
        }
    }

    public class OperationSubstraction : BinaryOperation
    {
        public OperationSubstraction() : base("-", 0)
        { }
        public override float Perform(float nb1, float nb2)
        {
            return nb1 - nb2;
        }

        public static float PerformSubstraction(float nb1, float nb2)
        {
            return BinaryOperation.substraction.Perform(nb1, nb2);
        }
    }

    public class OperationMultiplication : BinaryOperation
    {
        public OperationMultiplication() : base("X", 1)
        { }
        public override float Perform(float nb1, float nb2)
        {
            return nb1 * nb2;
        }

        public static float PerformationMultiplication(float nb1, float nb2)
        {
            return BinaryOperation.multiplication.Perform(nb1, nb2);
        }
    }

    public class OperationDivision : BinaryOperation
    {
        public OperationDivision() : base("/", 1)
        { }
        public override float Perform(float nb1, float nb2)
        {
            return nb1 / nb2;
        }

        public static float PerformationDivision(float nb1, float nb2)
        {
            return BinaryOperation.division.Perform(nb1, nb2);
        }
    }
    public class OperationMod : BinaryOperation
    {
        public OperationMod() : base("%", 1)
        { }
        public override float Perform(float nb1, float nb2)
        {
            return nb1 % nb2;
        }

        public static float PerformationMod(float nb1, float nb2)
        {
            return BinaryOperation.modulo.Perform(nb1, nb2);
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

}
