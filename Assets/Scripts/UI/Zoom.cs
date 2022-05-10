using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public RectTransform tr;
    private const int LOCALVAL = 1;
    private const float SCALE = 0.5f;

    // Start is called before the first frame update
    private void Start()
    {
        //init new value with local scale of x=1, y=1
        tr.localScale = new Vector2(LOCALVAL, LOCALVAL);
    }
  
    
    public void ScrollChanged(float value)
    {
        //init new value with local scale of x=1, y=1
        tr.localScale = new Vector2(LOCALVAL, LOCALVAL);
        //add localscale to value
        value += LOCALVAL;
        //times, local scale, value, and SCALE 
        tr.localScale = tr.localScale * value * SCALE;
    }
    
}
