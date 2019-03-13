using System;
using System.Collections.Generic;
using System.Globalization;
using Operation;
using System.Linq;

public class OperationLogic
{


    String[] numbers;
    float no1;
    float no2;
    float result;
    String[] newArray;
    private const int MAX_RECURSIVE_CALLS = 1000;
    private const int COUNTER_MAX = 10000;
    private const int OUTPUT_FREQUENCY = 1000;

    int counter = 0;
    public OperationLogic()
    {
    }

    public float PerformOperation(String[] array)
    {
       
        counter++;
        int length = array.Length;
        for (int i = 1; i < array.Length; i += 2)
        {

       
            if (array[i].Equals("X") || array[i].Equals("/"))
            {
                no1 = float.Parse(array[i - 1], CultureInfo.InvariantCulture.NumberFormat);
                no2 = float.Parse(array[i + 1], CultureInfo.InvariantCulture.NumberFormat);
                if (array[i].Equals("X"))
                {
                    result = OperationMultiplication.PerformationMultiplication(no1, no2);
                }
                else
                {
                    result = OperationDivision.PerformationDivision(no1, no2);
                }
                array[i + 1] = result + "";
                array[i - 1] = array[i] = "";
                length = length - 2;

            }
        }
        newArray = new String[length];
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (!array[i].Equals(""))
            {
                newArray[k] = array[i].Replace(',', '.') ;
                k++;
            }
        }
        array = newArray;

        for (int i = 1; i < array.Length; i += 2)
        {
            if (array[i].Equals("+") || array[i].Equals("-"))
            {
                no1 = float.Parse(array[i - 1], CultureInfo.InvariantCulture.NumberFormat);
                no2 = float.Parse(array[i + 1], CultureInfo.InvariantCulture.NumberFormat);
                if (array[i].Equals("+"))
                {
                    result = OperationAddition.PerformAddition(no1, no2);
                }
                else
                {
                    result = OperationSubstraction.PerformSubstraction(no1, no2);
                }
                array[i + 1] = result + "";
                array[i - 1] = array[i] = "";
                length = length - 2;

            }
        }
        newArray = new String[length];
        k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (!array[i].Equals(""))
            {
                newArray[k] = array[i].Replace(',', '.');
                k++;
            }
        }
        return result;
    }

}







