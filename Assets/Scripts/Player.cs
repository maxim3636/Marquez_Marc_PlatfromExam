using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    [Header("Animation")] 
    [SerializeField] private KeyCode Alpha1;
    [SerializeField] private KeyCode Alpha2;
    [SerializeField] private KeyCode Alpha3;
    [SerializeField] private Animator anim;
    
    [Header("Teleport")] 
    [SerializeField] private float dist_x;
    [SerializeField] private float dist_y;

    private float steerDirection = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Alpha1))
        {
            anim.SetTrigger("attack");
        }
        if (Input.GetKeyDown(Alpha2))
        {
            anim.SetTrigger("hurt");
        }
        if (Input.GetKeyDown(Alpha3))
        {
            anim.SetTrigger("die");
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            steerDirection = -1;
        }else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            steerDirection = 1;
        }
        transform.localScale = new Vector3(steerDirection, 1, 1);
        
        Gizmos.color = Color.red;
        Vector3 direction = new Vector3(transform.position.x + dist_x * steerDirection, transform.position.y + dist_y);
        Gizmos.DrawRay(transform.position, direction);
    }

    public void teleport()
    {
        transform.position = new Vector3(transform.position.x + dist_x * steerDirection, transform.position.y + dist_y);
    }
}
