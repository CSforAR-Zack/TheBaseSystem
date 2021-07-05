using System;
using UnityEngine;
using UnityEngine.UI;

public class Converter : MonoBehaviour
{
    public InputField binaryInput = null;
    public InputField decimalInput = null;
    public string value = "0xFF";    
    public bool isBinary = false;
    public bool isOct = false;
    public bool isDec = false;
    public bool isHex = true;
    
    int numValue = 0;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            ConvertValue();
        }
    }

    void ConvertValue()
    {
        if (isBinary) {numValue = Convert.ToInt32(value, 2);}
        else if (isOct) {numValue = Convert.ToInt32(value, 8);}
        else if (isDec) {numValue = Convert.ToInt32(value, 10);}
        else if (isHex) {numValue = Convert.ToInt32(value, 16);}
        
        print($"Binary: {Convert.ToString(numValue, 2)}");
        print($"Octal: {Convert.ToString(numValue, 8)}");
        print($"Dec: {Convert.ToString(numValue, 10)}");
        print($"Hex: {Convert.ToString(numValue, 16)}");
    }
}
