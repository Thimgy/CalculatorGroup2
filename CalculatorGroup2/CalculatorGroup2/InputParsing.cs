using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Operation;

namespace InputParsing
{
    abstract public class AExpression
    {
        public abstract float ComputeValue();
        public abstract string Debug();
    }

    public class FixedValue : AExpression
    {
        public float Value{ get; set; }

        public override float ComputeValue()
        {
            return this.Value;
        }
        public override string Debug()
        {
            return Value.ToString().Replace(',', '.');
        }
    }

    public class NegWrapper : AExpression
    {
        public AExpression Expr { get; set; }
        public override float ComputeValue()
        {
            return -this.Expr.ComputeValue();
        }
        public override string Debug()
        {
            return "-" + Expr.Debug();
        }
    }

    public class Expression : AExpression
    {

        private static readonly Regex numberReg = new Regex(@"^[+-]?(\d+(\.\d*)?|\.\d+)(e[+-]?\d+)?", RegexOptions.IgnoreCase);
        public BinaryOperation[] Operators { get; set; }
        public AExpression[] Values { get; set; }
        protected int maxPriority;

        public Expression(string formula)
        {
            this.maxPriority = 0;
            List<AExpression> expressions = new List<AExpression>();
            List<BinaryOperation> ops = new List<BinaryOperation>();
            expressions.Add(ExtractValue(ref formula));
            formula = formula.TrimStart();
            while (!formula.Equals(""))
            {
                ops.Add(ExtractOperator(ref formula));
                expressions.Add(ExtractValue(ref formula));
            }
            Values = expressions.ToArray();
            Operators = ops.ToArray();
        }

        #region ExtractValue

        protected AExpression ExtractValue(ref string formula)
        {
            AExpression result;
            string f = formula.TrimStart();

            // handle -sign
            bool wrapInNeg = f[0] == '-';
            if(wrapInNeg)
            {
                f = f.Substring(1).TrimStart();
            }
            if (f[0] == '(')
            {
                int closingPos = SearchClosingBracket(f);
                result = new Expression(f.Substring(1, closingPos - 1));
                f = f.Substring(closingPos + 1);
            }
            else if ((f[0] >= '0' && f[0] <= '9') || f[0] == '.')
            {
                var m = numberReg.Match(f);
                if(!m.Success)
                {
                    throw new ArgumentException("Invalid number format");
                }
                float val = float.Parse(m.Value, CultureInfo.InvariantCulture.NumberFormat);
                f = f.Substring(m.Length);
                result = new FixedValue { Value = val };
            }
            else
            {
                throw new NotSupportedException("Unknown value format");
            }
            
            if(wrapInNeg)
            {
                result = new NegWrapper() {Expr = result};
            }
            formula = f.TrimStart();
            return result;
        }

        protected int SearchClosingBracket(string expr)
        {
            int nbBracket = 1;
            for(int i=1; i<expr.Length; i++)
            {
                char ch = expr[i];
                if(ch == '(')
                {
                    nbBracket++;
                }
                else if(ch == ')')
                {
                    nbBracket--;
                    if(nbBracket == 0)
                    {
                        return i;
                    }
                }
            }
            throw new ArgumentException("No closing bracket found");
        }
        #endregion

        #region ExtractOperator
        protected BinaryOperation ExtractOperator(ref string formula)
        {
            Console.WriteLine(formula);
            foreach (var op in BinaryOperation.ListOps())
            {
                if (formula.StartsWith(op.id))
                {
                    formula = formula.Substring(op.id.Length).TrimStart();
                    return op;
                }
            }
            throw new ArgumentException("Unknow operation");
        }
        #endregion

        #region Process
        public override float ComputeValue()
        {
            float[] vals = new float[this.Values.Length];
            for (int i=0; i<vals.Length; ++i)
            {
                vals[i] = this.Values[i].ComputeValue();
            }

            BinaryOperation[] ops = this.Operators;
            int length = ops.Length;
            for (int p = this.maxPriority ; p >= 0 ; p--)
            {
                // apply op of priority p
                for (int i=0 ; i < ops.Length ; i++)
                {
                    if (ops[i].priority == p)
                    {
                        vals[i + 1] = ops[i].Perform(vals[i], vals[i + 1]);
                        ops[i] = null;
                        length--;
                    }
                }

                // clean ups left over
                BinaryOperation[] newOps = new BinaryOperation[length];
                float[] newVals = new float[length+1];
                int k = 0;
                for (int i=0; i < ops.Length ; i++)
                {
                    if(ops[i] != null)
                    {
                        newVals[k] = vals[i];
                        newOps[k] = ops[i];
                        k++;
                    }
                }
                newVals[length] = vals[vals.Length - 1];

                vals = newVals;
                ops = newOps;
            }
            return vals[0];
        }
        #endregion

        public override string Debug()
        {
            string elt = "(";
            for(int i=0; i<Operators.Length; i++)
            {
                elt += Values[i].Debug() + " " + Operators[i].id + " ";
            }
            return elt + Values[Values.Length - 1].Debug() + ")";
        }
    }
}
