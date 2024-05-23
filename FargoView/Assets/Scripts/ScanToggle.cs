using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanToggle : MonoBehaviour
{
    [SerializeField] GameObject Scan;
    [SerializeField] GameObject Scanning;
    [SerializeField] GameObject DetailsPanel;
    [SerializeField] GameObject ScanComplete;


    public void toggleScan()
    {
        Scan.SetActive(false);
        Scanning.SetActive(true);
        float delay = Random.Range(2f, 3f);
        Invoke("ActivateScanning", delay);
    }

    private void ActivateScanning()
    {
        ScanComplete.SetActive(true);
        float delay2 = Random.Range(1f, 2f);
        Invoke("ActivateDetails", delay2);
    }

    private void ActivateDetails()
    {
        Scanning.SetActive(false);
        DetailsPanel.SetActive(true);
    }


}
