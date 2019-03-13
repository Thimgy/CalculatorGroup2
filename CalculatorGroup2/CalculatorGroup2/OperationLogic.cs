using System;
using System.Collections.Generic;
using System.Globalization;
using Operation;

public class OperationLogic
{


    String[] numbers;
    float no1;
    float no2;
    float result;
    String[] newArray;
    public OperationLogic(String input)
    {
        numbers = input.Split(' ');
    }

    public float PerformOperation(String[] array)
    {

        for (int i = 0; i < numbers.Length; i++)
        {
            switch (numbers[i])
            {
                case "+":

                    no1 = float.Parse(numbers[i - 1], CultureInfo.InvariantCulture.NumberFormat);
                    no2 = float.Parse(numbers[i + 1], CultureInfo.InvariantCulture.NumberFormat);
                    result = OperationAddition.PerformAddition(no1, no2);
                    String[] newArray = new String[numbers.Length - 2];
                    for (int k = 0; k < newArray.Length; k++)
                    {
                        if (numbers[k].Equals(numbers[i - 1]))
                        {
                            newArray[k] = result + "";
                        }
                        if (!numbers[k].Equals(numbers[i]) && !numbers[k].Equals(numbers[i]))
                        {
                            newArray[k] = numbers[k];
                        }
                    }
                    PerformOperation(newArray);
                    break;
                case "-":


                    no1 = float.Parse(numbers[i - 1], CultureInfo.InvariantCulture.NumberFormat);
                    no2 = float.Parse(numbers[i + 1], CultureInfo.InvariantCulture.NumberFormat);
                    result = OperationSubstraction.PerformSubstraction(no1, no2);
                    newArray = new String[numbers.Length - 2];
                    for (int k = 0; k < newArray.Length; k++)
                    {
                        if (numbers[k].Equals(numbers[i - 1]))
                        {
                            newArray[k] = result + "";
                        }
                        if (!numbers[k].Equals(numbers[i]) && !numbers[k].Equals(numbers[i]))
                        {
                            newArray[k] = numbers[k];
                        }
                    }
                    PerformOperation(newArray);
                    break;

                case "*":
                    no1 = float.Parse(numbers[i - 1], CultureInfo.InvariantCulture.NumberFormat);
                    no2 = float.Parse(numbers[i + 1], CultureInfo.InvariantCulture.NumberFormat);
                    result = OperationMultiplication.PerformationMultiplication(no1, no2);
                    newArray = new String[numbers.Length - 2];
                    for (int k = 0; k < newArray.Length; k++)
                    {
                        if (numbers[k].Equals(numbers[i - 1]))
                        {
                            newArray[k] = result + "";
                        }
                        if (!numbers[k].Equals(numbers[i]) && !numbers[k].Equals(numbers[i]))
                        {
                            newArray[k] = numbers[k];
                        }
                    }
                    PerformOperation(newArray);
                    break;


                case "/":

                    no1 = float.Parse(numbers[i - 1], CultureInfo.InvariantCulture.NumberFormat);
                    no2 = float.Parse(numbers[i + 1], CultureInfo.InvariantCulture.NumberFormat);
                    result = OperationDivision.PerformationDivision(no1, no2);
                    newArray = new String[numbers.Length - 2];
                    for (int k = 0; k < newArray.Length; k++)
                    {
                        if (numbers[k].Equals(numbers[i - 1]))
                        {
                            newArray[k] = result + "";
                        }
                        if (!numbers[k].Equals(numbers[i]) && !numbers[k].Equals(numbers[i]))
                        {
                            newArray[k] = numbers[k];
                        }
                    }
                    PerformOperation(newArray);
                    break;

            }
        }
        return result;
    }
}






