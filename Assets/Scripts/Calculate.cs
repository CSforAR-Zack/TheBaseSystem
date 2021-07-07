using System;
using UnityEngine;
using UnityEngine.UI;

public class Calculate : MonoBehaviour
{
    public InputField num1Field = null;
    public InputField num2Field = null;
    public Dropdown operation = null;
    public Dropdown num1ValueBase = null;
    public Dropdown num2ValueBase = null;
    public Text outputText = null;

    public void PerformCalculation()
    {
        float value = 0;

        long num1 = GoToDecimal(num1ValueBase.value, num1Field.text);
        long num2 = GoToDecimal(num2ValueBase.value, num2Field.text);

        switch(operation.value)
        {
            case 0:
                value = num1 + num2;
                break;
            case 1:
                value = num1 - num2;
                break;
            case 2:
                value = num1 * num2;
                break;
            case 3:
                value = num1 / num2;
                break;
        }

        outputText.text = Convert.ToString(value);
    }

    long GoToDecimal(int numBase, String value)
    {
        switch(numBase)
        {
            case 0:
                return Convert.ToInt64(value, 2);
            case 1:
                return Convert.ToInt64(value, 8);
            case 2:
                return Convert.ToInt64(value, 10);
            default:
                return Convert.ToInt64(value, 16);
        }
    }
}
