using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeypadScript : MonoBehaviour
{
    [SerializeField] GameObject amount;
    [SerializeField] GameObject keypad;
    [SerializeField] GameObject BankManage;
    [SerializeField] TextMeshProUGUI amountTextField;
    [SerializeField] TextMeshProUGUI tips;
    [SerializeField] TextMeshProUGUI PaymentDoneTab;

    public static string Pop(string str, int count = 1)
    {
        if (string.IsNullOrEmpty(str) || count <= 0)
        {
            return str;
        }

        if (count >= str.Length)
        {
            return string.Empty;
        }

        return str.Substring(0, str.Length - count);
    }

    public void openKeypad()
    {
        keypad.SetActive(true);
        BankManage.SetActive(false);
    }

    public void oneClick()
    {
        string currentText = amountTextField.text;
        amountTextField.text=currentText+"1";
    }

    public void twoClick()
    {
        string currentText = amountTextField.text;
        amountTextField.text=currentText+"2";
    }

    public void threeClick()
    {
        string currentText = amountTextField.text;
        amountTextField.text=currentText+"3";
    }

    public void fourClick()
    {
        string currentText = amountTextField.text;
        amountTextField.text=currentText+"4";
    }

    public void fiveClick()
    {
        string currentText = amountTextField.text;
        amountTextField.text=currentText+"5";
    }

    public void sixClick()
    {
        string currentText = amountTextField.text;
        amountTextField.text=currentText+"6";
    }

    public void sevenClick()
    {
        string currentText = amountTextField.text;
        amountTextField.text=currentText+"7";
    }

    public void eightClick()
    {
        string currentText = amountTextField.text;
        amountTextField.text=currentText+"8";
    }

    public void nineClick()
    {
        string currentText = amountTextField.text;
        amountTextField.text=currentText+"9";
    }

    public void zeroClick()
    {
        string currentText = amountTextField.text;
        amountTextField.text=currentText+"0";
    }

    public void dotClick()
    {
        string currentText = amountTextField.text;
        amountTextField.text=currentText+".";
    }

    public void delClick()
    {
        string currentText = amountTextField.text;
        amountTextField.text=Pop(currentText);
    }

    public void updateTips()
    {
        string currentAmountString = amountTextField.text;
        string numericPart = currentAmountString.Substring(2).Trim();
        double newAmount = double.Parse(numericPart);
        double oldAmount = 166.93;

        double tipsAmount = newAmount - oldAmount;

        tips.text = "$" + Math.Round(tipsAmount, 2) + " tips added!";
        PaymentDoneTab.text="$ "+newAmount;

        keypad.SetActive(false);
        BankManage.SetActive(true);
    }
}
