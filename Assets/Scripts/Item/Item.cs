using UnityEngine;

/***
 * Blueprint for all interactable object data
 * ***/
 [CreateAssetMenu(fileName= "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    //Override old def
    new public string name = "New Item";
    public Sprite icon = null;
    public bool isDefaultItem = false;

    //For different item : different use. 
    public virtual void Use()
    {
        //Use item
        //Do something

        Debug.Log("Using" + name);
    }
}
