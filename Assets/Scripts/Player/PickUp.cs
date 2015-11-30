
using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {
	
	public float speed;
	
	private Rigidbody rb;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Key"))
		{
			other.gameObject.SetActive (false);
		}
	}
}