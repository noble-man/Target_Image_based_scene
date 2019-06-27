using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_bouncing : MonoBehaviour
{
    //private Vector3[] verticalPositions;
    // Start is called before the first frame update

   // public Vector3[] _positions;

    //public int _positionNbr;

    //public float _swapPerSecond;

    void Start()
    {
        gameObject.name = "nba_bball";

      //  _positions = new Vector3[_positionNbr];

        /*for (int i = 0; i < _positions.Length; i++)
        {
            _positions[i] = new Vector3(0, Random.Range(0f, 10f), 0);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.SetPositionAndRotation(new Vector3(0,Time.time % 4 ,0),new Quaternion());
       // gameObject.transform.rotation.Set(0, gameObject.transform.rotation.y + 5, 0,0);
        //gameObject.transform.SetPositionAndRotation();
        //gameObject.transform.SetPositionAndRotation(gameObject.transform.position,new Quaternion(0, gameObject.transform.rotation.y + 5, 0,0));
       // transform.position = _positions[Mathf.FloorToInt(Time.time * _swapPerSecond) % _positions.Length];
    }
}
