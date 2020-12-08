using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private void Update()
    {
        Vector2 movement = new Vector2(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical")
            );
        transform.Translate(movement * 5f * Time.deltaTime);
    }
}
