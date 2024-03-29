using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene2a : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        //public Text Char2name;
        public Text Char2speech;
        //public Text Char3name;
        //public Text Char3speech;
        public GameObject dialogue;
        public GameObject ArtChar1;
		public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
        public GameHandler gameHandler;
        //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
		
        dialogue.SetActive(false);
        ArtChar1.SetActive(true);
		ArtChar2.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
		
		if (gameHandler.isBear() || gameHandler.isFox()){
			primeInt = 4;
		}
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();
                }
        }
   }

public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
				ArtChar1.SetActive(true);
                dialogue.SetActive(true);
				Char2speech.text = "";
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Mama?";
                
        }
       else if (primeInt ==3){
				ArtChar1.SetActive(false);
				ArtChar2.SetActive(true);
                Char1speech.text = "";
                Char2speech.text = "Huh..? There's two different sets of foot prints.";
              
        }
       else if (primeInt == 4){
			   Char1speech.text = "";
               Char2speech.text = "The footprints on the left look much bigger than the footprints on the right.";
        }
       else if (primeInt == 5){
		   ArtChar1.SetActive(false);
		   ArtChar2.SetActive(true);
		  if (!gameHandler.isBear() && !gameHandler.isFox()){
				Char1speech.text = "";
                Char2speech.text = "Which footprints should I follow?";
		  }
		   if (gameHandler.isBear() || gameHandler.isFox()){
			   dialogue.SetActive(true);
				Char1speech.text = "";
                Char2speech.text = "Back here again...";
		  }
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
				if (gameHandler.isBear() == false){
			   Choice1a.SetActive(true); // function Choice1aFunct()
		}
                 if (gameHandler.isFox()== false){
                Choice1b.SetActive(true); // function Choice1bFunct()
				 }

        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
				Char1speech.text = "";
                Char1name.text = "BABY PLATYPUS";
                Char2speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                
        }

       else if (primeInt == 200){
                Char1speech.text = "";
                Char1name.text = "BABY PLATYPUS";
                Char2speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
       
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
				ArtChar2.SetActive(false);
				ArtChar1.SetActive(true);
                Char1speech.text = "";
                Char1name.text = "BABY PLATYPUS";
                Char2speech.text = "Let's follow the bigger footprints then!";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
				ArtChar2.SetActive(false);
				ArtChar1.SetActive(true);
                Char1speech.text = "";
                Char1name.text = "BABY PLATYPUS";
                Char2speech.text = "Let's follow the smaller footprints then!";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene3a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene3b");
        }
}