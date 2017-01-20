using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlapperController : MonoBehaviour
{
    public KeyCode keyToControl;

	void Update () {
        //When a key is pressed, turn on the motor
        if (Input.GetKey(keyToControl))
        {
            GetComponent<HingeJoint2D>().useMotor = true;
        }
        else
        {
            GetComponent<HingeJoint2D>().useMotor = false;
        }
	}
}
