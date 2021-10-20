using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene4b : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       // public Text Char3name;
        public Text Char3speech;
		public Text Char4speech;
        public GameObject dialogue;
        public GameObject ArtChar1; //happy platypus
		public GameObject ArtChar2; //thinking platypus
		public GameObject ArtChar3; //fox smile
		public GameObject ArtChar4; //fox surprised
		public GameObject ArtChar5; // fox wink
        public GameObject ArtBG1;
		public GameObject ArtBG2;
        public GameObject Choice1a;
        public GameObject Choice1b;
        //public GameObject NextScene1Button;
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
		ArtChar4.SetActive(false);
		ArtChar5.SetActive(false);
		StartCoroutine(FadeIn(ArtBG1));
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        //NextScene1Button.SetActive(false);
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
                Char2speech.text = "Whew, I made it!";
				Char3speech.text = "";
				Char4speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Huh? There’s two different berries?";
				Char3speech.text = "";
				Char4speech.text = "";
        }
       else if (primeInt == 4){
				ArtChar2.SetActive(false);
                ArtChar1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "HEY MR.FOX! There’s two different types of berries!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3speech.text = "";
				Char4speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Which one should I pick?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3speech.text = "";
				Char4speech.text = "";
        }
       else if (primeInt == 6){
                ArtChar1.SetActive(false);
                ArtChar5.SetActive(true);
				ArtBG1.SetActive(false);
				ArtBG2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "FOX";
				Char3speech.text = "The red ones. Definitely the red ones.";
				Char4speech.text = "";
        }
       else if (primeInt ==7){
                ArtChar5.SetActive(false);
                ArtChar1.SetActive(true);
				ArtBG2.SetActive(false);
				ArtBG1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Okay!";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
				Char4speech.text = "";
        }
		 else if (primeInt ==8){
                ArtChar1.SetActive(false);
                ArtChar4.SetActive(true);
				ArtBG1.SetActive(false);
				ArtBG2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "FOX";
				Char3speech.text = "Or is it the white ones?";
				Char4speech.text = "";
        }
		 else if (primeInt ==9){
			    ArtChar4.SetActive(false);
                ArtChar1.SetActive(true);
				ArtBG2.SetActive(false);
				ArtBG1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "WHAT!";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
				Char4speech.text = "";
        }
		else if (primeInt ==10){
                ArtChar1.SetActive(false);
                ArtChar4.SetActive(true);
				ArtBG1.SetActive(false);
				ArtBG2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "FOX";
				Char3speech.text = "I know one of them are the sweet, ripe, delicious berries...";
				Char4speech.text = "";
        }
		else if (primeInt ==11){
			    Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "FOX";
				Char3speech.text = "But the other ones are super poisonous berries that make your very sick...";
				Char4speech.text = "";
        }
		else if (primeInt ==12){
			    Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "FOX";
				Char3speech.text = "Ahhh, what to do...";
				Char4speech.text = "";
        }
		else if (primeInt ==13){
			    ArtChar4.SetActive(false);
                ArtChar1.SetActive(true);
				ArtBG2.SetActive(false);
				ArtBG1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "HOW COULD YOU POSSIBLE FORGET SOMETHING SO IMPORTANT!!!";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
				Char4speech.text = "";
        }
		else if (primeInt ==14){
			    ArtChar1.SetActive(false);
                ArtChar5.SetActive(true);
				ArtBG1.SetActive(false);
				ArtBG2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "FOX";
				Char3speech.text = "Ok, Ok, Ok,";
				Char4speech.text = "";
        }
		else if (primeInt ==15){
			    ArtChar5.SetActive(false);
                ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "FOX";
				Char3speech.text = "I’m pretty, sure it was the white berries";
				Char4speech.text = "";
        }
		else if (primeInt ==16){
                ArtChar3.SetActive(false);
                ArtChar1.SetActive(true);
				ArtBG2.SetActive(false);
				ArtBG1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2speech.text = "Ughh this might as well be 50-50 odds.";
				Char2name.text = "";
				Char3speech.text = "";
				Char4speech.text = "";
        }
		else if (primeInt ==17){
				ArtChar1.SetActive(false);
                ArtChar2.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2speech.text = "Which one should I pick?";
				Char2name.text = "";
				Char3speech.text = "";
				Char4speech.text = "";
				 // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
       
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2speech.text = "*eats white berries*";
				Char2name.text = "";
				Char3speech.text = "";
				Char4speech.text = "";
        }
		 else if (primeInt == 101){
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2speech.text = "ughh I don’t feel so good...";
				Char2name.text = "";
				Char3speech.text = "";
				Char4speech.text = "";
        }
       else if (primeInt == 102){
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2speech.text = "Ughh...";
				Char2name.text = "";
				Char3speech.text = "";
				Char4speech.text = "";
                
        }
		 else if (primeInt == 103){
                SceneChange1();
                
        }

       else if (primeInt == 200){
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2speech.text = "*eats red berries*";
				Char2name.text = "";
				Char3speech.text = "";
				Char4speech.text = "";
        }
		else if (primeInt == 201){
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Wow! These are amazing!!";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
				Char4speech.text = "";
        }
		else if (primeInt == 202){
			    ArtChar1.SetActive(false);
                ArtChar2.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2speech.text = "I must have made the right choice!";
				Char2name.text = "";
				Char3speech.text = "";
				Char4speech.text = "";
        }
		else if (primeInt == 203){
                Char1name.text = "";
                Char1speech.text = "";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
				Char4speech.text = "BERRY POWER ACQUIRED!";
				gameHandler.UpdateBerries();
        }
		else if (primeInt == 204){
			    ArtChar2.SetActive(false);
                ArtChar1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Thanks for nothing Mr. Fox!";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
				Char4speech.text = "";
        }
       else if (primeInt == 205){
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "";
                Char2speech.text = "Time to resume searching...";
				Char2name.text = "";
				Char3speech.text = "";
				Char4speech.text = "";
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
                Char1speech.text = "White Berries it is.";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
				Char4speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
			    ArtChar2.SetActive(false);
                ArtChar1.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Red Berries it is.";
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
				Char4speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene_Lose1"); //Loose Screen
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