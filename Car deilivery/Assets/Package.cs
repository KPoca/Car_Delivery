using UnityEngine;

public class Package : MonoBehaviour
{
    bool isPickedUp = false;
    [SerializeField] Color32 hasPackageColor = new Color32(0, 255, 0, 255);
    [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ouch!");
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Package") {
            if (!isPickedUp) {  // If the care held no package at the time of pickup
                isPickedUp = true;
                Destroy(other.gameObject);
                Debug.Log("You picked up a package!");
                spriteRenderer.color = hasPackageColor;
            } else {    // If the car already held a package at the time of pickup
                Debug.Log("You already have a package!");
            }
        } else if (other.tag == "Customer") {
            if (isPickedUp) {  // If the car held a package at the time of delivery
                isPickedUp = false;
                Destroy(other.gameObject);
                Debug.Log("Package delivered!");
                spriteRenderer.color = noPackageColor;
            } else {  // If the car held no package at the time of delivery
                Debug.Log("You need to pick up a package first!");
            }
        }
    }
}
