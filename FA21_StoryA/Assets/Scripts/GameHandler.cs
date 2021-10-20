
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class GameHandler : MonoBehaviour{

        public static bool beenToOwl = false;
		public static bool beenToBear = false;
		public static bool beenToFox = false;
		public static bool beenToRabbit = false;
		public static bool gotBearHelp = false;
	    public static bool ateBerries = false;
		public static bool newDiscovery = false;
		 public static bool GameisPaused = false;
        public GameObject pauseMenuUI;
        public AudioMixer mixer;
        public static float volumeLevel = 1.0f;
        private Slider sliderVolumeCtrl;
		
		//pause menu stuff
		void Awake (){
                SetLevel (volumeLevel);
                GameObject sliderTemp = GameObject.FindWithTag("PauseMenuSlider");
                if (sliderTemp != null){
                        sliderVolumeCtrl = sliderTemp.GetComponent<Slider>();
                        sliderVolumeCtrl.value = volumeLevel;
                }
        }
		
		     void Start (){
                pauseMenuUI.SetActive(false);
        }

        void Update (){
                if (Input.GetKeyDown(KeyCode.Escape)){
                        if (GameisPaused){
                                Resume();
                        }
                        else{
                                Pause();
                        }
                }
        }

        void Pause(){
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0f;
                GameisPaused = true;
        }

        public void Resume(){
                pauseMenuUI.SetActive(false);
                Time.timeScale = 1f;
                GameisPaused = false;
        }

        public void SetLevel (float sliderValue){
                mixer.SetFloat("MusicVolume", Mathf.Log10 (sliderValue) * 20);
                volumeLevel = sliderValue;
        }
		
        //public GameObject textGameObject;

        //void Start () { UpdateScore (); }

        
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
			   ResetGame();
                SceneManager.LoadScene("Pre_Scene");
        }
		
		public void Credits(){
                SceneManager.LoadScene("Credits");
        }
		
		
        public void RestartGame(){
			 Time.timeScale = 1f;
                SceneManager.LoadScene("MainMenu");
        }
		
		 public void ResetGame(){
             beenToOwl = false; 
			 beenToBear = false;
			 beenToFox = false; 
			 beenToRabbit = false; 
			 gotBearHelp = false; 			 
			 ateBerries = false;
			 newDiscovery = false;
			 
			   
        }

        public void QuitGame(){
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
        }
}
