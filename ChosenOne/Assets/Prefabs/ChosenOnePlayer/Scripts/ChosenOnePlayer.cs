using UnityEngine;
using System.Collections;

public class ChosenOnePlayer : MonoBehaviour {

    public Vector2 objectSpeed = new Vector2(20, 20);
    public float objectDrag = 25.0f;
    private Vector2 movement;
    public float x = 750.0f;
    public float y = 375.0f;
    public bool pressM = false;
    public bool pressP = false;
    // Use this for initialization
	void Start () {
	
	}

    void Update()
    {
        getInput();

        performAction();
    }

    /*
     * Do all physics based updates here
     */
    void FixedUpdate()
    {
        // Move the game object
        rigidbody2D.drag = objectDrag;
        rigidbody2D.velocity = movement;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
       
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.tag == "Tile" && (pressM || pressP))
        {
            BoxCollider2D boxCollider = collider.gameObject.GetComponent<BoxCollider2D>();
            BaseTileScript tile = (BaseTileScript)boxCollider.gameObject.GetComponent<BaseTileScript>();
            tile.addAttack(10);
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        
    }

    private void getInput()
    {
        pressP = Input.GetKeyUp(KeyCode.P);
        pressM = Input.GetKeyUp(KeyCode.M);

        // Retrieve axis information
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        // Movement per direction
        movement = new Vector2(objectSpeed.x * inputX, objectSpeed.y * inputY);
    }

    private void performAction()
    {
        if (pressP)
        {
            Debug.Log("physical Attack!");
        }
        if (pressM)
        {
            Debug.Log("magic Attack!");
        }
    }

    void OnGUI()
    {
     
    }
}
