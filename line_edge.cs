using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_1 : MonoBehaviour

{
    public float lineDrawWidth = 0.2f;

    private LineRenderer lineRenderer;
    private EdgeCollider2D edgeCollider;
    private List<Vector2> fingerPositions;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        edgeCollider = GetComponent<EdgeCollider2D>();
        fingerPositions = new List<Vector2>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    fingerPositions.Clear();
                    fingerPositions.Add(touchPos);
                    break;

                case TouchPhase.Moved:
                    fingerPositions.Add(touchPos);
                    DrawLine();
                    break;

                case TouchPhase.Ended:
                    fingerPositions.Add(touchPos);
                    DrawLine();
                    edgeCollider.points = fingerPositions.ToArray();
                    break;
            }
        }
    }

    void DrawLine()
    {
        lineRenderer.positionCount = fingerPositions.Count;
        for (int i = 0; i < fingerPositions.Count; i++)
        {
            lineRenderer.SetPosition(i, fingerPositions[i]);
        }
    }
}
