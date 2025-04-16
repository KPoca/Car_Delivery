using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] GameObject followTarget;
    // Update is called once per frame
    void Update()
    {
        transform.position = followTarget.transform.position + new Vector3(0, 0, -10);
    }
}
