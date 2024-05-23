using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankList : MonoBehaviour
{
    [SerializeField] GameObject WFButton;
    [SerializeField] GameObject MSButton;
    [SerializeField] GameObject CitiButton;
    [SerializeField] GameObject BankListPanel;
    [SerializeField] GameObject WFOption;
    [SerializeField] GameObject MSOption;
    [SerializeField] GameObject CitiOption;
    [SerializeField] GameObject Pay;

    public void onListDisplay(){
        WFButton.SetActive(false);
        MSButton.SetActive(false);
        CitiButton.SetActive(false);
        BankListPanel.SetActive(true);
        Pay.SetActive(false);
    }

    public void onWFOptionClick()
    {
        BankListPanel.SetActive(false);
        WFButton.SetActive(true);
        Pay.SetActive(true);
    }

    public void onMSOptionClick()
    {
        BankListPanel.SetActive(false);
        MSButton.SetActive(true);
        Pay.SetActive(true);
    }

    public void onCitiOptionClick()
    {
        BankListPanel.SetActive(false);
        CitiButton.SetActive(true);
        Pay.SetActive(true);
    }
}
