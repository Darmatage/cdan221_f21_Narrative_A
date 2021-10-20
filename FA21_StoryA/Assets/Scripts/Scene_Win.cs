using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene_Win : MonoBehaviour {
       
	   
  public GameObject NextScene1Button;
 


void Start(){         // initial visibility settings

    NextScene1Button.SetActive(true);

		

   
    
}
  public void SceneChange1(){
               SceneManager.LoadScene("Credits");
        }
       
}
