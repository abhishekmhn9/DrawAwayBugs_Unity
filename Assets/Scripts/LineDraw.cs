using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDraw : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private List<Vector3> linePositions;
    // EdgeCollider2D edgeCollider = new EdgeCollider2D();


    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        linePositions = new List<Vector3>();
        
    }

    void Update()
    {
      
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                linePositions.Clear();
                lineRenderer.positionCount = 0;
            }
            else if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                touchPosition.z = 0f;

                linePositions.Add(touchPosition);
                lineRenderer.positionCount = linePositions.Count;
                lineRenderer.SetPositions(linePositions.ToArray());
            
                Debug.Log("Code is working");
            }
        }
    }



}

