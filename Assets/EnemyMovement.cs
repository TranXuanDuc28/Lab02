using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;        // tốc độ di chuyển
    public float moveDistance = 3f; // khoảng cách di chuyển

    private Vector3 startPos;
    private int direction = 1;

    void Start()
    {
        startPos = transform.position; // lưu vị trí ban đầu
    }

    void Update()
    {
        // Di chuyển theo hướng hiện tại
        transform.Translate(Vector2.right * direction * speed * Time.deltaTime);

        // Nếu đi quá khoảng cách cho phép thì đổi hướng
        if (Mathf.Abs(transform.position.x - startPos.x) >= moveDistance)
        {
            direction *= -1; // đổi chiều
        }
    }
}
