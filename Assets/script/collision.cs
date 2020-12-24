using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour {

    public GameObject panel_cow;
    public GameObject panel_horse;
    public GameObject panel_cat;
    public GameObject panel_chicken;
    public GameObject panel_sheep;

  





    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "cow")
        {

            panel_cow.SetActive(true);

            

        }
        
        if (col.gameObject.name == "horse")
        {

            panel_horse.SetActive(true);

        }
        
        if (col.gameObject.name == "Cat")
        {

            panel_cat.SetActive(true);

        }
      
            if (col.gameObject.name == "chiken")
        {

            panel_chicken.SetActive(true);
        }
        if (col.gameObject.name == "sheep")
        {
            panel_sheep.SetActive(true);
        }
    }
    }
