using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene2c : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        //public Text Char3name;
        public Text Char3speech;
        public GameObject dialogue;
        public GameObject ArtChar1;
		public GameObject ArtChar2;
		public GameObject ArtChar3;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
		ArtChar3.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
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
                ArtChar2.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "Baby Platypus";
                Char1speech.text = "";
                Char2speech.text = "There’s a noise coming from this bush…";
				Char2name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt ==3){
                ArtChar2.SetActive(false);
                ArtChar1.SetActive(true);
                Char1name.text = "Baby Platypus";
                Char1speech.text = "Hello? Is anyone there...";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt == 4){
		        // AudioSource.Play();
                Char1name.text = "Baby Platypus";
                Char1speech.text = "Hellloooo…?";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt == 5){
                // AudioSource.Play();
				ArtChar1.SetActive(false);
                ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "Rabbit";
				Char3speech.text = "W-who are you?!";
        }
       else if (primeInt == 6){
                ArtChar3.SetActive(false);
                ArtChar1.SetActive(true);
                Char1name.text = "Baby Platypus";
                Char1speech.text = "Oh me? I’m a little lo-";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt ==7){
                ArtChar1.SetActive(false);
                ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "Rabbit";
				Char3speech.text = "ARE YOU GOING TO HURT ME?";
        }
		else if (primeInt ==8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "Rabbit";
				Char3speech.text = "I-I bet you are! Ohhh no no no…. W-what do I do?";
        }
		else if (primeInt == 9){
                ArtChar3.SetActive(false);
                ArtChar1.SetActive(true);
                Char1name.text = "Baby Platypus";
                Char1speech.text = "I’m not going to hurt you?";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
        }
		 else if (primeInt ==10){
                ArtChar1.SetActive(false);
                ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "Rabbit";
				Char3speech.text = "I won’t be d-deceived by you!";
        }
		 else if (primeInt ==11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "Rabbit";
				Char3speech.text = "Before you can hurt me I’ll… I’ll…";
        }
		else if (primeInt == 12){
                ArtChar3.SetActive(false);
                ArtChar1.SetActive(true);
                Char1name.text = "Baby Platypus";
                Char1speech.text = "You’ll…?";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
        }
		 else if (primeInt ==13){
                ArtChar1.SetActive(false);
                ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "Rabbit";
				Char3speech.text = "RUN!";
        }
		else if (primeInt == 14){
                ArtChar3.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "?";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
        }
		else if (primeInt == 15){
                ArtChar3.SetActive(false);
                ArtChar2.SetActive(true);
                Char1name.text = "Baby Platypus";
                Char1speech.text = "";
                Char2speech.text = "What do I do? They might know something about mama…";
				Char2name.text = "";
				Char3speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                 Char1name.text = "Baby Platypus";
                Char1speech.text = "STOP!";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char1name.text = "Baby Platypus";
                Char1speech.text = "Let's just head back and look for Mama.";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
			    ArtChar2.SetActive(false);
                ArtChar1.SetActive(true);
                Char1name.text = "Baby Platypus";
                Char1speech.text = "Wait! Hold on!";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "Baby Platypus";
                Char1speech.text = "";
                Char2speech.text = "Ugh, nevermind...";
				Char2name.text = "";
				Char3speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene2a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
}