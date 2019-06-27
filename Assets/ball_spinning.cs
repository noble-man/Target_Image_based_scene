using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_spinning : MonoBehaviour
{
 
    public int _positionNbr; //user can define number of positions
    public Vector3[] _positions;

    private void Awake()
    {
        _positions = new Vector3[_positionNbr];

        for (int i = 0; i < _positions.Length; i++)
        {
            _positions[i] = new Vector3(0, Random.Range(0f, 360f), 0);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localPosition = Vector3.right * Time.time;
        //transform.localRotation = new Quaternion(0, Time.time, 0, 0); //* Time.time;
        transform.Rotate(0,2,0,Space.Self);
    }
}
