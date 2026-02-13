using UnityEngine;

public class GazeColorOnly : MonoBehaviour
{
    private Renderer objectRenderer;
    private Color originalColor;

    public Color gazeColor = Color.red;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalColor = objectRenderer.material.color;
    }

    void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit) && hit.transform == transform)
        {
            objectRenderer.material.color = gazeColor;
        }
        else
        {
            objectRenderer.material.color = originalColor;
        }
    }
}
