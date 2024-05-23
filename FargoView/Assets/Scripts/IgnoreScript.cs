using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreScript : MonoBehaviour
{
    [SerializeField] GameObject Scan;

    public void ScanDisappear()
    {
        Scan.SetActive(false);
    }
}
