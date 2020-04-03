using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform[] views;

    public float transitionSpeed;
    
    public GameObject Panel;

    Transform currentView;


    // Start is called before the first frame update
    void Start()
    {
        currentView = views[0];
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Panel.SetActive(true);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
                if (hit.transform.name == "Hex6")
                {
                    currentView = views[1];
                    //this.GetComponent<Renderer>().material.color = Color.blue;
                    
                }
                if (hit.transform.name == "Hex7")
                {
                    currentView = views[2];
                   // this.GetComponent<Renderer>().material.color = Color.blue;
                }
                if (hit.transform.name == "Hex8")
                {
                    currentView = views[3];
                    //this.GetComponent<Renderer>().material.color = Color.blue;
                }
                if (hit.transform.name == "Hex9")
                {
                    currentView = views[5];
                   // this.GetComponent<Renderer>().material.color = Color.blue;
                }
                if (hit.transform.name == "País gelado")
                {
                    currentView = views[4];
                    //this.GetComponent<Renderer>().material.color = Color.blue;
                }
            }
            
        }
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            Panel.SetActive(false);
            currentView = views[0];
        }

        /*if(Input.GetKeyDown (KeyCode.Alpha2))
            currentView = views[1];*/
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Lerp position
        transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);
    }
}
