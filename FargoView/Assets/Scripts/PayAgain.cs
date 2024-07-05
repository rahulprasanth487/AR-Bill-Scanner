using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PayAgain : MonoBehaviour
{
    [SerializeField] GameObject PaymentDone;
    [SerializeField] GameObject Scan;
    [SerializeField] GameObject Scanning;
    [SerializeField] GameObject Details;
    [SerializeField] GameObject PaymentLoading;
    [SerializeField] GameObject ScanningDone;
    [SerializeField] TextMeshProUGUI DetailsAmount;
    [SerializeField] TextMeshProUGUI PaymentTabAmount;
    [SerializeField] TextMeshProUGUI Tally;
    [SerializeField] GameObject SplitwisePage;

    [SerializeField] GameObject SplitwiseButton;
    [SerializeField] GameObject SplittedDetails;

    public void onPayAgain()
    {
        DetailsAmount.text="$ 166.93";
        PaymentTabAmount.text="$ 166.93";
        Tally.text="Tally Successful!";
        
        PaymentDone.SetActive(false);
        Scan.SetActive(true);
        Scanning.SetActive(false);
        Details.SetActive(false);
        PaymentLoading.SetActive(false);
        ScanningDone.SetActive(false);
        SplittedDetails.SetActive(false);
        SplitwiseButton.SetActive(true);
    }

    public void onSplitwise()
    {
        PaymentDone.SetActive(false);
        SplitwisePage.SetActive(true);
    }
}
