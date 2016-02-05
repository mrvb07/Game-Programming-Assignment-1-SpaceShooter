using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    //PRIVATE INSTANCE VARIABLES
    private float _input;
    private Transform _transform;
    private Vector2 _currentPosition;

    //PRIVATE INSTANCE VARIABLES
    public float speed = 5f;

	// Use this for initialization
	void Start () {
        this._transform = gameObject.GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {

        this._currentPosition = this._transform.position;
        this._input = Input.GetAxis("Vertical");
        

        //MOVING PLAYER UP AND DOWN
        this.playerMovement();

        //CHECKING UPPER AND LOWER BOUND LIMITS
        this.checkBounds();
        this.transform.position = this._currentPosition;
    }


    public void checkBounds()
    {
        if (this._currentPosition.y >= 225)
        {
            this._currentPosition.y = 225;
        }

        if (this._currentPosition.y <= -208.5)
        {
            this._currentPosition.y = -208.5f;
        }
    }

    public void playerMovement()
    {
        if (this._input < 0)
        {
            this._currentPosition -= new Vector2(0, this.speed);
        }

        if (this._input > 0)
        {
            this._currentPosition += new Vector2(0, this.speed);
        }
    }
}
