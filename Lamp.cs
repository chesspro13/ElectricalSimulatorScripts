using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    public bool isTouchingNeutral;
    public bool isTouchingPhase;
    public Collider[] hitColliders;

    public GameObject lineSide;
    public GameObject loadSide;

    bool isOn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if( lineSide.GetComponent<Potential>() != null && loadSide.GetComponent<Neutral>() != null) 
        //if( isTouchingNeutral && isTouchingPhase )
        {
            if( !this.isOn )
            {
				this.gameObject.GetComponent<Renderer>().material.SetColor("_Color",new Color(255/255.0f, 255/255.0f, 0));      
                this.isOn = true;
            }
        }else{
            if( this.isOn )
            {
				this.gameObject.GetComponent<Renderer>().material.SetColor("_Color",Color.white);      
                this.isOn = false;
            }
        }
    }
    private void FixedUpdate()
	{
        /*
		hitColliders = Physics.OverlapSphere(transform.position,0.6f);
        this.isTouchingPhase = false;
        this.isTouchingNeutral = false;

        foreach( Collider c in hitColliders)
        {
            Potential p = c.gameObject.GetComponent<Potential>();
            Neutral n = c.gameObject.GetComponent<Neutral>();

            if( p != null )
            {
                this.isTouchingPhase = true;
                Debug.Log("Lamp on because of:\t\t\t" + p.gameObject);
            }

            if( n != null )
                this.isTouchingNeutral = true;
        }*/
	}

}
