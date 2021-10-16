using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene2e : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text BabyPlatname;
        public Text BabyPlatspeech;
		public Text BabyPlatthoughts;
        public Text MamaPlatname;
        public Text MamaPlatspeech;
        public Text Snakename;
        public Text Snakespeech;
		public Text Bearname;
        public Text Bearspeech;
        public GameObject dialogue;
        public GameObject ArtPlat1;
		public GameObject ArtPlat2;
		public GameObject ArtMama1;
		public GameObject ArtMama2;
		public GameObject ArtSnake1;
		public GameObject ArtBear1;
		public GameObject ArtBam;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice1c;
        public GameObject Choice1d;
		public GameObject Choice1e;
        public GameObject Choice1f;
        public GameObject nextButton;
        public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtPlat1.SetActive(false);
		ArtPlat2.SetActive(false);
		ArtMama1.SetActive(false);
		ArtMama2.SetActive(false);
		ArtSnake1.SetActive(false);
		ArtBear1.SetActive(false);
		ArtBam.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
        Choice1d.SetActive(false);
		Choice1e.SetActive(false);
        Choice1f.SetActive(false);
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
                ArtMama1.SetActive(true);
				ArtSnake1.SetActive(true);
                dialogue.SetActive(true);
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "MAMA";
                MamaPlatspeech.text = "HELP ME!!!";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";

        }
       else if (primeInt ==3){
                ArtMama1.SetActive(false);
				ArtSnake1.SetActive(false);
                ArtPlat2.SetActive(true);
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "Oh no, my mom is in trouble!";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
        }
       else if (primeInt == 4){
               BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "That snake look super dangerous...";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
        }
       else if (primeInt == 5){
                 ArtMama1.SetActive(true);
				ArtSnake1.SetActive(true);
                ArtPlat2.SetActive(false);
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "MAMA";
                MamaPlatspeech.text = "Help me! This snake is going to bite me!";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
        }
       else if (primeInt == 6){
                 ArtMama1.SetActive(false);
				ArtSnake1.SetActive(false);
                ArtPlat2.SetActive(true);
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "What should I do?";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
				 nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
				if (gameHandler.isBearHelp()){
			     Choice1c.SetActive(true); // function Choice1cFunct()
				}

        }
      
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
		        ArtPlat2.SetActive(false);
				ArtPlat1.SetActive(true);
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "HEY SNAKE!";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
        }
       else if (primeInt == 101){
		        ArtMama1.SetActive(true);
				ArtSnake1.SetActive(true);
                ArtPlat1.SetActive(false);
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "SNAKE";
                Snakespeech.text = "Hmm, What's this?";
				Bearname.text = "";
                Bearspeech.text = "";
                
        }
		 else if (primeInt == 102){

                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "SNAKE";
                Snakespeech.text = "Haha, you should have ran away when you could! you really think you can defeat me!";
				Bearname.text = "";
                Bearspeech.text = "";
                
        }
		 else if (primeInt == 103){
		        ArtMama1.SetActive(false);
				ArtSnake1.SetActive(false);
                ArtPlat1.SetActive(true);
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "I do!";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
				 nextButton.SetActive(false);
                allowSpace = false;
                Choice1d.SetActive(true); // function Choice1dFunct()
				 if (gameHandler.isBerries()){
               Choice1e.SetActive(true); // function Choice1eFunct()
				 }
				  if (gameHandler.isOwl()){
              Choice1f.SetActive(true); // function Choice1fFunct()
				 }
                
        }

       else if (primeInt == 200){
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "I can't beat a snake on my own.";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
        }
       else if (primeInt == 201){
                 BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "I need to get out of here, I don’t want to die!";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
        }
		 else if (primeInt == 202){
			 //add rainy background
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "Mama?";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
        }
		else if (primeInt == 203){
			 //add rainy background
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "MAMA?";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
        }
		else if (primeInt == 204){
			 //add rainy background
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "I'M SORRY PLEASE WAKE UP!";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
        }
		else if (primeInt == 205){
			 //add rainy background
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "Mama...";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
        }
		else if (primeInt == 206){
			SceneChange1();
        }
		
		else if (primeInt == 300){
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "Bear! I need your help!";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
        }
		else if (primeInt == 301){
      			ArtPlat2.SetActive(false);
				ArtBear1.SetActive(true);
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "BEAR";
                Bearspeech.text = "HEY YOU!";
        }
		else if (primeInt == 302){
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "BEAR";
                Bearspeech.text = "STAY AWAY FROM THAT PLATYPUS!";
        }
		else if (primeInt == 303){
			    ArtMama1.SetActive(true);
				ArtSnake1.SetActive(true);
                ArtBear1.SetActive(false);
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "SNAKE";
                Snakespeech.text = "AHHH!";
				Bearname.text = "";
                Bearspeech.text = "";
        }
		else if (primeInt == 304){
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "SNAKE";
                Snakespeech.text = "I'm sorry Mr. Bear. I'll be leaving right now. Yep. Won't touch platypi ever again. Bye Bye now.";
				Bearname.text = "";
                Bearspeech.text = "";
        }
		else if (primeInt == 305){
			    ArtMama2.SetActive(true);
				ArtSnake1.SetActive(false);
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "MAMA";
                MamaPlatspeech.text = "Whew, I thought I was done for.";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
        }
		else if (primeInt == 306){
			    ArtMama2.SetActive(false);
				ArtPlat1.SetActive(true);
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "Mom! Are you okay?!";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
        }
		else if (primeInt == 307){
			    ArtMama2.SetActive(true);
				ArtPlat1.SetActive(false);
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "MAMA";
                MamaPlatspeech.text = "Oh my baby, you came just in time!";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
        }
		else if (primeInt == 308){
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "MAMA";
                MamaPlatspeech.text = "And you, Mr. Bear! Thank you so much! I would have been snake food without you. ";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
        }
		else if (primeInt == 309){
			    ArtMama2.SetActive(false);
				ArtBear1.SetActive(true);
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "BEAR";
                Bearspeech.text = "Don’t worry about haha! I may be old but I still have some fight in me.";
        }
		else if (primeInt == 310){
			    ArtBear1.SetActive(false);
				ArtPlat1.SetActive(true);
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "Oh mom, I’m so happy I found you!";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
        }
		else if (primeInt == 311){
         SceneChange2();
        }
		
		else if (primeInt == 400){
				ArtBam.SetActive(true);
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "TAKE THAT!";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
		}
		
		else if (primeInt == 401){
			    ArtPlat1.SetActive(false);
				ArtBam.SetActive(false);
				ArtSnake1.SetActive(true);
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "SNAKE";
                Snakespeech.text = "HAHAHA!";
				Bearname.text = "";
                Bearspeech.text = "";
		}
		else if (primeInt == 402){
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "SNAKE";
                Snakespeech.text = "You really think that would hurt me? Ha!";
				Bearname.text = "";
                Bearspeech.text = "";
		}
		else if (primeInt == 403){
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "SNAKE";
                Snakespeech.text = "Bye Bye little Platypus...";
				Bearname.text = "";
                Bearspeech.text = "";
		}
		else if (primeInt == 404){
			    ArtPlat1.SetActive(true);
				ArtSnake1.SetActive(false);
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "Oh no...";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
		}
		else if (primeInt == 405){
			SceneChange1();   
		}
		else if (primeInt == 500){
				ArtBam.SetActive(true);
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "TAKE THAT!";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
		}
		else if (primeInt == 501){
			    ArtPlat1.SetActive(false);
				ArtBam.SetActive(false);
				ArtSnake1.SetActive(true);
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "SNAKE";
                Snakespeech.text = "AGH!";
				Bearname.text = "";
                Bearspeech.text = "";
		}
		else if (primeInt == 502){
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "SNAKE";
                Snakespeech.text = "What's with that power!";
				Bearname.text = "";
                Bearspeech.text = "";
		}
		else if (primeInt == 503){
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "SNAKE";
                Snakespeech.text = "You win this time...";
				Bearname.text = "";
                Bearspeech.text = "";
		}
		else if (primeInt == 504){
			    ArtPlat1.SetActive(true);
				ArtSnake1.SetActive(false);
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "YES!";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
		}
		else if (primeInt == 505){
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "Thank goodness I ate those berries!";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
		}
		else if (primeInt == 506){
			    ArtPlat1.SetActive(false);
				ArtMama2.SetActive(true);
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "MAMA";
                MamaPlatspeech.text = "Oh goodness, my baby! You saved me!";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
		}
		else if (primeInt == 507){
			    ArtPlat1.SetActive(true);
				ArtMama2.SetActive(false);
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "Mama! I've been looking for you everywhere!";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
		}
		else if (primeInt == 508){
			 SceneChange1();   
		}
		else if (primeInt == 600){
				ArtBam.SetActive(true);
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "TAKE THAT!";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
		}
		else if (primeInt == 601){
			    ArtPlat1.SetActive(false);
				ArtBam.SetActive(false);
				ArtSnake1.SetActive(true);
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "SNAKE";
                Snakespeech.text = "AGH!";
				Bearname.text = "";
                Bearspeech.text = "";
		}
		else if (primeInt == 602){
				ArtPlat1.SetActive(true);
				ArtSnake1.SetActive(false);
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "YES!";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
		}
		else if (primeInt == 603){
			    ArtPlat1.SetActive(false);
				ArtSnake1.SetActive(true);
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "SNAKE";
                Snakespeech.text = "Not so fast... You haven't won just yet!";
				Bearname.text = "";
                Bearspeech.text = "";
		}
		else if (primeInt == 604){
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "SNAKE";
                Snakespeech.text = "If I'm going down, you're coming with me!";
				Bearname.text = "";
                Bearspeech.text = "";
		}
		else if (primeInt == 605){
				ArtPlat1.SetActive(true);
				ArtSnake1.SetActive(false);
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "Oh no...";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
		}
		else if (primeInt == 606){
				ArtMama2.SetActive(true);
				ArtPlat1.SetActive(false);
                BabyPlatname.text = "";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "MAMA";
                MamaPlatspeech.text = "NO! My Baby!";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
		}
		else if (primeInt == 607){
				SceneChange2();
		}
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "I can't just stand here I have to do something...";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                 BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "There's nothing I can do...";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1cFunct(){
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "";
				BabyPlatthoughts.text = "I know! I should call for that old bear!";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
                primeInt = 299;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1dFunct(){
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "ATTACK!";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
                primeInt = 399;
                Choice1d.SetActive(false);
                Choice1e.SetActive(false);
				Choice1f.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1eFunct(){
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "SUPER BERRY ATTACK!!!";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
                primeInt = 499;
                Choice1d.SetActive(false);
                Choice1e.SetActive(false);
				Choice1f.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1fFunct(){
                BabyPlatname.text = "BABY PLATYPUS";
                BabyPlatspeech.text = "TAIL ATTACK!!";
				BabyPlatthoughts.text = "";
				MamaPlatname.text = "";
                MamaPlatspeech.text = "";
				Snakename.text = "";
                Snakespeech.text = "";
				Bearname.text = "";
                Bearspeech.text = "";
                primeInt = 599;
                Choice1d.SetActive(false);
                Choice1e.SetActive(false);
				Choice1f.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene_Lose1");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene_Win1");
        }
}
