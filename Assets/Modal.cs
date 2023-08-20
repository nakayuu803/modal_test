using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Modal : MonoBehaviour
{
    public Transform parent;
    public Text name;
    public void create(){
        GameObject modal = (GameObject)Resources.Load("filter_error");
        Instantiate(modal, parent);
    }
    public void destroy()
    {
        GameObject modal = GameObject.Find("filter_error(Clone)");
        if(modal == null){
            modal = GameObject.Find("filter_name(Clone)");
            // string inputFieldText = GetComponent<InputField>().text;
            name.text = inputFieldText;
        }
        Destroy(modal);
    }
    public void create_name(){
        GameObject modal = (GameObject)Resources.Load("filter_name");
        Instantiate(modal, parent);

    }
}
