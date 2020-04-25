using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{

    public string levelToLoad;

    public Vector3 spawn;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = spawn;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
