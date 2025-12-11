using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> tubes;
    [SerializeField] public Color[] colors;
    [SerializeField] private XRHandDraw draw;

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<GameObject> GetTubes() {
        return tubes;
    }

    public void CycleColor()
    {
        index++;
        if (index == colors.Length) { index = 0; }
        foreach (GameObject t in tubes) { 
            t.GetComponent<Renderer>().material.color = colors[index];
        }
    }

    public void EnableDraw()
    {
        draw.enabled = !draw.enabled;
    }
}
