using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modaldes : MonoBehaviour
{
    public void destroy()
    {
        Debug.Log("消す！");
        GameObject modal = GameObject.Find("filter(Clone)");
        Destroy(modal);
    }
}
