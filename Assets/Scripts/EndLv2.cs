using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndLv2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        select.LvOpen[1] = true;
        select.ResetSave();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionExit(Collision other)
    {
        StartCoroutine(Countdown());

    }
    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Lv3");
    }
}
