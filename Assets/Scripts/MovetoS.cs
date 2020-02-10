using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovetoS : MonoBehaviour
{
    private PartOneStateManage POSM;
    public GameObject oPOSM;

    private void Start()
    {
        POSM = oPOSM.GetComponent<PartOneStateManage>();
    }
    public void NextPart()
    {
        POSM.ShowPart8();
    }
}
