using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeCube : ShapeBase  //Inheritence
{
    private MainManager mainManager;

    

    private void ShowScore()
    {
        //mainManager.cubeText.text = "Cube Point: " + hitPoint;
        mainManager.UpdateScore("Cube", hitPoint);
         
    }


    //Stop base Class from executing OnMouseOVer and write our own.
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(2))
        {
            showAliveTimeStamp = !showAliveTimeStamp;
        }
    }

    public override void ApplyHit() //Polymorhism
    {
        hitPoint += 5;
        ShowScore();
        Debug.Log("Cube: ApplyHit(), hitPoint = " + hitPoint);
    }

    // Start is called before the first frame update
    void Start()
    {
        mainManager = GameObject.Find("Main Manager").GetComponent<MainManager>();
    }

} 
