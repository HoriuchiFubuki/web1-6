using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour {

    public GameObject arrowPrefab;
    float span = 0.7f;
    float delte = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.delte += Time.deltaTime;
        if(this.delte > this.span)
        {
            this.delte = 0;
            GameObject goArrow = Instantiate(arrowPrefab) as GameObject;
            int random = Random.Range(-9, 9);
            goArrow.transform.position = new Vector3(random, 7, 0);
        }
		
	}
}
