using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene6a : MonoBehaviour {
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
       // public GameObject Choice1a;
        //public GameObject Choice1b;
        public GameObject NextScene1Button;
        //public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
		ArtChar3.SetActive(false);
        ArtBG1.SetActive(true);
        //Choice1a.SetActive(false);
        //Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
       // NextScene2Button.SetActive(false);
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
                Char1speech.text = "Here we are...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3speech.text = "";
        }
       else if (primeInt ==3){
                ArtChar1.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Bear";
                Char2speech.text = "Finally, made it out!";
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Bear";
                Char2speech.text = "Thanks to you, I can finally go get some berries!";
        }
       else if (primeInt == 5){
               ArtChar1.SetActive(true);
               ArtChar3.SetActive(false);
                Char1name.text = "Baby Platypus";
                Char1speech.text = "I’m glad I could help!";
                Char2name.text = "";
                Char2speech.text = "";
                
        }
       else if (primeInt == 6){
                 ArtChar3.SetActive(true);
               ArtChar1.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Bear";
                Char2speech.text = "Good luck finding your Mama!";
        }
       else if (primeInt ==7){
                 Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Bear";
                Char2speech.text = "OH!";
        }
		 else if (primeInt ==8){
                 Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Bear";
                Char2speech.text = "And one more thing...";
        }
		 else if (primeInt ==9){
                 Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Bear";
                Char2speech.text = "I may be pretty old, but I still got some fight in me and a good set of ears";
        }
		else if (primeInt ==10){
                 Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Bear";
                Char2speech.text = "If you ever need any help, don’t hesitate to call out to your Old Papa Bear!";
        }
		else if (primeInt ==11){
                 Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3speech.text = "OLD BEAR PROTECTION SERVICES ACQUIRED";
				//gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 12){
                ArtChar1.SetActive(true);
               ArtChar3.SetActive(false);
                Char1name.text = "Baby Platypus";
                Char1speech.text = "Thank you!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
}

        public void SceneChange1(){
               SceneManager.LoadScene("Scene1");
        }

       
}
