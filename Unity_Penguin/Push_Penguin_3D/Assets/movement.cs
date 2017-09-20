using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public float x = 0, y = 0, z = 0, rotateLeft=90, rotateRight=-90, rotateCounter=0;

	// Use this for initialization
	void Start () {
        this.gameObject.name = "Penguin";
        this.transform.localScale = new Vector3(1, 1, 1);
        this.transform.position = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.W))
        {
            if (rotateCounter == 0)
            {
                x = 0;
                y = 0;
                z = -.5f;
            }

            else if (rotateCounter == 1)
            {
                x = -.5f;
                y = 0;
                z = 0;
            }

            else if(rotateCounter==2)
            {
                x = 0;
                y = 0;
                z = .5f;
            }

            else
            {
                x = .5f;
                y = 0;
                z = 0;
            }

            this.transform.position += new Vector3(x, y, z);
        }

        if (rotateCounter == 4)
        {
            rotateCounter = 0;
        }

        if (rotateCounter == -1)
        {
            rotateCounter = 3;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.Rotate(Vector3.up,rotateLeft, Space.World);
            rotateCounter++;
           
        }

	}
}
