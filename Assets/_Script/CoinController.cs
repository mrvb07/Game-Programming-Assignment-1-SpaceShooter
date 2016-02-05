using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {
    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;
    private Vector2 _currentPosition;

    public float speed = 5f;
	// Use this for initialization
	void Start () {
        this._transform = gameObject.GetComponent<Transform>();
        this.reset();
    }
	
	// Update is called once per frame
	void Update () {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this.speed, 0);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= -190)
        {
            this.reset();
        }
    }

    public void reset()
    {
        float xpos = Random.Range(750f, 1600f);
        float yPos = Random.Range(127f, -208f);
        this._transform.position = new Vector2(xpos, yPos);
    }
}
