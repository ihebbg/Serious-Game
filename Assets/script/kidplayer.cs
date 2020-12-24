using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kidplayer : MonoBehaviour {
    public int runspeed = 2;
    public int rotationspeed=95;
    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            anim.Play(Animator.StringToHash("Jump"));
        }
        else
        {
            var walkingZ = Input.GetAxis("Vertical") * Time.deltaTime * runspeed;
            var rotationY = Input.GetAxis("Horizontal") * Time.deltaTime * rotationspeed;
            if (walkingZ != 0)
            {
                transform.Translate(0, 0, walkingZ);
                anim.Play(Animator.StringToHash("run"));

            }
            if (rotationY != 0)
            {
                transform.Rotate(0, rotationY, 0);

            }
        }


       


       
	}
    }



