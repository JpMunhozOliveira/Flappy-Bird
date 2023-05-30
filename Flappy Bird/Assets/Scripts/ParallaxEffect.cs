using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    [SerializeField]
    private float parallaxSpeed = 1;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        rend.material.mainTextureOffset += new Vector2(parallaxSpeed * Time.deltaTime, 0);
    }
}