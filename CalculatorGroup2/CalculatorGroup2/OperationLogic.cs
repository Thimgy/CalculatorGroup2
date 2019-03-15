using System;
using System.Collections.Generic;
using System.Globalization;
using Operation;
using InputParsing;
using System.Linq;

public class OperationLogic
{

    public OperationLogic()
    {
    }

    public string PerformOperation(String expression)
    {
        var expr = new Expression(expression);
        float val = expr.ComputeValue();
        return val.ToString(CultureInfo.InvariantCulture.NumberFormat);

    }

}







