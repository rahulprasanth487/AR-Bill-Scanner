using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitMethodSelection : MonoBehaviour
{
    [SerializeField] GameObject SplitEq;
    [SerializeField] GameObject SplitPer;
    [SerializeField] GameObject SplitEqDrop;
    [SerializeField] GameObject SplitPerDrop;
    [SerializeField] GameObject CombinedSplit;
    [SerializeField] GameObject PercentageView;
    [SerializeField] GameObject ContactPage;
    



    public void splitBtnClicked()
    {
        CombinedSplit.SetActive(true);
        Debug.Log("COMBINED BUTTON DISPLAYED");
        SplitEq.SetActive(false);
        SplitPer.SetActive(false);
    }

    public void SplitEqDropClked()
    {
        SplitEq.SetActive(true);
        Debug.Log("EQUAL SPLIT IN DROPDOWN");
        CombinedSplit.SetActive(false);
        SplitPer.SetActive(false);
        
    }

    public void SplitPerDropClked()
    {
        SplitPer.SetActive(true);
        Debug.Log("PERCENTAGE SPLIT IN DROPDOWN");
        SplitEq.SetActive(false);
        CombinedSplit.SetActive(false);
    }

    public void SplitMethodChosen()
    {
        PercentageView.SetActive(true);
        ContactPage.SetActive(false);
    }
}
