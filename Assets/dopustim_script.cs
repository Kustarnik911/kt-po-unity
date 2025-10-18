using UnityEngine;

public class dopustim_script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("прыжок");
        }
        else
        {
            print("ќжидание...");
        }


        if (Input.GetKey(KeyCode.F))
        {
            for (int i = 5; i == 0; i--)
            {
                print("старт");
            }

        }

        else { }
    }    
}

