using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObject : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
                if (hit.transform.name == "Hex7")
                {
                    GameObject.Find("Hex6").GetComponent<Renderer>().material.color = Color.red;
                    this.GetComponent<Renderer>().material.color = Color.blue;
                }
                
                if (hit.transform.name == "Hex6")
                {
                    GameObject.Find("Hex7").GetComponent<Renderer>().material.color = Color.red;
                    this.GetComponent<Renderer>().material.color = Color.blue;
                }
            
                
            }
        }
    }
}