using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineDrawer_Mesh : MonoBehaviour
{
    public Material lineMaterial; 
    public float lineWidth = 0.1f; 

    private LineRenderer lineRenderer;
    private MeshCollider meshCollider;
    private Mesh lineMesh;

    private Vector3 touchPosition;

    void Start()
    {
       
        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.material = lineMaterial;
        lineRenderer.startWidth = lineWidth;
        lineRenderer.endWidth = lineWidth;

        
        meshCollider = gameObject.GetComponent<MeshCollider>();
        if (meshCollider == null)
            meshCollider = gameObject.AddComponent<MeshCollider>();

        
        lineMesh = new Mesh();
        lineMesh.name = "LineMesh";
        lineRenderer.BakeMesh(lineMesh, true);

        
        meshCollider.sharedMesh = lineMesh;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10f));

                if (lineRenderer.positionCount == 0)
                {
                   
                    lineRenderer.positionCount = 1;
                    lineRenderer.SetPosition(0, touchPosition);
                }
                else
                {
                    
                    lineRenderer.positionCount++;
                    lineRenderer.SetPosition(lineRenderer.positionCount - 1, touchPosition);
                }

               
                lineRenderer.BakeMesh(lineMesh, true);
                meshCollider.sharedMesh = lineMesh;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
               
                lineRenderer.positionCount = 0;
                meshCollider.sharedMesh = null;
            }
        }
    }
}
