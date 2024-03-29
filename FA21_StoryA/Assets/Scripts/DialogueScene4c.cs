using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene4c : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name; //BABY PLATYPUS
        public Text Char1speech; //BABY PLATYPUS
        public Text Char2name; //RABBIT
        public Text Char2speech; //BABY PLATYPUSTHINK
        public Text Char3name; //SNAKE
        public Text Char3speech; //RABBIT
		public Text Char4speech; //SNAKE
        public GameObject dialogue;
        public GameObject ArtChar1;
		public GameObject ArtChar2;
		public GameObject ArtChar3;
		public GameObject ArtChar4;
		public GameObject ArtChar5;
		public GameObject ArtChar6;
		public GameObject ArtChar7;
		public GameObject ArtChar8;
		public GameObject ArtChar9;
		public GameObject ArtChar10;
		public GameObject ArtChar11;
		public GameObject ArtChar12;
		public GameObject ArtChar13;
		public GameObject ArtBam;
        public GameObject ArtBG1;
        public GameObject nextButton;
        public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
		StartCoroutine(FadeIn(ArtChar3));
		ArtChar3.SetActive(true);
		ArtChar4.SetActive(false);
		ArtChar5.SetActive(false);
		ArtChar6.SetActive(false);
		ArtChar7.SetActive(false);
		ArtChar8.SetActive(false);
		ArtChar9.SetActive(false);
		ArtChar10.SetActive(false);
		ArtChar11.SetActive(false);
		ArtChar12.SetActive(false);
		ArtChar13.SetActive(false);
		ArtBam.SetActive(false);
		StartCoroutine(FadeIn(ArtBG1));
        ArtBG1.SetActive(true);
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
			  // AudioSource.Play();
               ArtChar3.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "";
                Char1speech.text = ""; 
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "She should be right around here…";
				Char3name.text = "";
				Char4speech.text = "";
        }
       else if (primeInt ==3){
                ArtChar2.SetActive(true);
                ArtChar3.SetActive(false);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Around here? Are you sure?"; 
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
				Char3name.text = "";
				Char4speech.text = "";
        }
       else if (primeInt == 4){
                ArtChar8.SetActive(true);
                ArtChar2.SetActive(false);
                Char1name.text = "";
                Char1speech.text = ""; 
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "Yeah I’m sure!";
				Char3name.text = "";
				Char4speech.text = "";
        }
       else if (primeInt == 5){
                ArtChar2.SetActive(true);
                ArtChar8.SetActive(false);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "I dunno. It seems kinda scary here."; 
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
				Char3name.text = "";
				Char4speech.text = "";
        }
       else if (primeInt == 6){
                ArtChar9.SetActive(true);
                ArtChar2.SetActive(false);
                Char1name.text = "";
                Char1speech.text = ""; 
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "OH! I think I see her!";
				Char3name.text = "";
				Char4speech.text = "";
        }
       else if (primeInt ==7){
                ArtChar2.SetActive(true);
                ArtChar9.SetActive(false);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Y-you do?"; 
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
				Char3name.text = "";
				Char4speech.text = "";
        }
		 else if (primeInt == 8){
                ArtChar8.SetActive(true);
                ArtChar2.SetActive(false);
                Char1name.text = "";
                Char1speech.text = ""; 
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "Yeah right there… now!";
				Char3name.text = "";
				Char4speech.text = "";
        }
		 else if (primeInt == 9){
                ArtChar4.SetActive(true);
                ArtChar8.SetActive(false);
                Char1name.text = "";
                Char1speech.text = ""; 
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
				Char3name.text = "SNAKE";
				Char4speech.text = "Got 'em. Good work Rabbit.";
        }
		 else if (primeInt == 10){
                ArtChar9.SetActive(true);
                ArtChar4.SetActive(false);
                Char1name.text = "";
                Char1speech.text = ""; 
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "Woah, nice catch Snake! Don’t let the kid up.";
				Char3name.text = "";
				Char4speech.text = "";
        }
		else if (primeInt == 11){
                ArtChar7.SetActive(true);
                ArtChar9.SetActive(false);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "W-what going on here?! Ack-"; 
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
				Char3name.text = "";
				Char4speech.text = "";
        }
		else if (primeInt == 12){
                ArtChar10.SetActive(true);
                ArtChar7.SetActive(false);
                Char1name.text = "";
                Char1speech.text = ""; 
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
				Char3name.text = "SNAKE";
				Char4speech.text = "Stop moving.";
				
			if (gameHandler.isOwl()){
				primeInt = 22;
			}
	
        }
		else if (primeInt == 13){
                ArtChar8.SetActive(true);
                ArtChar10.SetActive(false);
                Char1name.text = "";
                Char1speech.text = ""; 
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "Wow now that was too easy! With this my debts paid right Snake?";
				Char3name.text = "";
				Char4speech.text = "";
        }
		else if (primeInt == 14){
                ArtChar11.SetActive(true);
                ArtChar8.SetActive(false);
                Char1name.text = "";
                Char1speech.text = ""; 
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
				Char3name.text = "SNAKE";
				Char4speech.text = "Sure, but don’t get too cocky.";
        }
		else if (primeInt == 15){
                ArtChar6.SetActive(true);
                ArtChar11.SetActive(false);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = ""; 
                Char2speech.text = "Everything is getting blurry…";
				Char2name.text = "";
				Char3speech.text = "";
				Char3name.text = "";
				Char4speech.text = "";
        }
		else if (primeInt == 16){
                ArtChar9.SetActive(true);
                ArtChar6.SetActive(false);
                Char1name.text = "";
                Char1speech.text = ""; 
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "Sorry lil’ one but it’s survival of the fittest out here.";
				Char3name.text = "";
				Char4speech.text = "";
        }
		else if (primeInt == 17){
                Char1name.text = "";
                Char1speech.text = ""; 
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "It’s a shame you’re going to learn that the hard way.";
				Char3name.text = "";
				Char4speech.text = "";
        }
		else if (primeInt == 18){
                ArtChar5.SetActive(true);
                ArtChar9.SetActive(false);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = ""; 
                Char2speech.text = "Ugh… can’t… breath…";
				Char2name.text = "";
				Char3speech.text = "";
				Char3name.text = "";
				Char4speech.text = "";
        }
       else if (primeInt == 19){
               Char1name.text = "BABY PLATYPUS";
                Char1speech.text = ""; 
                Char2speech.text = "I hope... Mama… is ok…";
				Char2name.text = "";
				Char3speech.text = "";
				Char3name.text = "";
				Char4speech.text = "";
                
        }
		 else if (primeInt == 20){
             SceneChange1();
                
        }
		
		//if player has talked to owl
		else if (primeInt == 23){
			    ArtBam.SetActive(true);
                ArtChar1.SetActive(true);
                ArtChar10.SetActive(false);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = ""; 
                Char2speech.text = "TAKE THAT!";
				Char2name.text = "";
				Char3speech.text = "";
				Char3name.text = "";
				Char4speech.text = "";
        }
		else if (primeInt == 24){
			    ArtBam.SetActive(false);
                ArtChar1.SetActive(false);
                ArtChar12.SetActive(true);
                Char1name.text = "";
                Char1speech.text = ""; 
                Char2speech.text = "";
				Char2name.text = "";
				Char3speech.text = "";
				Char3name.text = "SNAKE";
				Char4speech.text = "AHH!";
        }
		else if (primeInt == 25){
                ArtChar12.SetActive(false);
                ArtChar13.SetActive(true);
                Char1name.text = "";
                Char1speech.text = ""; 
                Char2speech.text = "";
				Char2name.text = "RABBIT";
				Char3speech.text = "WHERE ARE YOU GOING! But wait! Our deal...";
				Char3name.text = "";
				Char4speech.text = "";
        }
		else if (primeInt == 26){
                ArtChar13.SetActive(false);
                ArtChar2.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = ""; 
                Char2speech.text = "Now's my chance to get out of here!";
				Char2name.text = "";
				Char3speech.text = "";
				Char3name.text = "";
				Char4speech.text = "";
        }
		else if (primeInt == 27){
               SceneChange2();
        }
		
		
     }



        public void SceneChange1(){
               SceneManager.LoadScene("Scene_Lose2");
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