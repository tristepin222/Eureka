using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public RectTransform tr;
    public float LocalValue = 1f;
    private const float SCALE = 0.5f;
    private const float MIN = 0.034f;
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    private void Start()
    {
        //init new value with local scale of x=1, y=1
        tr.localScale = new Vector2(MIN,MIN);
    }
  
    /// <summary>
    /// changes the localscale of the transform, higher localscale, will zoom in, and lower localscale it will zoom out
    /// </summary>
    /// <param name="value"></param>
    public void ScrollChanged(float value)
    {
        //init new value with local scale of x=1, y=1
        tr.localScale = new Vector2(LocalValue, LocalValue);
        //add localscale to value
        value += LocalValue;
        //times, local scale, value, and SCALE 
        tr.localScale = tr.localScale * value * SCALE;
    }
    
}
