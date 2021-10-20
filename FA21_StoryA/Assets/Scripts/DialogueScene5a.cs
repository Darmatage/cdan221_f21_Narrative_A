using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene5a : MonoBehaviour {
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
       public GameHandler gameHandler;
        //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
		StartCoroutine(FadeIn(ArtChar2));
		ArtChar2.SetActive(true);
		ArtChar3.SetActive(false);
		StartCoroutine(FadeIn(ArtBG1));
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
                Char2speech.text = "Made it to the back of the...";
                Char2name.text = "";
                Char1speech.text = "";
				Char3speech.text = "";
				gameHandler.UpdateBear();
        }
       else if (primeInt ==3){
				ArtChar2.SetActive(false);
				ArtChar1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "AH!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3speech.text = "";
        }
       else if (primeInt == 4){
                ArtChar1.SetActive(false);
				ArtChar3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
				Char2speech.text = "";
                Char2name.text = "BEAR";
                Char3speech.text = "...";
        }
       else if (primeInt == 5){
                ArtChar3.SetActive(false);
				ArtChar1.SetActive(true);
				Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Please don’t eat me sir…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3speech.text = "";
        }
       else if (primeInt == 6){
                ArtChar1.SetActive(false);
				ArtChar3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
				Char2speech.text = "";
                Char2name.text = "BEAR";
                Char3speech.text = "Ha. Ha. Ha. Ha.";
        }
       else if (primeInt ==7){
				Char1name.text = "";
                Char1speech.text = "";
				Char2speech.text = "";
                Char2name.text = "BEAR";
                Char3speech.text = "Relax little one, I am a vegetarian.";
        }
		 else if (primeInt ==8){
				Char1name.text = "";
                Char1speech.text = "";
				Char2speech.text = "";
                Char2name.text = "BEAR";
                Char3speech.text = "On a strict diet of Honey, Berries and Grass";
        }
		else if (primeInt ==9){
			    ArtChar3.SetActive(false);
				ArtChar2.SetActive(true);
				Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
				Char2speech.text = "Whew! That's a relief.";
                Char2name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==10){
				Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
				Char2speech.text = "I thought i was a goner for sure.";
                Char2name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==11){
			    ArtChar2.SetActive(false);
			 	ArtChar1.SetActive(true);
				Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Have you seen my Mama?";
				Char2speech.text = "";
                Char2name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==12){
				Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "She looks just like me, but slightly bigger!";
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
                Char2name.text = "BEAR";
                Char3speech.text = "Unfortunately, I haven’t seen your Mama";
        }
		else if (primeInt ==14){
				Char1name.text = "";
                Char1speech.text = "";
				Char2speech.text = "";
                Char2name.text = "BEAR";
                Char3speech.text = "In fact since i've reached this old age, I haven’t been able to see much of anything";
        }
		else if (primeInt ==15){
				Char1name.text = "";
                Char1speech.text = "";
				Char2speech.text = "";
                Char2name.text = "BEAR";
                Char3speech.text = "INCLUDING HOW TO GET OUT OF THIS CAVE!";
        }
		else if (primeInt ==16){
				ArtChar3.SetActive(false);
			 	ArtChar2.SetActive(true);
				Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
				Char2speech.text = "So that’s where all the growling came from...";
                Char2name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==17){
				ArtChar2.SetActive(false);
			 	ArtChar3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
				Char2speech.text = "";
                Char2name.text = "BEAR";
                Char3speech.text = "HEY!";
        }
		else if (primeInt ==18){
				Char1name.text = "";
                Char1speech.text = "";
				Char2speech.text = "";
                Char2name.text = "BEAR";
                Char3speech.text = "You're pretty young...";
        }
		else if (primeInt ==19){
				Char1name.text = "";
                Char1speech.text = "";
				Char2speech.text = "";
                Char2name.text = "BEAR";
                Char3speech.text = "Must have that good eyesight...";
        }
		else if (primeInt ==20){
				Char1name.text = "";
                Char1speech.text = "";
				Char2speech.text = "";
                Char2name.text = "BEAR";
                Char3speech.text = "Do you think you can help me out of this cave?";
        }
		else if (primeInt ==21){
			    ArtChar3.SetActive(false);
			 	ArtChar2.SetActive(true);
				Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
				Char2speech.text = "Should I help him?";
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
                ArtChar1.SetActive(false);
			 	ArtChar3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
				Char2speech.text = "";
                Char2name.text = "BEAR";
                Char3speech.text = "OH, THANK YOU SO MUCH!!!!";
        }
		else if (primeInt == 101){
				Char1name.text = "";
                Char1speech.text = "";
				Char2speech.text = "";
                Char2name.text = "BEAR";
                Char3speech.text = "You have no idea how long I’ve been stuck in this cave...";
        }
       else if (primeInt == 102){
                ArtChar3.SetActive(false);
			 	ArtChar1.SetActive(true);
				Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Let’s get you out of here then!";
				Char2speech.text = "";
                Char2name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "You’re a stranger and I don’t really know if I can trust you enough to travel through this dark cave with you...";
				Char2speech.text = "";
                Char2name.text = "";
                Char3speech.text = "";
        }
		 else if (primeInt == 201){
			    ArtChar2.SetActive(false);
			 	ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
				Char2speech.text = "";
                Char2name.text = "BEAR";
                Char3speech.text = "I understand…";
        }
		 else if (primeInt == 202){
                Char1name.text = "";
                Char1speech.text = "";
				Char2speech.text = "";
                Char2name.text = "BEAR";
                Char3speech.text = "Good luck finding your Mama…";
        }
       else if (primeInt == 203){
                ArtChar3.SetActive(false);
			 	ArtChar1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Bye...";
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
				Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Sure! I’ll help you get out of this cave!";
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
                Char1speech.text = "To be honest...";
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
               SceneManager.LoadScene("Scene6a");
        }
        public void SceneChange2(){
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