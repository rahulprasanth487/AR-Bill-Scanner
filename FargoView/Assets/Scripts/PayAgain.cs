using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayAgain : MonoBehaviour
{
    [SerializeField] GameObject PaymentDone;
    [SerializeField] GameObject Scan;
    [SerializeField] GameObject Scanning;
    [SerializeField] GameObject Details;
    [SerializeField] GameObject PaymentLoading;
    [SerializeField] GameObject ScanningDone;

    public void onPayAgain()
    {
        PaymentDone.SetActive(false);
        Scan.SetActive(true);
        Scanning.SetActive(false);
        Details.SetActive(false);
        PaymentLoading.SetActive(false);
        ScanningDone.SetActive(false);
    }
}
