using System.Collections;
using UnityEngine;

public class DontDestroy3 : MonoBehaviour
{
    void Awake ()
    {
        
    GameObject[] objs = GameObject.FindGameObjectsWithTag("attackMusic");
	if(objs.Length > 1)
Destroy(this.gameObject);

DontDestroyOnLoad(this.gameObject);        
    }
}