using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour
{
    public float timer = 0.0f;
    Renderer Objrenderer;
    Color[] colors = new Color[2]; // [2] is how many colors you want
    void Start()
    {
        //array of colors
        colors[0] = Color.green;
        colors[1] = Color.red;
      
    }


    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2.0f)
        {
            // pick a color, red or green
            Color newColor = colors[Random.Range(0, colors.Length)];
            // apply it to the ground
            Objrenderer = GetComponent<Renderer>();
            Objrenderer.material.color = newColor;
            timer = 0;
        }


    }
}
