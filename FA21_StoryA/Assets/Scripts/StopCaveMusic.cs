using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopCaveMusic : MonoBehaviour
{
    void Awake()

    {

        GameObject A = GameObject.FindGameObjectWithTag("caveMusic");

        Destroy(A);
		
		 GameObject B = GameObject.FindGameObjectWithTag("attackMusic");

        Destroy(B);
		
		GameObject C = GameObject.FindGameObjectWithTag("waterfallMusic");

        Destroy(C);

    }
}
