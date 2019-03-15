using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public String[] Operators { get; set; }
        public AExpression[] Values { get; set; }

        public Expression(string formula)
        {
            List<AExpression> expressions = new List<AExpression>();
            List<string> ops = new List<string>();
            expressions.Add(ExtractValue(ref formula));
            formula = formula.TrimStart();
            while (!formula.Equals(""))
            {
                ops.Add(formula[0].ToString());
                formula = formula.Substring(1).TrimStart();
                expressions.Add(ExtractValue(ref formula));
                formula = formula.TrimStart();
            }
            Values = expressions.ToArray();
            Operators = ops.ToArray();
        }

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
            else if ((f[0] >= '0' && f[0] <= '9') || f[0] == '.' || f[0] == ',')
            {
                float val = ExtractInt(ref f);

                // handle decimal
                if(f.Length > 0 && (f[0] == '.' || f[0] == ','))
                {
                    f = f.Substring(1).TrimStart();
                    float fract = ExtractInt(ref f);
                    while(fract >= 1)
                    {
                        fract /= 10;
                    }
                    val += fract;
                }

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
            formula = f;
            return result;
        }

        protected int ExtractInt(ref string input)
        {
            int full = 0;
            int i = 0;
            while (i < input.Length && input[i] >= '0' && input[i] <= '9')
            {
                full = full * 10 + input[i] - '0';
                ++i;
            }
            input = input.Substring(i);
            return full;
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

        public override float ComputeValue()
        {
            // FIXME code computig the value
            throw new NotImplementedException();
        }

        public override string Debug()
        {
            string elt = "(";
            for(int i=0; i<Operators.Length; i++)
            {
                elt += Values[i].Debug() + " " + Operators[i] + " ";
            }
            return elt + Values[Values.Length - 1].Debug() + ")";
        }
    }
}
