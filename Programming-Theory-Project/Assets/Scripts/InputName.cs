using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{

    private InputField inputField;

    private void Start()
    {
        inputField = GameObject.Find("InputName").GetComponent<InputField>();
        inputField.onEndEdit.AddListener(delegate { onEditExit(); });
        inputField.ActivateInputField();
    }

   void onEditExit()
    {
        Debug.Log("onEndExit WORKING!");
        Globals.Instance.StartTheShow();
    }
}
