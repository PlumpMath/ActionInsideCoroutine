using UnityEngine;
using System.Collections;
using System;

public class tester : MonoBehaviour 
{

	// Use this for initialization
    void Start()
    {
        StartCoroutine("Tester");
    }

    public IEnumerator Tester()
    {
        Action a = null;
        for (int i = 0; i < 3; i++)
        {
            int temp = i;
            Action aa = () => { Debug.Log(Time.time + " temp=" + temp + " " + temp.GetHashCode() + "\n"); };

            a += aa;
            yield return new WaitForSeconds(1);
            Debug.Log("for loop " + temp);
            a();//Debug Purpose
            Debug.Log("---end for loop " + temp);
        }
        Debug.Log("----------");
        a();
        yield break;
    }

}
