/*
 * PlayerMovement.cs
 * 
 */

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D player;
    [SerializeField]
    private Collider2D collider;

    public float movementRate = 5.0f;
    public float jumpHeight = 4.0f;

    // Local variables used by the whole script
    private float horizontalMove;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");

    }


    private void FixedUpdate()
    {

        if (horizontalMove != 0f)
        {
            float hor = horizontalMove * movementRate * (Time.deltaTime * 100.0f);
            player.velocity = new Vector2(hor, player.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space) && DetectGround())
        {
            float ver = jumpHeight * (Time.deltaTime * 100.0f);
            player.velocity = new Vector2(player.velocity.x, ver);
        }
    }
    

    private bool DetectGround()
    {
        Vector3 BLCorner = new Vector3();
        Vector3 BRCorner = new Vector3();
        {
            float x1 = collider.bounds.center.x + collider.bounds.extents.x;
            float x2 = collider.bounds.center.x - collider.bounds.extents.x;
            float y = collider.bounds.center.y - collider.bounds.extents.y - 0.1f;

            BLCorner.x = x1;
            BLCorner.y = y;

            BRCorner.x = x2;
            BRCorner.y = y;
        }

        RaycastHit2D hitLeft = Physics2D.Raycast(BLCorner, Vector2.down, 0.1f);
        RaycastHit2D hitRight = Physics2D.Raycast(BRCorner, Vector2.down, 0.1f);

        if (hitLeft.collider != null || hitRight.collider != null)
        {
            if (hitLeft.collider.tag == "Ground" || hitRight.collider.tag == "Ground")
                return true;
        }

        return false;
    }
}
