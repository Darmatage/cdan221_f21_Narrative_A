using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Pre_Scene : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        
        public Text Char1speech;
        public GameObject dialogue;
        public GameObject ArtBG1;
		public GameObject ArtBG2;
		public GameObject ArtBG3;
		public GameObject ArtBG4;
		public GameObject ArtBG5;
		public GameObject ArtBG6;
		public GameObject ArtBG7;
        public GameObject nextButton;
        public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
		ArtBG3.SetActive(false);
		ArtBG4.SetActive(false);
		ArtBG5.SetActive(false);
		ArtBG6.SetActive(false);
		ArtBG7.SetActive(false);
        nextButton.SetActive(true);
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();
                }
        }
   }

//Story Units:
public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
       
       else if (primeInt ==2){
                ArtBG2.SetActive(true);
				ArtBG1.SetActive(false);
        }
       else if (primeInt == 3){
                ArtBG3.SetActive(true);
				ArtBG2.SetActive(false);
        }
       else if (primeInt == 4){
                ArtBG4.SetActive(true);
				ArtBG3.SetActive(false);
        }
       else if (primeInt == 5){
                ArtBG5.SetActive(true);
				ArtBG4.SetActive(false);
        }
       else if (primeInt ==6){
                ArtBG6.SetActive(true);
				ArtBG5.SetActive(false);
        }
		 else if (primeInt ==7){
                ArtBG7.SetActive(true);
				ArtBG6.SetActive(false);
        }
       else if (primeInt == 8){
		        dialogue.SetActive(true);
                Char1speech.text = "Mama?";
	   }
	    else if (primeInt == 9){
                Char1speech.text = "Where are you!?";
                
        }
       else if (primeInt == 10){
                Char1speech.text = "";
                SceneChange1();
        }
        
     }


        public void SceneChange1(){
               SceneManager.LoadScene("Scene1");
        }
      
		
}
