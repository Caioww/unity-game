using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgressBar : MonoBehaviour
{
    private Slider slider;
    private ParticleSystem particleSys;
    public float FillSpeed = 0.5f;
    private float targetProgress=100;
    public Text progressText;

    private void Awake(){
        slider = GameObject.Find("Progress Bar").GetComponent<Slider>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        IncrementProgress(1.00f);
    }

    // Update is called once per frame
    void Update()
    {
        slider = GameObject.Find("Progress Bar").GetComponent<Slider>();
        if(slider.value < targetProgress){
            slider.value+= FillSpeed * Time.deltaTime;
            progressText.text="Loading...";

            
            
        
            
        }else{
            
            SceneManager.LoadScene("Cena");
        }
        
    }
    

    public void IncrementProgress(float newProgress){
        targetProgress= slider.value+newProgress;
    }
}
