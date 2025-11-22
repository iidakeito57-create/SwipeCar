using UnityEngine;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            this.startPos = Mouse.current.position.value;

        }
        else if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            Vector2 currentPos = Mouse.current.position.value;
            float deltaX = currentPos.x - this.startPos.x;
            this.speed += deltaX * 0.0002f;
            this.startPos = currentPos;

            GetComponent<AudioSource>().Play();
        }
        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
    }
}
