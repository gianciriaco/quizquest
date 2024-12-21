using UnityEngine;
using UnityEngine.UI;

public class ChangeColorOnTouch : MonoBehaviour
{
    private Image image;

    void Start()
    {
        image = GetComponent<Image>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered by: " + other.name); // Log the name of the object that touched the image
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player touched the image!"); // Log when the player touches
            image.color = Color.red;  // Change the image color to red
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            image.color = Color.white;  // Reset the image color to white when the player leaves
        }
    }
}
