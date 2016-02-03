
using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;
    private Vector2 _currentPosition;

    //PUBLIC INSTANCE VARIABLES
    public float speed = 5f;


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
        this._currentPosition -= new Vector2(this.speed, 0);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= -230)
        {
            this.reset();
        }
    }

    public void reset()
    {
        float yPos = Random.Range(127f,-208f);
        this._transform.position = new Vector2(730f, yPos);
    }

}
