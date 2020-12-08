using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;

    private void Update()
    {
        Vector2 movement = new Vector2(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical")
            );
        transform.Translate(movement * movementSpeed * Time.deltaTime);
    }
}
