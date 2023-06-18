using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDraw : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private Vector2 touchPosition;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        //lineRenderer.transform.position = new Vector3[] { new Vector3(0, 0, 0) };
    }

    void Update()
    {
        /*if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            touchPosition = Input.GetTouch(0).position;
        }
        else if (Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            lineRenderer.transform.position.Add(touchPosition);
        }*/
    }



}
