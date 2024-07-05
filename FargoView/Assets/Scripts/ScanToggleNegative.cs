using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanToggleNegative : MonoBehaviour
{
    [SerializeField] GameObject Scan;
    [SerializeField] GameObject Scanning;
    [SerializeField] GameObject ErrDisplay;
    [SerializeField] GameObject DetailsPanel;
    [SerializeField] GameObject ScanErr;


    public void toggleScan()
    {
        Scan.SetActive(false);
        Scanning.SetActive(true);
        float delay = Random.Range(2f, 3f);
        Invoke("ActivateScanning", delay);
    }

    private void ActivateScanning()
    {
        ScanErr.SetActive(true);
        float delay2 = Random.Range(1f, 2f);
        Invoke("ActivateDetails", delay2);
    }

    private void ActivateDetails()
    {
        Scanning.SetActive(false);
        ErrDisplay.SetActive(true);
    }

    public void displayDetails()
    {
        ErrDisplay.SetActive(false);
        DetailsPanel.SetActive(true);
    }

    public void ignoreErrBack()
    {
        Scan.SetActive(true);
        ScanErr.SetActive(false);
        ErrDisplay.SetActive(false);
    }


}
