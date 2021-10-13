using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene1 : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        //public Text Char2name; 
       // public Text Char2speech;
       // public Text Char3name;
        //public Text Char3speech;
        public GameObject dialogue;
        public GameObject ArtChar1;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice1c;
        public GameObject Choice1d;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
		public GameObject NextScene3Button;
        public GameObject NextScene4Button; //still to add
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
        Choice1d.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
		NextScene3Button.SetActive(false);
        NextScene4Button.SetActive(false);
        nextButton.SetActive(true);
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
                Char1name.text = "Baby Platypus";
                Char1speech.text = "I need to find Mama.";
                
        }
       else if (primeInt ==3){
                Char1name.text = "Baby Platypus";
                Char1speech.text = " Where should I look?";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
				Choice1c.SetActive(true);
                
        }
      
// ENCOUNTER AFTER CHOICE #1

       else if (primeInt == 100){
                Char1name.text = "Baby Platypus";
                Char1speech.text = "Let's follow the footprints!";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char1name.text = "Baby Platypus";
                Char1speech.text = "Let's go to the bush.";
				nextButton.SetActive(false);
				allowSpace = false;
                NextScene2Button.SetActive(true);
        }
       else if (primeInt == 300){
                Char1name.text = "Baby Platypus";
                Char1speech.text = "Let's go to the tree hole";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene3Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "Baby Platypus";
                Char1speech.text = "Let's follow the footprints!";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
				Choice1d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "Baby Platypus";
                Char1speech.text = "Let's go to the bush.";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
				Choice1d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1cFunct(){
                Char1name.text = "Baby Platypus";
                Char1speech.text = "Let's go to the tree hole";
                primeInt = 299;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
				Choice1d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void SceneChange1(){
               SceneManager.LoadScene("Scene2a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
		 public void SceneChange3(){
                SceneManager.LoadScene("Scene2b");
        }
}