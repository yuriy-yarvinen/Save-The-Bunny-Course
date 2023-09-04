using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;

    float xInput;

    public float moveSpeed;

    public float xPositionLimit;

    Vector2 newPosition;


    private void Awake() 
    {
        rb = GetComponent<Rigidbody2D>();    
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() 
    {
        MovePlayer();    
    }

    void MovePlayer()
    {
        newPosition = transform.position;
        if(Input.GetMouseButton (0)){
            Vector3 mousePos = Input.mousePosition;
            if(mousePos.x < Screen.width / 2){
                newPosition.x -= moveSpeed;
            }
            if(mousePos.x > Screen.width / 2){
                newPosition.x += moveSpeed;
            }
        }

        newPosition.x = Mathf.Clamp(newPosition.x, -xPositionLimit, xPositionLimit);

        // Same
        
        // if(newPosition.x >= xPositionLimit){
        //     newPosition.x = xPositionLimit;
        // }
        // if(newPosition.x <= -xPositionLimit){
        //     newPosition.x = -xPositionLimit;
        // }
        
        rb.MovePosition(newPosition);
    }
}
