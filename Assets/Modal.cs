using System;
using System.Linq.Expressions;
// using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Modal : MonoBehaviour
{
    public Transform parent;
    public InputField inputField;

    public void create_error(){
        // if(完了ボタンが押されたとき全てが選択されていなかったら)){
        GameObject modal = (GameObject)Resources.Load("filter_error");
        GameObject cilmodal  = modal.transform.Find("modal").gameObject;
        GameObject modaltext  = cilmodal.transform.Find("errortext").gameObject;
        Text errortext = modaltext.GetComponent<Text> ();
        errortext.text = "エラー文表示";
        Instantiate(modal, parent);
        // }
    }
   
    public void create_name(){
        GameObject modal = (GameObject)Resources.Load("filter_name");
        Instantiate(modal, parent);

    }

    public void create_nocelect(){
        // if(削除、カラーボタンなどが押されたときオブジェクトが選択されていなかったら){
        GameObject modal = (GameObject)Resources.Load("filter_error");
        GameObject cilmodal  = modal.transform.Find("modal").gameObject;
        GameObject modaltext  = cilmodal.transform.Find("errortext").gameObject;
        Text errortext = modaltext.GetComponent<Text> ();
        errortext.text = "オブジェクトを選択してください。";
        Instantiate(modal, parent);
    // }
    }

    public void destroy_error()
    {
        GameObject modal = GameObject.Find("filter_error(Clone)");
        Destroy(modal);

    }
    
    public void destroy_name()
    {
        GameObject modal = GameObject.Find("filter_name(Clone)");
        GameObject name = GameObject.Find("name");
        inputField = inputField.GetComponent<InputField> ();
        Text work_name = name.GetComponent<Text> ();
        work_name.text = inputField.text;
        Destroy(modal);
    }
        
}
