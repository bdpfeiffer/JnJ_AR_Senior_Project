using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class TurnAround : MonoBehaviour
{

	public Camera Camera;
    [Tooltip("Spin: Yes or No")]
	public bool spin;
	public float speed = 10f;

	[HideInInspector]
	public bool clockwise = true;
	[HideInInspector]
	public float direction = 1f;
	[HideInInspector]
	public float directionChangeSpeed = 2f;
    // Start is called before the first frame update

	void Start() {
		Behaviour halo = (Behaviour)GetComponent("Halo");
		halo.enabled=false;
	}


    // Update is called once per frame
   	void Update() {

		
	updateTransForm();
		
	Spin();
        
	}

	void Spin() {
		if (direction < 1f) {
			direction += Time.deltaTime / (directionChangeSpeed / 2);
		}

		if (spin) {
					transform.Rotate(Vector3.up, (speed * direction) * Time.deltaTime);
                   
			
		}

	}

	void updateTransForm() {
		// float speed = Time.deltaTime * 7.0f;
		// Vector3 z = new Vector3(0,0,1);
		// Vector3 pos = Camera.transform.position + Camera.transform.forward + z;
		// transform.position = Vector3.SlerpUnclamped(transform.position,pos,speed);
		// Quaternion rot = Quaternion.LookRotation(transform.position - Camera.transform.position);
		//transform.rotation = Quaternion.Slerp(transform.rotation,rot,speed);
	}

}
