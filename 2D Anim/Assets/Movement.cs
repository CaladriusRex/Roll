using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    Animator anim;
    void Awake()
    {
        anim = GetComponent<Animator>();
        
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            anim.SetBool("Walking Left", true);

        if (Input.GetKeyUp(KeyCode.LeftArrow))
            anim.SetBool("Walking Left", false);

        if (Input.GetKeyDown(KeyCode.RightArrow))
            anim.SetBool("Walking Right", true);

        if (Input.GetKeyUp(KeyCode.RightArrow))
            anim.SetBool("Walking Right", false);
    }
}
