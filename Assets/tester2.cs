using UnityEngine;
using System.Collections;
using System;

public class tester2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        StartCoroutine("Tester2");
    }

    public IEnumerator Tester2()
    {
        AnotherFunction();
        yield break;
    }

    public void AnotherFunction()
    {
        Action a = null;

        for (int i = 0; i < 3; i++)
        {
            string temp = i.ToString();
            a += () => { Debug.Log(Time.time + " temp=" + temp + " " + temp.GetHashCode()); };
            Debug.Log("for loop " + temp);
            a();//Debug Purpose
            Debug.Log("---end for loop " + temp);
        }
        Debug.Log("----------");
        a();
    }
}
