using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//assign the dummy assest in the unity test scene

public class BugMovement : MonoBehaviour
{
    public GameObject bugPrefab;
    public GameObject targetPoint;
    public LayerMask obstacleLayer;

    private bool isDrawing;
    private LineRenderer currentLine;
    private List<Vector2> linePoints;
    private List<GameObject> bugs;

    private void Start()
    {
        linePoints = new List<Vector2>();
        bugs = new List<GameObject>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartDrawing();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            EndDrawing();
        }
        else if (isDrawing)
        {
            UpdateLine();
        }
    }

    private void StartDrawing()
    {
        isDrawing = true;
        GameObject lineObject = new GameObject("Line");
        currentLine = lineObject.AddComponent<LineRenderer>();
        currentLine.positionCount = 0;
        currentLine.startWidth = 0.1f;
        currentLine.endWidth = 0.1f;
        currentLine.useWorldSpace = true;
        currentLine.material = new Material(Shader.Find("Sprites/Default"));
        linePoints.Clear();
    }

    private void EndDrawing()
    {
        isDrawing = false;
        currentLine = null;
        linePoints.Clear();
    }

    private void UpdateLine()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (linePoints.Count > 0 && Vector2.Distance(mousePosition, linePoints[linePoints.Count - 1]) < 0.1f)
        {
            // Skip adding points if the mouse hasn't moved much
            return;
        }

        linePoints.Add(mousePosition);
        currentLine.positionCount = linePoints.Count;
        currentLine.SetPosition(linePoints.Count - 1, mousePosition);

        CheckBugIntersections();
    }

    private void CheckBugIntersections()
    {
        for (int i = 0; i < bugs.Count; i++)
        {
            GameObject bug = bugs[i];
            if (IsBugInsideLine(bug))
            {
                // Trap or redirect the bug
                Vector2 targetPosition = targetPoint.transform.position;
                bug.GetComponent<Rigidbody2D>().MovePosition(targetPosition);
                bugs.RemoveAt(i);
                i--;
            }
        }
    }

    private bool IsBugInsideLine(GameObject bug)
    {
        Bounds bugBounds = bug.GetComponent<Collider2D>().bounds;
        foreach (Vector2 point in linePoints)
        {
            if (!bugBounds.Contains(point))
            {
                return false;
            }
        }

        return true;
    }

    public void SpawnBug(Vector2 position)
    {
        GameObject bug = Instantiate(bugPrefab, position, Quaternion.identity);
        bugs.Add(bug);
    }


}

// collider for bug 

void addcollider;

Bugs.AddComponent<BoxCollider>();

