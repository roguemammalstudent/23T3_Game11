using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dialogue : MonoBehaviour
{
    [SerializeField] GameObject dialogue0; // Your text objects
    [SerializeField] GameObject dialogue1;
    [SerializeField] GameObject dialogue2;
    [SerializeField] GameObject dialogue3;
    [SerializeField] GameObject dialogue4;
    [SerializeField] GameObject dialogue5;
    [SerializeField] GameObject dialogue6;
    [SerializeField] GameObject dialogue7;
    [SerializeField] GameObject dialogue8;
    // You would copy/paste these, with how many pieces of dialogue, just changing the number at the end

    public int dialogue; // this will keep track of what dialogue we are on
    public int startDialogue = 0; // this is to make sure that when you start your scene, you are on the right dialogue

    void Start ()
    {
        dialogue = startDialogue;
    }

    void Update()
    {
        if (dialogue == 0)
        {
            dialogue0.SetActive(true);
        }
        else
        {
            dialogue0.SetActive(false);
        }

        if (dialogue == 1)
        {
            dialogue1.SetActive(true);
        }
        else
        {
            dialogue1.SetActive(false);
        }

        if (dialogue == 2)
        {
            dialogue2.SetActive(true);
        }
        else
        {
            dialogue2.SetActive(false);
        }

        if (dialogue == 3)
        {
            dialogue3.SetActive(true);
        }
        else
        {
            dialogue3.SetActive(false);
        }

        if (dialogue == 4)
        {
            dialogue4.SetActive(true);
        }
        else
        {
            dialogue4.SetActive(false);
        }

        if (dialogue == 5)
        {
            dialogue5.SetActive(true);
        }
        else
        {
            dialogue5.SetActive(false);
        }

        if (dialogue == 6)
        {
            dialogue6.SetActive(true);
        }
        else
        {
            dialogue6.SetActive(false);
        }

        if (dialogue == 7)
        {
            dialogue7.SetActive(true);
        }
        else
        {
            dialogue7.SetActive(false);
        }

        if (dialogue == 8)
        {
            dialogue8.SetActive(true);
        }
        else
        {
            dialogue8.SetActive(false);
        }

        if (dialogue == 9)
        {
            SceneManager.LoadScene("Level01");
        }
    }

    public void ChangwDialogue() // connect this to your button to skip dialogue
    {
        dialogue++; // This will add one to the dialogue count, thus changing what dialogue will be displayed
    }
}
