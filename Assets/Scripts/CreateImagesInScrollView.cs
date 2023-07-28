using UnityEngine;
using UnityEngine.UI;

public class CreateImagesInScrollView : MonoBehaviour
{
    public Sprite[] imageSprites;    // Add your image sprites to this array in the Inspector
    public GameObject content;       // Reference to the Content GameObject in the ScrollView

    void Start()
    {
        // Check if the Content GameObject is assigned
        if (content == null)
        {
            Debug.LogError("Content GameObject reference is not assigned!");
            return;
        }

        // Loop through the array of image sprites and create UI Image elements for each sprite
        float spacing = 20f; // Spacing between images (you can adjust this value)
        float yPosition = 0f; // Initial Y position of the first image
        foreach (Sprite imageSprite in imageSprites)
        {
            // Create a new UI Image GameObject
            GameObject newImageObject = new GameObject("Image");
            newImageObject.transform.SetParent(content.transform, false);

            // Add an Image component to the new UI Image GameObject
            Image newImageComponent = newImageObject.AddComponent<Image>();

            // Set the sprite of the Image component to the current image sprite
            newImageComponent.sprite = imageSprite;

            // Set the position of the image
            RectTransform rectTransform = newImageObject.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = new Vector2(0f, yPosition);

            // Optionally, set the size of the image (modify as per your requirements)
            rectTransform.sizeDelta = new Vector2(150f, 150f);

            // Update the Y position for the next image
            yPosition -= rectTransform.rect.height + spacing;
        }
    }
}
