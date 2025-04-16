using UnityEngine;

public class Bump : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D other) {
        Driver driver = other.GetComponent<Driver>();
        if (other.tag == "Player") {
            driver.setMovementSpeed(driver.getMovementSpeed() * 0.5f);
        }
    }
}
