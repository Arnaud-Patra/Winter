using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/***
 * FROM https://www.youtube.com/watch?v=S2mK6KFdv0I
 * ***/
public class PlayerControler : MonoBehaviour
{
    Camera cam;
    public LayerMask groundMask;

    public Interactable focus;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;    
    }

    // Update is called once per frame
    void Update()
    {
        //Cas ray with right click
        if (Input.GetMouseButtonDown(0))
        {

            //Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            //RaycastHit hit;

            //Debug.Log("We clcked here : " + ray);

            //if (Physics.Raycast(ray, out hit, 100f))
            //{
            //    //If hit something
            //    if(hit.transform != null)
            //    {
            //        Debug.Log(hit.transform.gameObject);
            //    }
            //    Debug.Log("We hit " + hit.collider.name + " " + hit.point);

            //    //Defocus object
            //    RemoveFocus();

            //    //Should add hit here ? 
            //}
        }


        //Cas ray with right click
        if (Input.GetMouseButtonDown(1))
        {

            //From camera to mouse
            //Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            //RaycastHit hit;
            //Debug.Log("We clcked here : " + ray);

            //if (Physics.Raycast(ray, out hit, 100f))
            //{
            //    Interactable interactable = hit.collider.GetComponent<Interactable>();
            //    if(interactable != null)
            //    {
            //        Debug.Log("We hit " + hit.collider.name + " " + hit.point);
            //        SetFocus(interactable);
            //    }

            //}
        }
    }

    void SetFocus(Interactable newFocus)
    {
        focus = newFocus;
    }

    void RemoveFocus()
    {
        focus = null;
    }

}
