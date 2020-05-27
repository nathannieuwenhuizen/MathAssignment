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


    [SerializeField]
    private Vector2 translationVector;
    [SerializeField]
    private Vector3 scaleVector;
    [SerializeField]
    private Vector3 rotationVector;

    private Texture2D pixel;

    void Start()
    {
        pixel = new Texture2D(1, 1, TextureFormat.ARGB32, false);
        pixel.SetPixel(0, 0, Color.magenta);
        pixel.Apply();
    }

    void Update()
    {

        Debug.Log("angle between vectors: " + DevMath.Vector2.Angle(lLine.direction, rLine.direction));
        //Debug.Log("angle of vector1: ( " + DevMath.Vector2.DirectionFromAngle(angleVector1).x + ", " + DevMath.Vector2.DirectionFromAngle(angleVector1).y + " )");
        //resultLine.direction = DevMath.Vector2.Lerp(lLine.direction, rLine.direction, lerpValue);
    }

    private void OnGUI()
    {
        Matrix4x4 translation = Matrix4x4.Translate(translationVector);
        Matrix4x4 scaling = Matrix4x4.Scale(scaleVector);
        Matrix4x4 rotation = Matrix4x4.Rotate(Quaternion.Euler(rotationVector));

        Matrix4x4 pivot = Matrix4x4.Translate(new Vector2(-50, -50));

        GUI.matrix = pivot.inverse * translation * scaling * rotation * pivot;

        GUI.DrawTexture(new Rect(0, 0, 100, 100), pixel);

        
    }
}
