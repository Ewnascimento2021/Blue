using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FactoryController : MonoBehaviour
{
    [SerializeField]
    private string factoryName;
    private bool iAmSelected;

    void Update()
    {
        //if (ReferenceController.Instance.factoryName == factoryName)
        //{
        //    Debug.Log(ReferenceController.Instance.factoryName);
        //    iAmSelected = true;
        //}
        //else if (iAmSelected)
        //{
        //    Debug.Log(ReferenceController.Instance.factoryName);
        //    iAmSelected = false;
        //}
    }
}
