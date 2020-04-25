using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/***
 * All information about a single dialogue
 * Serilizable because we want to interact with it in editor
 * ***/
 [System.Serializable]
public class Dialogue
{
    //name of npc we are interracting with
    public string name;

    [TextArea(3, 10)]
    public string[] sentences;


}
