using UnityEngine;
using System.Collections;

public class OrbBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter(Collider other)
	{
		//Reference our game controller script and access the public
		//CollectedOrb() function
		GameController._instance.CollectedOrb();
		Destroy(this.gameObject);

	}
}
