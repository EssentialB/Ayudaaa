using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target; //para colocar dentro al GameObject del Player
    public Vector3 offset; //para que se vea la cámara y que siga al paersonaje

    [Range(1,10)]
    public float smootherFactor;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = target.position + offset; //camara sigue a player
        var targetPosition = target.position + offset;
        var smootherPosition = Vector3.Lerp(transform.position, targetPosition, smootherFactor * Time.fixedDeltaTime);
        transform.position = smootherPosition;
        
    }
}
