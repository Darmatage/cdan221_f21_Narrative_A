using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene2d : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
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
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
		
		if (gameHandler.isOwl()){
			primeInt = 39;
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
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "A tree hole?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
		       // AudioSource.Play();
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "There's snoring coming from inside!";
                Char2name.text = "";
                Char2speech.text = "";

        }

       else if (primeInt == 4){
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Should I wake up the sleeping creature?";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
		
		
		//been to owl
		else if (primeInt == 40){
			    ArtChar1.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OWL";
                Char2speech.text = "Didn't we talk already?";
        }
		
		else if (primeInt == 41){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OWL";
                Char2speech.text = "Let me sleep!";
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		
		
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
               ArtChar1.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "H-hello? Is anyone up there?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==101){
                ArtChar1.SetActive(false);
                ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OWL";
                Char2speech.text = "Zzz-h-huh?! Hello? Who's out there?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 102){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OWL";
                Char2speech.text = "Oh, hello down there! I didn't expect company today, but I must say, why so glum chum?";
        }
       else if (primeInt == 103){
                ArtChar1.SetActive(true);
                ArtChar2.SetActive(false);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "I'm trying to find my Mama, we got seperated because of the storm last night...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 104){
                ArtChar1.SetActive(false);
                ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OWL";
                Char2speech.text = "Oh my goodness you poor thing! To be that little and lost, especially after a storm, no wonder you're upset!";
        }
       else if (primeInt ==105){
                ArtChar1.SetActive(true);
                ArtChar2.SetActive(false);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "You haven't seen my Mama anywhere have you?!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 106){
		        ArtChar2.SetActive(true);
                ArtChar1.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OWL";
                Char2speech.text = "I'm sorry but no...you see I'm a very heavy sleeper, I can sleep through almost anything. I slept through that whole storm last night until just now.";
	   }
	   else if (primeInt == 107){
		        ArtChar1.SetActive(true);
                ArtChar2.SetActive(false);
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Oh no...well, I’m really sorry for waking you Mister Owl…";
                Char2name.text = "";
                Char2speech.text = "";
	   }
	    else if (primeInt == 108){
		        ArtChar2.SetActive(true);
                ArtChar1.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OWL";
                Char2speech.text = "Oh don’t worry about it! In fact, I should be thanking you! I almost slept through breakfast!";
	   }
	   else if (primeInt == 109){  //this is where you can finish the script copy and paste and add 1 to prime int
                ArtChar2.SetActive(true);
                ArtChar1.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OWL";
                Char2speech.text = "By the way I must warn you! Beware of the snakes in this forest, they love to come out and hunt for food after a storm, especially after one like last night.";
	   }
     else if (primeInt == 110){  
                ArtChar2.SetActive(true);
                ArtChar1.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OWL";
                Char2speech.text = "But don't fret! Snakes hate loud noises and vibrations, you can always scare off snakes by smacking that tail of yours on the ground really hard.";
    }
    else if (primeInt == 111){ 
                ArtChar1.SetActive(true);
                ArtChar2.SetActive(false);
                 Char1name.text = "BABY PLATYPUS";
                 Char1speech.text = "*Gulp* Thank you for the warning Mister Owl...I'll remember what you said.";
                 Char2name.text = "";
                 Char2speech.text = "";
    }

	    else if (primeInt == 112){ //this will be your last line
		            ArtChar2.SetActive(true);
                ArtChar1.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OWL";
                Char2speech.text = "No problem! And watch out for that shaking bush over there...never know what could be hiding in there”";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                 Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Let's go back and look for Mama.";
                Char2name.text = "";
                Char2speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }

     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "AHHHHHHHHHHHHHHHHHHH";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				gameHandler.UpdateOwl();
        }
        public void Choice1bFunct(){
                Char1name.text = "BABY PLATYPUS";
                Char1speech.text = "Nah, I'll let them sleep...";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene1");
        }
     
	  public void SceneChange2(){
               SceneManager.LoadScene("Scene1");
        }
}
