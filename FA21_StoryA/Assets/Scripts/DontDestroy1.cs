using System.Collections;
using UnityEngine;

public class DontDestroy1 : MonoBehaviour
{
    void Awake ()
    {
        
    GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
	if(objs.Length > 1)
Destroy(this.gameObject);

DontDestroyOnLoad(this.gameObject);        
    }
}
