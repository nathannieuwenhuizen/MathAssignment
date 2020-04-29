using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    [SerializeField]
    private Line lLine;
    [SerializeField]
    private Line rLine;
    [SerializeField]
    private Line resultLine;

    [Range(0,1)]
    [SerializeField]
    private float lerpValue = 0;

    [Range(0, 360)]
    [SerializeField]
    private float angleVector1 = 0;

    void Start()
    {
        
    }

    void Update()
    {

        Debug.Log("angle between vectors: " + DevMath.Vector2.Angle(lLine.direction, rLine.direction));
        //Debug.Log("angle of vector1: ( " + DevMath.Vector2.DirectionFromAngle(angleVector1).x + ", " + DevMath.Vector2.DirectionFromAngle(angleVector1).y + " )");


        //resultLine.direction = DevMath.Vector2.Lerp(lLine.direction, rLine.direction, lerpValue);
    }
}
