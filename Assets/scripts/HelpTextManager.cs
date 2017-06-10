using UnityEngine;
using System.Collections;

public class HelpTextManager : MonoBehaviour
{
    public GameObject HelpText;

    // Use this for initialization
    void Start () {
        StartCoroutine(ExecuteAfterTime(2));
	}

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        HelpText.SetActive(false);
    }
}
