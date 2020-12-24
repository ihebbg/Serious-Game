using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class win : MonoBehaviour
{
    public Button buton_cow;
    public Button buton_horse;
    public Button buton_cat;
    public Button button_chicken;
    public Button button_sheep;
    

    void Start()
    {
        Button btn = buton_cow.GetComponent<Button>();
        
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Button btn1 = buton_horse.GetComponent<Button>();
        btn1.onClick.AddListener(Fn);
    }
    void Fn()
   {
        Button btn2 = buton_cat.GetComponent<Button>();
        btn2.onClick.AddListener(Fnn);
    }
    void Fnn()
    {
        Button btn3 = button_chicken.GetComponent<Button>();
        btn3.onClick.AddListener(Fnnn);
    }
    void Fnnn()
    {
        Button btn4 = button_sheep.GetComponent<Button>();
        btn4.onClick.AddListener(Fnnnn);
    }
    void Fnnnn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);

    }

}
