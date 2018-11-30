using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset;
    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called once all the values are processed, and we're ready to render
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
