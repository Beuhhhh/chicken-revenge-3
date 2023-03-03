using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class shopkeeper : MonoBehaviour

{

    public GameObject dialoguePanel;
    public GameObject shopPanel;
    public Text dialogueText;
    public string[] dialogue;
    private int index = 0;
    public float wordSpeed;
    public bool playerIsClose;




    void Start()
    {
        dialogueText.text = "";
        dialoguePanel.SetActive(false);

    }



    // Update is called once per frame

    void Update()

    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            if (!dialoguePanel.activeInHierarchy)
            {

                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }

            else if (dialogueText.text == dialogue[index])
            {
                NextLine();

            }
        }

    }
    public void RemoveText()
    {
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }
    public void NextLine()
    {
        if (index < dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            RemoveText();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            playerIsClose = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            playerIsClose = false;
            RemoveText();
        }
    }
}

//ask user if theyd like to see the shop	
//if yes, open shop
//if no, close shop
//     public void OpenShop()
//     {
//         shopPanel.SetActive(true);
//     }
//     public void CloseShop()
//     {
//         shopPanel.SetActive(false);
//     }



// }
