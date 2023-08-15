using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modalcre : MonoBehaviour
{
    public Transform parent;
    public void create(){
        GameObject modal = (GameObject)Resources.Load("filter");
        Instantiate(modal, parent);
    }
}
