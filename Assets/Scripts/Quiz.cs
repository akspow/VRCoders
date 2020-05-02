using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quiz : MonoBehaviour
{
    public AudioSource audioGood, audioBad;
    public Text commandText, txt, txt2, tx3, tx4, txt5,txt6;
    public int a = 0;
    int scores = 0;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Selected()
    {
        if (gameObject.name == "a")
        {

            //Destroy(gameObject);
            //commandText.text = "Congrats.You have found the right answer";
           
            if(a==1)
            {
                audioGood.Play();
                scores++;
            }
            else
            {
                audioBad.Play();
            }
            a++;

        }
        else if (gameObject.name == "b" )
        {
            audioBad.Play();
            //SceneManager.LoadScene(0, LoadSceneMode.Single);
            a++;
        }
        else if(gameObject.name == "c")
        {
            audioBad.Play();
            a++;
        }
        else 
        {
            if (a == 0 || a==2)
            {
                audioGood.Play();
                scores++;
            }
            else
            {
                audioBad.Play();
            }
            a++;
        }
        if (a == 1)
        {
            q1();
        }
        else if (a == 2)
        {
            q2();
        }
        else if(a==3)
        {
            showresults();
        }
    }
    public void q1()
    {
        txt.text = "O(n2)";
        txt2.text = "O(nlogn)";
        tx3.text = "O(n)";
        tx4.text = "O(logn)";
        txt5.text = "What is the worst case complexity of selection sort?";
    }
    public void q2()
    {
        txt.text = "DO";
        txt2.text = "FOR";
        tx3.text = "SWITCH";
        tx4.text = "ALL THE ABOVE";
        txt5.text = "The break statement is used to exit from: ";
    }
    public void showresults()
    {
        string myString = scores.ToString();
        txt6.text = "Congrats, you scored " + myString + "points out of three";
    }

    public void Returnhome()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
    public void triggerquiz()
    {
        SceneManager.LoadScene(4, LoadSceneMode.Single);
    }
    public void triggervoice()
    {
        SceneManager.LoadScene(5, LoadSceneMode.Single);
    }

}
