using UnityEngine;
using System.Collections;

public class EnemyPlaneController : MonoBehaviour {

    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;
    private Vector2 _currentPosition;
    private float _speed;

    //PUBLIC INSTANCE VARIABLES
    public float minSpeed = 7.5f;
    public float maxSpeed = 12.5f;


    // Use this for initialization
    void Start()
    {
        this._transform = gameObject.GetComponent<Transform>();
        //Reset the Enemy
        this.reset();
    }

    // Update is called once per frame
    void Update()
    {

        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this._speed, 0);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= -1200)
        {
            this.reset();
        }
    }

    public void reset()
    {
        this._speed = Random.Range(this.minSpeed, this.maxSpeed);
        float yPos = Random.Range(200f, 128f);
        this._transform.position = new Vector2(2100f, yPos);
    }
}
