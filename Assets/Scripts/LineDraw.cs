using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDraw : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private List<Vector3> linePositions;
<<<<<<< Updated upstream
    EdgeCollider2D edge;
=======
    // EdgeCollider2D edgeCollider = new EdgeCollider2D();
    public Camera cameraMain;
    EdgeCollider2D edge;
    Vector3 touchPosition;
    List<Vector3> colliderPoints = new List<Vector3>();
>>>>>>> Stashed changes


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
                //Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                touchPosition.z = 0f;
                linePositions.Add(touchPosition);
                lineRenderer.positionCount = linePositions.Count;
                lineRenderer.SetPositions(linePositions.ToArray());
                colliderPoints.Add(touchPosition);
                addCollider();

                Debug.Log("Code is working");

                addCollider();
            }
        }
    }

    void addCollider()
    {
<<<<<<< Updated upstream
        List<Vector2> colliderPoints = new List<Vector2>();
        for (int i = 0; i < colliderPoints.Count; i++)
        {

            colliderPoints.Add(new Vector3(colliderPoints[i].x, colliderPoints[i].y, 0f));
=======
        List<Vector2> colliderPoints2 = new List<Vector2>();
        for (int i = 0; i < colliderPoints.Count; i++)
        {

            colliderPoints2.Add(new Vector3(colliderPoints[i].x, colliderPoints[i].y, 0f));
>>>>>>> Stashed changes

        }

        for (int i = colliderPoints.Count - 1; i > 0; i--)
        {
<<<<<<< Updated upstream
            colliderPoints.Add(new Vector3(colliderPoints[i].x, colliderPoints[i].y, 0f));
        }

        edge = lineRenderer.gameObject.AddComponent<EdgeCollider2D>();
        edge.points = colliderPoints.ToArray();
=======
            colliderPoints2.Add(new Vector3(colliderPoints[i].x, colliderPoints[i].y, 0f));
        }

        edge = lineRenderer.gameObject.AddComponent<EdgeCollider2D>();
        edge.points = colliderPoints2.ToArray();
>>>>>>> Stashed changes


    }


}

