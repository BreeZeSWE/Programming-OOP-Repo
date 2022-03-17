using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Globals : MonoBehaviour
{

    public static Globals Instance;

    public Text inputName;

    public string playerName;

    public void NameEntered()
    {
        char[] charsToTrim = { '*', ' ', '\'' };
        playerName = inputName.text.Trim(charsToTrim);
    }

    public void QuitGame()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }



   public void StartTheShow()
    {
        SceneManager.LoadScene(1);
    }


}