using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    [SerializeField]
    public Text interactText;

    public Transform interactionTransform;

    private bool interactAllowed;

    // Use this for ini
    private void Start()
    {
        interactText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (interactAllowed && Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
            
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Default set to own transform
        if (interactionTransform == null)
            interactionTransform = transform;

        if (collision.gameObject.name.Equals("Player"))
        {
            interactText.gameObject.SetActive(true);
            interactAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            interactText.gameObject.SetActive(false);
            interactAllowed = false;
        }
    }

    // This method is meant to be overwritten
    public virtual void Interact()
    {

    }

}
