using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript3 : MonoBehaviour
{
    private SpriteRenderer sr;
    public Color color1;
    public Color color2;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        StartCoroutine(ChangeColor4());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ChangeColor4(){
        while(true){
            if(sr.color == color1){
                sr.color = color2;
            }else{
                sr.color = color1;
            }
            yield return new WaitForSeconds(.01f);
        }
    }
}
