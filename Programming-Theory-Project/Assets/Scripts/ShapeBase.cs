    using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeBase : MonoBehaviour
{
    //This Class can be any shape. 

    protected int hitPoint = 0;
    
    //Gui
    private Rect rect = new Rect(0, 0, 100, 100);  //Intial values
    private Vector3 point; // = new Vector3(0, 0, 0);

    protected bool showAliveTimeStamp = false;

    //Encapsulation  //Property
    private float _livedTimeInSeconds = 0;
    public int livedTimeInSeconds
    {
        get
        {
            return (int)_livedTimeInSeconds;
        }

        //set
        //{
        //    //For some reason iser whants to set livetime : Demo purposes
        //    //Hinder negative value
        //    if (value < 0)
        //    {
        //       value  = 0;
        //    }
        //}
            
    }

    //Encapsulation
    public string livedTimeStamp
    {
        get
        {
            TimeSpan ts = TimeSpan.FromSeconds(_livedTimeInSeconds);
            return ts.ToString(@"dd\.hh\:mm\:ss");
        }
    }

    //Abstraction;
    protected void ActivateAliveTime(bool state)
    {
        showAliveTimeStamp = state;
    }

    private void OnGUI()
    {
        DisplayAliveTime();  //Abstraction, kind of.     
    }


    private void Start()
    {          
        //DisplayAliveTime();
    }

    //Abstraction
    protected bool EnableAliveTime(bool state)
    {
        showAliveTimeStamp = !showAliveTimeStamp;
        return showAliveTimeStamp;
    }
    
    //Abstraction
    private void DisplayAliveTime()
    {
        if (showAliveTimeStamp)
        {
            
            point = Camera.main.WorldToScreenPoint(transform.position);
            rect.x = point.x;
            rect.y = point.y;
            GUIStyle guiStyle = new GUIStyle(GUI.skin.GetStyle("label"));
            guiStyle.fontSize = 16;
            guiStyle.wordWrap = true;
            GUI.Label(rect, name + ": Alive: " + livedTimeStamp.ToString(), guiStyle);
        }
    }

    private void FixedUpdate()
    {
        //Occurs ca 50 times per second. 60/50 = 1.2 in multiply factor to seconds-
        _livedTimeInSeconds += 1.2f;
    }

    private void Update()
    {
        //This routine cannot check wheree mouse is relative to objects postion. 
    }

    private void OnMouseOver()
    {
        //Check if Right Mouse ís Clicked to Activate / Deactivate AliveTime
        if (Input.GetMouseButtonDown(1))
        {
            showAliveTimeStamp = !showAliveTimeStamp;
            Debug.Log("ShapeBase: OnMouseOver(): RightClick");
        }
    }

    public virtual void ApplyHit() //Enables //Polymorphism
    {
        hitPoint++;
        Debug.Log("ShapeBase: ApplyHit(), hitPoint = " + hitPoint);
    }

   

    public virtual void OnMouseDown()  //Changing Protection Level OnEvent //Polymorphism
    {
        Debug.Log("ShapeBase: OnMouseDown()");
        ApplyHit(); 
    }

    
}
