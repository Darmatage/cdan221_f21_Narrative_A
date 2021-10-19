using System.Collections;
using UnityEngine;

public class DontDestroy4 : MonoBehaviour
{
    void Awake ()
    {
        
    GameObject[] objs = GameObject.FindGameObjectsWithTag("waterfallMusic");
	if(objs.Length > 1)
Destroy(this.gameObject);

DontDestroyOnLoad(this.gameObject);        
    }
}