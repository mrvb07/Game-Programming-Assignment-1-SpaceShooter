using UnityEngine;
using System.Collections;

public class SkyController : MonoBehaviour {
    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;

	// Use this for initialization
	void Start () {
        this._transform = gameObject.GetComponent<Transform>();
        this._transform.position = new Vector2(850f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
