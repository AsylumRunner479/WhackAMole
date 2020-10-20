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
    private void Awake()
    {
        InputCamera = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR || UNITY_STANDALONE
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = InputCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject == self)
                {
                    Health.health += 1;
                    Health.score += 1;
                    Destroy(self);
                }

            }
        }
#else
        if (Input.touchCount > 0)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                Touch touch = Input.GetTouch(i);

                if (touch.phase == TouchPhase.Began)
                {
                    Ray ray = InputCamera.ScreenPointToRay(touch.position);

                    if (Physics.Raycast(ray, out RaycastHit hit))
                    {
                        if (hit.collider.gameObject == self)
                        {
                            Health.health += 1;
                            Health.score += 1;
                            Destroy(self);
                        }

                    }
                }
            }
            
        }

#endif
        //self.transform.position += Vector3.down * Time.deltaTime * movespeed;
        if (self.transform.position.y <= -32)
        {
            Destroy(self);
        }
    }
    
}
