using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlzombi : NewBehaviourScript
{
    Vector2 Enemypos;
    public GameObject player;
    bool perseguir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (perseguir) {
            transform.position = Vector2.MoveTowards(transform.position,Enemypos, speed * Time.deltaTime);
        }
        if (Vector2.Distance(transform.position,Enemypos)> 12f) {
            perseguir = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player1")) {
            Enemypos = player.transform.position;
            perseguir = true;
        }
    }
}
