using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {

    GameObject Player;
	// Use this for initialization
	void Start () {
        this.Player = GameObject.Find("player");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, -0.1f, 0);

        if (transform.position.y < -5.0)
        {
            Destroy(gameObject);
        }

        Vector2 position1 = transform.position;
        Vector2 position2 = this.Player.transform.position;
        Vector2 dir = position1 - position2;
        float direct = dir.magnitude;
        float radius1 = 0.5f;
        float radius2 = 1.0f;

        if(direct < radius1 + radius2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHP();

            Destroy(gameObject);
        }

    }
}
