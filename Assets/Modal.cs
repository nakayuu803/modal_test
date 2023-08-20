using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Modal : MonoBehaviour
{
    public Transform parent;
    public InputField inputField;
    // public Text name;
    public void create(){
        GameObject modal = (GameObject)Resources.Load("filter_error");
        Instantiate(modal, parent);
    }
    public void destroy()
    {
        GameObject modal = GameObject.Find("filter_error(Clone)");
        if(modal == null){
            modal = GameObject.Find("filter_name(Clone)");
            GameObject name = GameObject.Find("name");
            inputField = inputField.GetComponent<InputField> ();
            // UnityEngine.Debug.Log(inputField.text);
            Text work_name = name.GetComponent<Text> ();
            work_name.text = inputField.text;
        }
        Destroy(modal);
    }
    public void create_name(){
        GameObject modal = (GameObject)Resources.Load("filter_name");
        Instantiate(modal, parent);

    }
}
