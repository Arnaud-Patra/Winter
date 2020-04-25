using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

/***
 * Control the general state of the game
 * ***/
public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;
    // public BoardManager boardScript;

    [SerializeField]
    private HealthBar healthBar;  // SerializeField : à quoi ça sert? 

    // Start is called before the first frame update
    private void Start()
    {
        float health = 1f;
        //From CodeMonkey.Utils 
        // 0.03f : timer
        FunctionPeriodic.Create(()=>
        {
            if(health > 0.005f)
            {   
                //Reduce health
                health -= 0.005f;
                healthBar.SetSize(health);

                if(health < .3f)
                {
                    //Under 30 %  => alternate between white and red

                    int health_int = Mathf.FloorToInt(health * 100f);
                    if(health_int % 3 == 0)
                        healthBar.SetColor(Color.white);
                    else
                        healthBar.SetColor(Color.red);
                }

            }

        }, .01f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
