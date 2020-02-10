using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnonLight : MonoBehaviour
{
    private PartOneStateManage POSM;
    public GameObject oPOSM;

    // Start is called before the first frame update
    void Start()
    {
        POSM = oPOSM.GetComponent<PartOneStateManage>();
    }

    public void OnLight()
    {
        POSM.ShowPart5();
    }
}
