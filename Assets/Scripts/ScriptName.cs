using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptName : MonoBehaviour
{



    private void Start()
    {
        print("Ahmed Mohamed ");
        Debug.Log("This is alooign message");


        StartCoroutine(executeSomething());

        //StartCoroutine("ExecuteSomething");
        //StopCoroutine("ExecuteSomething");


    }

    private void Update()
    {
        
    }



    IEnumerator executeSomething()
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
