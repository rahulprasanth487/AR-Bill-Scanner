using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaymentHandler : MonoBehaviour
{
    [SerializeField] GameObject PaymentWindow;
    [SerializeField] GameObject PaymentLoading;
    [SerializeField] GameObject PaymentDone;


    public void PaymentToggle()
    {
        PaymentWindow.SetActive(false);
        PaymentLoading.SetActive(true);
        float delay = Random.Range(2f, 3f);
        Invoke("ActivateScanning", delay);
    }

    private void ActivateScanning()
    {
        PaymentLoading.SetActive(false);
        PaymentDone.SetActive(true);
    }

}
