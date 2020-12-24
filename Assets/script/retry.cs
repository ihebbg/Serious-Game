using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class retry : MonoBehaviour {

	public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);

    }
    public void OnApplicationQuit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -3);
    }
}
