using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSummmon : MonoBehaviour
{

    public GameObject bossBattleSplash;

    // Start is called before the first frame update
    public void bossCutscene()
    {
        bossBattleSplash.SetActive(true);
    }

}
