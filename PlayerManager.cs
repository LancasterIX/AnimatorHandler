using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace JS
{


    public class PlayerManager : MonoBehaviour
    {
        InputHandler inputHandler;
        Animator anim;
         void Start()
        {
            inputHandler = GetComponent<InputHandler>();
            anim = GetComponent<Animator>();
        }

   
    void Update()
    {
            inputHandler.IsInteracting = anim.GetBool("IsInteracting");
    }
}
}