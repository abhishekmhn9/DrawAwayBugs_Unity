using System.Collections;
using UnityEngine;

public class DrawLineTEST : MonoBehaviour
{
    Coroutine drawing;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Startline();
        }
       
        if (Input.GetMouseButtonUp(0))
        {
            Endline();

        }
    }

    void Startline()
    {
        if (drawing != null)
        {
            StopCoroutine(drawing);
        }
        drawing = StartCoroutine(DrawLine());
    }

    void Endline()
    {
        StopCoroutine(drawing);
    }

    IEnumerator DrawLine()
    {
        GameObject newGameObject = Instantiate(Resources.Load("Line") as GameObject, new Vector3(), Quaternion.identity);
        LineRenderer line = newGameObject.GetComponent<LineRenderer>();
        line.positionCount = 0;

        while (true) 
        {
            Vector3 position = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            position.z = 0f;
            line.positionCount++;
            line.SetPosition(line.positionCount -1, position);
            yield return null;
        }
    }   

}
