using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float scrollSpeed;

    [SerializeField]
    private Renderer backgroundRenderer;

    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, 0);
    }
}
