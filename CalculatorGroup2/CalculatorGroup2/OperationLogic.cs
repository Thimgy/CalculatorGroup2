using System;
using System.Collections.Generic;
using System.Globalization;
using Operation;
using InputParsing;
using System.Linq;

public class OperationLogic
{


    float no1;
    float no2;
    float result;
    String[] newArray;

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







