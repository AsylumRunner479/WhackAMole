using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    [SerializeField]
    private Camera InputCamera;
    public GameObject self;
    private MeshRenderer meshRenderer = default;
    public float movespeed;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = gameObject.GetComponent<MeshRenderer>();
        InputCamera = Camera.main;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = InputCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject == self)
                {
                    Health.health += 1;
                    Destroy(self);
                }

            }
        }
        self.transform.position += Vector3.down * Time.deltaTime * movespeed;
        if (self.transform.position.y <= -32)
        {
            Destroy(self);
        }
    }
    
}
