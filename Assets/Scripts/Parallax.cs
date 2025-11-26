using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Transform player;      // Assign player transform in the inspector
    public float parallaxSpeed = 0.5f;

    private float startPosition;

    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();

        if (player == null)
            player = GameObject.Find("Player").transform; // fallback

        startPosition = player.position.x;
    }

    void Update()
    {
        float offsetX = (player.position.x - startPosition) * parallaxSpeed;
        rend.material.mainTextureOffset = new Vector2(offsetX, 0f);
    }
}