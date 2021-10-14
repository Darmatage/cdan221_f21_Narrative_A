using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3c : MonoBehaviour {
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
		public GameObject Choice1c;
		public GameObject Choice1d;
		public GameObject Choice1e;
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
		Choice1c.SetActive(false);
		Choice1d.SetActive(false);
		Choice1e.SetActive(false);
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
               ArtChar1.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2speech.text = "*Huff* *huff* Where did... they go...?";
				Char2name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt ==3){
				ArtChar1.SetActive(false);
				ArtChar2.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2speech.text = "Wait! I think I see them, they’re hiding again but really poorly…";
				Char2name.text = "";
				Char3speech.text = "";

        }
       else if (primeInt == 4){
                ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "!";
        }
       else if (primeInt == 5){
                ArtChar3.SetActive(false);
				ArtChar1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Hey Rabbit! I’m really not going to hurt you, I just want to ask a question!";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt == 6){
               ArtChar1.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "H-huh? You followed me?!";
        }
       else if (primeInt ==7){
                ArtChar3.SetActive(false);
				ArtChar1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Yes, but I just want your help! I really don’t mean any harm.";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
        }
		 else if (primeInt == 8){
               ArtChar1.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "You.. you promise? You promise that you won’t hurt me?";
        }
		else if (primeInt ==9){
                ArtChar3.SetActive(false);
				ArtChar1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "I promise!";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
        }
		else if (primeInt == 10){
               ArtChar1.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "Ok. I guess I can try and help, what did you want to ask?";
        }
       else if (primeInt == 11){
                ArtChar3.SetActive(false);
				ArtChar2.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2speech.text = "Ahm… Ok!";
				Char2name.text = "";
				Char3speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
				Choice1c.SetActive(true); // function Choice1bFunct()
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                ArtChar1.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "Why am I such a- hey! How rude!";
        }
		 else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "I’ll have you know insulting someone trying to help you is mean!";
        }
       else if (primeInt == 102){
               ArtChar3.SetActive(false);
				ArtChar1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Hehe, sorry…";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
				Choice1c.SetActive(true); // function Choice1bFunct()
        }

       else if (primeInt == 200){
               ArtChar1.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "You’re looking for your mom?";
        }
		else if (primeInt == 201){
               ArtChar3.SetActive(false);
				ArtChar1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Yes! She looks just like me, but slightly bigger!";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
        }
		 else if (primeInt == 202){
               ArtChar1.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "Hmm… now that you mention I think I have!";
        }
		else if (primeInt == 203){
               ArtChar3.SetActive(false);
				ArtChar1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Really?!";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
        }
		 else if (primeInt == 204){
                ArtChar1.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "Yeah! Though then again maybe it was another platypus…";
        }
       else if (primeInt == 205){
               Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "But hey, it’s worth looking into right? I can lead you to her, but don’t get your hopes up.";
                //Choice 4 and 5
				nextButton.SetActive(false);
                allowSpace = false;
                Choice1d.SetActive(true); // function Choice1aFunct()
                Choice1e.SetActive(true); // function Choice1bFunct()
        }
		
		else if (primeInt == 300){
               ArtChar1.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "Y-you wanna know why I’m so fast?";
        }
		
		else if (primeInt == 301){
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "Hahaha well, thank you! It’s just that the overwhelming sense of death is a really good motivator to get faster at running.";
        }
		
		else if (primeInt == 302){
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "You know what I mean?";
        }
		
		else if (primeInt == 303){
               ArtChar3.SetActive(false);
				ArtChar2.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2speech.text = "Um… are they ok?";
				Char2name.text = "";
				Char3speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
				Choice1c.SetActive(true); // function Choice1bFunct()
        }
		
	//After choice 2
	
	else if (primeInt == 400){
               ArtChar1.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "Sounds good, follow me this way lil’ one.";
        }
	else if (primeInt == 401){
               ArtChar3.SetActive(false);
				ArtChar2.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2speech.text = "Am I really the little one here?";
				Char2name.text = "";
				Char3speech.text = "";
				 nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
		else if (primeInt == 500){
               ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "O-oh? Well… ok I guess.";
        }
		else if (primeInt == 501){
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "Whatever. I try to help and this is the thanks I get…";
        }
		else if (primeInt == 502){
               ArtChar3.SetActive(false);
				ArtChar1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2speech.text = "...";
				Char2name.text = "";
				Char3speech.text = "";
        }
		else if (primeInt == 503){
               ArtChar1.SetActive(false);
				ArtChar2.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2speech.text = "I should head back now...";
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
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Why are you such a scaredy cat?";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                 ArtChar2.SetActive(false);
				ArtChar1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Do you know where my mama is?";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		 public void Choice1cFunct(){
                ArtChar2.SetActive(false);
				ArtChar1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "How are you so fast?";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
                primeInt = 299;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1dFunct(){
                ArtChar3.SetActive(false);
				ArtChar1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Please. If you know where she may be, lead the way.";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
                primeInt = 399;
                Choice1d.SetActive(false);
                Choice1e.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1eFunct(){
                ArtChar3.SetActive(false);
				ArtChar2.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Sorry but I think I’ll just look on my own.";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
                primeInt = 499;
                Choice1d.SetActive(false);
                Choice1e.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene4c");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene1");
        }
}