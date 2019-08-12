using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockControl : MonoBehaviour

    // THIS NEEDS TO BE ATTACHED TO THE BLOCKS. Maybe not?
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
