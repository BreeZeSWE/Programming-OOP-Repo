using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class MainManager: MonoBehaviour
{
    [SerializeField] private Text cubeText;
    [SerializeField] private Text sphereText;

    public void UpdateScore(string Shape, int Amount)
    {
        if (Shape == "Cube")
        {
            cubeText.text = "Cube Point: " + Amount;
        } else if (Shape == "Sphere")
        {
            sphereText.text = "Sphere Point: " + Amount;
        }
    }

    private void Update()
    {
        if ((Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl)) && Input.GetKeyDown(KeyCode.W))        
        {
#if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#else
            Application.Quit(); // original code to quit Unity player
#endif
            
        }
    }
}
