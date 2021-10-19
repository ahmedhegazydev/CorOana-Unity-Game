using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptName : MonoBehaviour
{



    private void Start()
    {
        print("Ahmed Mohamed ");
        Debug.Log("This is alooign message");


        StartCoroutine(executeSomething(timeMillis: 3));

        //StartCoroutine("ExecuteSomething");
        //StopCoroutine("ExecuteSomething");


    }

    private void Update()
    {
        
    }



    IEnumerator executeSomething(float timeMillis)
    {
        yield return new WaitForSeconds(2);
        Debug.Log("WaitForSeconds(2);");

        yield return new WaitForSeconds(2);
        Debug.Log("WaitForSeconds(2);");

        yield return new WaitForSeconds(2);
        Debug.Log("WaitForSeconds(2);");

        yield return new WaitForSeconds(2);
        Debug.Log("WaitForSeconds(2);");


    }




}
