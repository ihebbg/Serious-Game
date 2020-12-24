using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class time : MonoBehaviour {

    private float timeStar = 60;
    public Text textbox;

    // Use this for initialization
    void Start () {
        textbox.text = timeStar.ToString();

       

    }
	
	// Update is called once per frame
	void Update () {

    
        


            timeStar -= Time.deltaTime;
        if (timeStar < 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
       


        textbox.text = Mathf.Round(timeStar).ToString();
     
    }
   
}
