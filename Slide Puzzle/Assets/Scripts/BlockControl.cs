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
    private Vector3 startDist;

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
        print("Anything");
        distance = Vector3.Distance(transform.position, Camera.main.transform.position); // returns the distance between this scripts position and the cameras position.
        dragging = true;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // It's a line from the camera to the input mouse position. In this case holding down mouse button.
        Vector3 rayPoint = ray.GetPoint(distance); // Returns a Vector 3 point at the distance float along the ray. ?? How do I make it be a Vector 2?
        startDist = (Vector3)transform.position - rayPoint; // It's a Vector2 transform.position - the ray point, which is the distance along the ray.
    }

    void OnMouseUp()
    {
        dragging = false;
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetMouseButtonDown(0))
        ////Debug.Log ("clicked");
        //{
        //    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        //    RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
        //    if (hit.collider != null)
        //    {
        //        //Debug.Log("Clicked");
        //        Debug.Log(hit.collider.gameObject.name);
        //        // hit.collider. some negative SFX says you can't move it.;
        //    }
        //}
        //else { dragging = false; } // I think this may be stopping the dragging = true from working right.

        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint + startDist;
            print(transform.position);
            print("The if dragging code has happend");
        }
    }

    //private void OnMouseDown()
    //{
    //    print("Mouse held down."); // Hold mouse down on the blocks.
    //}

    // How do I check which block is being clicked on. Needs to print the name of the block each time it is printed on.

}
