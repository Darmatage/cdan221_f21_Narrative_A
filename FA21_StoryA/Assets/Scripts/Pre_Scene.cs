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
		public GameObject ArtBG8;
		public GameObject ArtChar1;
		public GameObject ArtChar2;
		public GameObject ArtChar3;
		public GameObject ArtChar4;
        public GameObject nextButton;
        public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
		StartCoroutine(FadeIn(ArtBG1));
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
		ArtBG3.SetActive(false);
		ArtBG4.SetActive(false);
		ArtBG5.SetActive(false);
		ArtBG6.SetActive(false);
		ArtBG7.SetActive(false);
		ArtBG8.SetActive(false);
		ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
		ArtChar3.SetActive(false);
		ArtChar4.SetActive(false);
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
		   StartCoroutine(FadeIn(ArtBG2));
                ArtBG2.SetActive(true);
				ArtBG1.SetActive(false);
        }
       else if (primeInt == 3){
		   StartCoroutine(FadeIn(ArtBG3));
                ArtBG3.SetActive(true);
				ArtBG2.SetActive(false);
        }
       else if (primeInt == 4){
		   StartCoroutine(FadeIn(ArtBG4));
                ArtBG4.SetActive(true);
				ArtBG3.SetActive(false);
        }
       else if (primeInt == 5){
		   StartCoroutine(FadeIn(ArtBG5));
                ArtBG5.SetActive(true);
				ArtBG4.SetActive(false);
        }
       else if (primeInt ==6){
		   StartCoroutine(FadeIn(ArtBG6));
                ArtBG6.SetActive(true);
				ArtBG5.SetActive(false);
        }
		 else if (primeInt ==7){
			 StartCoroutine(FadeIn(ArtBG7));
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
		        StartCoroutine(FadeIn(ArtBG8));
		        ArtBG8.SetActive(true);
				ArtBG7.SetActive(false);
				 StartCoroutine(FadeIn(ArtChar2));
				ArtChar2.SetActive(true);
                Char1speech.text = "...";
                
        }
		else if (primeInt == 11){
			
                Char1speech.text = "Where am I...?";
                
        }
		
		else if (primeInt == 12){
			ArtChar2.SetActive(false);
			ArtChar4.SetActive(true);
                Char1speech.text = "More importantly...?";
                
        }
        
		else if (primeInt == 13){
			ArtChar4.SetActive(false);
			ArtChar1.SetActive(true);
                Char1speech.text = "Where's Mama?";
                
        }
		
	
		else if (primeInt == 14){
			ArtChar1.SetActive(false);
			ArtChar3.SetActive(true);
                Char1speech.text = "Maybe I can look for clues to find her.";
                
        }
		
		
		else if (primeInt == 15){
                Char1speech.text = "";
				SceneChange1();
                
        }
     }


        public void SceneChange1(){
               SceneManager.LoadScene("Scene1");
        }
		
        IEnumerator FadeIn(GameObject fadeImage){
                float alphaLevel = 0;
                fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
                for(int i = 0; i < 100; i++){
                        alphaLevel += 0.01f;
                        yield return null;
                        fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
                        Debug.Log("Alpha is: " + alphaLevel);
                }
        }

        IEnumerator FadeOut(GameObject fadeImage){
                float alphaLevel = 1;
                fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
                for(int i = 0; i < 100; i++){
                        alphaLevel -= 0.01f;
                        yield return null;
                        fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
                        Debug.Log("Alpha is: " + alphaLevel);
                }
        }
		
}
