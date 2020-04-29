using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{

    private LineRenderer lr;

    public DevMath.Vector2 direction;

    public float magnitude = 1;

    private void Update()
    {
        UpdateLine();

        if (Input.GetKey(KeyCode.Space))
        {
            direction.Magnitude = magnitude;
        }
    }

    [ExecuteAlways]
    public void UpdateLine()
    {
        if (lr == null)
        {
            lr = GetComponent<LineRenderer>();
        }
        lr.SetPosition(1, new Vector2(direction.x, direction.y));
    }
}
