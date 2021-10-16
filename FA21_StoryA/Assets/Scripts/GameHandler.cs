
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour{

        public static bool beenToOwl = false;
		public static bool beenToBear = false;
		public static bool beenToFox = false;
		public static bool beenToRabbit = false;
		public static bool gotBearHelp = false;
	    public static bool ateBerries = false;
		public static bool newDiscovery = false;
		
		
        //public GameObject textGameObject;

        //void Start () { UpdateScore (); }

        void Update(){         //delete this quit functionality when a Pause Menu is added
                if (Input.GetKey("escape")){
                        Application.Quit();
                }
        }

//assign true to static variables
		public  void UpdateOwl(){
                beenToOwl = true;
				Debug.Log("beenToOwl = " + beenToOwl);
        }
		
		public void UpdateBear(){
                beenToBear = true;
				Debug.Log("beenToBear = " + beenToBear);
        }
		
		public void UpdateFox(){
                beenToFox = true;
				Debug.Log("beenToFox = " + beenToFox);
        }
		public void UpdateBerries(){
                ateBerries = true;
				Debug.Log("ateBerries = " + ateBerries);
        }
		
		public void UpdateRabbit(){
                beenToRabbit = true;
				Debug.Log("beenToRabbit = " + beenToRabbit);
        }

		public void UpdateBearHelp(){
                gotBearHelp = true;
				Debug.Log("BearHelp = " + gotBearHelp);
        }
		
		public void UpdateNewDiscovery(){
                newDiscovery = true;
				Debug.Log("NewDiscovery = " + newDiscovery);
        }
		

//return static variables 
		public bool isOwl(){
            return beenToOwl;
        }
		
		public bool isBear(){
            return beenToBear;
        }
		
		public bool isFox(){
			return beenToFox;
        }
		
		public bool isRabbit(){
			return beenToRabbit;
        }
		
		public bool isBearHelp(){
			return gotBearHelp;
        }
		
		public bool isBerries(){
			return ateBerries;
        }
		
		public bool isNewDiscovery(){
			return newDiscovery;
        }


        //void UpdateScore () {
        //        Text scoreTemp = textGameObject.GetComponent<Text>();
        //        scoreTemp.text = "Score: " + score; }

        public void StartGame(){
                SceneManager.LoadScene("Scene1");
        }
		
		public void Credits(){
                SceneManager.LoadScene("Credits");
        }
		
		
        public void RestartGame(){
                SceneManager.LoadScene("MainMenu");
        }

        public void QuitGame(){
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
        }
}
