using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

	public Animator daveAnim;
	public Animator dave2Anim;

    // Start is called before the first frame update

	
    void Start()
    {
        daveAnim = GetComponent<Animator>();
	dave2Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {	
        if(Input.GetKey("q")){
		daveAnim.Play("nod");
	}
	if(Input.GetKey("w")){
		daveAnim.Play("shake");	
	}
	if(Input.GetKey("e")){
		daveAnim.Play("shrug");	
	}
    }

  

}
