using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopkeeper : MonoBehaviour
{
    public GameObject dialoguePanel;
    public Text dialogueText;
    public string dialogue;
    private int index;
    public bool playerIsClose;
    // Start is called before the first frame update
    void Start()
    {
        dialoguePanel.SetActive(false);


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            playerIsClose = true;
        }
    }

    private void Update()
    {
        if (playerIsClose)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (dialoguePanel.activeInHierarchy)
                {
                    index++;
                    if (index >= dialogue.Length)
                    {
                        dialoguePanel.SetActive(false);
                    }
                    else
                    {
                        dialogueText.text = dialogue.Substring(0, index);
                    }
                }
                else
                {
                    dialoguePanel.SetActive(true);
                    index = 1;
                    dialogueText.text = dialogue.Substring(0, index);
                }
            }
        }
    }
}
