using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3b : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       // public Text Char3name;
        public Text Char3speech;
        public GameObject dialogue;
        public GameObject ArtChar1; //happy platypus
		public GameObject ArtChar2; //thinking platypus
		public GameObject ArtChar3; //fox smile
		public GameObject ArtChar4; //fox surprised
		public GameObject ArtChar5; // fox wink
		public GameObject ArtChar6; // fox laugh
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
        ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
		ArtChar3.SetActive(false);
		ArtChar4.SetActive(false);
		ArtChar5.SetActive(false);
		ArtChar6.SetActive(false);
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
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Wow! This is beautiful!";
				Char3speech.text = "";
				gameHandler.UpdateFox();
        }
       else if (primeInt ==3){
		        // AudioSource.Play();
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "*Stomach Growls*";
				Char3speech.text = "";
        }
       else if (primeInt == 4){
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "I’m starting to get pretty hungry though...";
				Char3speech.text = "";
        }
       else if (primeInt == 5){
                ArtChar2.SetActive(false);
                ArtChar4.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "FOX";
				Char3speech.text = "What do we have here?";
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "FOX";
				Char3speech.text = "A little baby platypus?";
        }
       else if (primeInt ==7){
                ArtChar4.SetActive(false);
                ArtChar1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Hi Mr. Fox, I’m looking for my Mama.";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
        }
		 else if (primeInt ==8){
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "She’s got a bill and a tail! Just like me but…";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
        }
		 else if (primeInt ==9){
			   // AudioSource.Play();
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "*STOMACH GROWLS LOUDER*";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
        }
		else if (primeInt ==10){
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "...";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
        }
		else if (primeInt ==11){
			    ArtChar1.SetActive(false);
                ArtChar6.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "FOX";
				Char3speech.text = "You're a hungry lil platypus aren’t you?";
        }
		else if (primeInt ==12){
			    ArtChar6.SetActive(false);
                ArtChar4.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "FOX";
				Char3speech.text = "Unfortunately I have not seen any other platypi around these parts.";
        }
		else if (primeInt ==13){
			    ArtChar4.SetActive(false);
                ArtChar5.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "FOX";
				Char3speech.text = "However, I do happen to know of something that can fill that empty stomach of yours";
        }
		else if (primeInt ==14){
			    ArtChar5.SetActive(false);
                ArtChar1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Really!";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
        }
		else if (primeInt ==15){
			    ArtChar1.SetActive(false);
                ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "FOX";
				Char3speech.text = "Why yes little platypus!";
        }
		else if (primeInt ==16){
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "FOX";
				Char3speech.text = "In fact it’s easy to get for someone like you, with those webbed feet and powerful tail.";
        }
		else if (primeInt ==17){
				ArtChar3.SetActive(false);
                ArtChar4.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "FOX";
				Char3speech.text = "All you need to do is cross that river there";
        }
		else if (primeInt ==18){
				ArtChar4.SetActive(false);
                ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "FOX";
				Char3speech.text = "And you’ll see bushes with hundreds of ripe delicious berries!";
        }
		else if (primeInt ==19){
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "FOX";
				Char3speech.text = "So… will you cross the river?!";
        }
		else if (primeInt ==20){
				ArtChar3.SetActive(false);
                ArtChar2.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2speech.text = "Hmm it’s hard to trust a fox…";
				Char2name.text = "";
				Char3speech.text = "";
        }
		else if (primeInt ==21){
			  // AudioSource.Play();
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2speech.text = "*Stomach growls*";
				Char2name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt == 22){
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2speech.text = "But I don’t have much of a choice…";
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
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Thanks Mr.Fox! I'll go get those berries!";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt == 101){
               ArtChar1.SetActive(false);
                ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "FOX";
				Char3speech.text = "Good Luck!";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                ArtChar2.SetActive(false);
                ArtChar1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Thanks Mr.Fox... But I think I'm going to head back to look for Mama.";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt == 201){
                 ArtChar1.SetActive(false);
                ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "FOX";
				Char3speech.text = "Good Luck!";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                ArtChar2.SetActive(false);
                ArtChar1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "I'll cross the river!";
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
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "It's too risky, it's safer to head back.";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene4b");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene1");
        }
}