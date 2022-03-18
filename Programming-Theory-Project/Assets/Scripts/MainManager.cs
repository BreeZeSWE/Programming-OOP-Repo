using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager: MonoBehaviour
{
   
    public void LoadInheritanceScene()
    {
        SceneManager.LoadScene("Inheritance");
    }
    
    public void LoadPolymorphismScene()
    {
        SceneManager.LoadScene("Polymorphism");
    }

    public void LoadEncapsulationScene()
    {
        SceneManager.LoadScene("Encapsulation");
    }

    public void LoadAbstractionScene()
    {
        SceneManager.LoadScene("Abstraction");
    }
     
}
