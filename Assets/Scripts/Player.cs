using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public float s = .3f;
	private Transform _t;
	
	void Awake (){
	_t = transform;
	}
	

	// Use this for initialization
	void Start () {
	_t.position = new Vector3 (0,-4,0);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis ("Horizontal") != 0)
		{
		_t.position = new Vector3(_t.position.x + Input.GetAxis ("Horizontal")* s,-4,0);
		
			if (_t.position.x < -5f) 
			_t.position = new Vector3(-5f ,-4,0);
			else if (_t.position.x > 5f) 
			_t.position = new Vector3(5f ,-4,0);
		}
	
	}
}
