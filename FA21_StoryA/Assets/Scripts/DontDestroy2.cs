using System.Collections;
using UnityEngine;

public class DontDestroy2 : MonoBehaviour
{
    void Awake ()
    {
        
    GameObject[] objs = GameObject.FindGameObjectsWithTag("caveMusic");
	if(objs.Length > 1)
Destroy(this.gameObject);

DontDestroyOnLoad(this.gameObject);        
    }
}