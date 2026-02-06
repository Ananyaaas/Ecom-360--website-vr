using UnityEngine;

public class KeyboardMove : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float z = Input.GetAxis("Vertical");   // W/S or Up/Down

        Vector3 move = new Vector3(x, 0, z) * speed * Time.deltaTime;
        transform.Translate(move, Space.World);
    }
}
