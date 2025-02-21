using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movementSpeed = 1;

    private Rigidbody2D myRigidbody2D;
    private float horizontalMovement;
    private float verticalMovement;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        movement();
        float fixedHorizontalMovement = horizontalMovement * movementSpeed * Time.deltaTime;
        float fixedVerticalMovement = verticalMovement * movementSpeed * Time.deltaTime;

        myRigidbody2D.AddForce(new Vector2(fixedHorizontalMovement, fixedVerticalMovement));
    }

    private void movement(){

        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");
    }

}
