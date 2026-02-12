using Unity.Hierarchy;
using UnityEngine;
using UnityEngine.UIElements;

public class Randomize : MonoBehaviour
{
    int moveStyle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.Rotate(0f, Random.Range(0f, 360f), 0f, Space.Self);
        transform.localScale *= Random.Range(0.5f, 1f);

        moveStyle = Random.Range(0, 4); // 0-3
        // 1/5 chance to choose fast rotation
        if (Random.Range(0, 5) == 0)
            moveStyle = Random.Range(4, 6); // 4-5
    }

    int timer;
    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
        timer++;
        switch (moveStyle)
        {
            default:
                break;
            case 1:
                transform.Rotate(0f, 1f, 0f);
                break;
            case 2:
                transform.Rotate(0f, -1f, 0f);
                break;
            case 3:
                float scale = .5f + (Mathf.Sin(timer / 30f) / 3f);
                transform.localScale = new Vector3(scale, scale, scale);
                break;
            case 4:
                transform.Rotate(0f, -10f, 0f);
                break;
            case 5:
                transform.Rotate(0f, 10f, 0f);
                break;
        }
    }
}