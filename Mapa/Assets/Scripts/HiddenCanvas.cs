using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class HiddenCanvas : MonoBehaviour
{
    public Canvas myCanvas;

    
    void Start()
    {
       myCanvas = GameObject.Find("Canvas").GetComponent<Canvas>();
       
       
    }

    // Update is called once per frame
    void Update()
    {

         if(Input.GetMouseButtonDown(0)) {
             if(EventSystem.current.IsPointerOverGameObject()){
                 myCanvas.enabled=false;
                 
             }
           

            
            
         }
         
    }
}
