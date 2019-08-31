using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockControl : MonoBehaviour

    // THIS NEEDS TO BE ATTACHED TO THE BLOCKS. Maybe not?
{

    private GameObject selectedBlock; // should = highlighted or a different colour or something.
    private GameObject deselectedBlock;
    private bool dragging = false;
    private float distance;
    private Vector2 startDist;

    void OnMouseEnter()
    {
        // Highlights the block?
    }

    void OnMouseExit()
    {
        // ?
    }

    void OnMouseDown()
    {
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        dragging = true;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector2 rayPoint = ray.GetPoint(distance);
        startDist = transform.position - rayPoint;
    }

    void OnMouseUp()
    {
        dragging = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint + startDist;
        }

        if (Input.GetMouseButtonDown(0))
            //Debug.Log ("clicked");
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                //Debug.Log("Clicked");
                Debug.Log(hit.collider.gameObject.name);
                // hit.collider. some negative SFX says you can't move it.;
            }
        }
    }

    //private void OnMouseDown()
    //{
    //    print("Mouse held down."); // Hold mouse down on the blocks.
    //}

    // How do I check which block is being clicked on. Needs to print the name of the block each time it is printed on.

}
