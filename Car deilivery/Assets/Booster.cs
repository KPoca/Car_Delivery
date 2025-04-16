using UnityEngine;

public class Booster : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D other) {
        Driver driver = other.GetComponent<Driver>();
        if (other.tag == "Player") {
            driver.setMovementSpeed(driver.getMovementSpeed() * 1.5f);
        }
    }
}
