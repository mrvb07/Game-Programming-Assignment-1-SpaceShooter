using UnityEngine;
using System.Collections;

public class CloudController : MonoBehaviour {

    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;
    private Vector2 _currentPosition;
    private float _speed;

    //PUBLIC INSTANCE VARIABLES
    public float minSpeed = 3f;
    public float maxSpeed = 6f;

    // Use this for initialization
    void Start()
    {
        this._transform = gameObject.GetComponent<Transform>();
        //Reset the Cloud position
        this.reset();
    }

    // Update is called once per frame
    void Update()
    {

        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this._speed, 0);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= -1055)
        {
            this.reset();
        }
    }

    public void reset()
    {
        this._speed = Random.Range(this.minSpeed, this.maxSpeed);
        this._transform.position = new Vector2(1830f, 200);
    }
}
