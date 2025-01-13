using UnityEngine;

public class RetrovisorControl : MonoBehaviour
{
    [SerializeField] GameObject retrovisor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            retrovisor.SetActive(true);
        }
        else
        
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            retrovisor.SetActive(false);
        }
    }
}
