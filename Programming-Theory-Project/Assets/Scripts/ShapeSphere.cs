using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSphere : ShapeBase //Inheritance
{
    private MainManager mainManager;

    void Start()
    {
        mainManager = GameObject.Find("Main Manager").GetComponent<MainManager>();
    }


    private void UpdateScore()
    {
       mainManager.UpdateScore("Sphere", hitPoint);
    }

    //Polymorhism
    public override void ApplyHit()
    {
        base.ApplyHit();
        UpdateScore();
        Debug.Log("Cube: ApplyHit(), hitPoint = " + hitPoint);
    }

}
   