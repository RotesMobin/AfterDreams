using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Ground : MonoBehaviour
{
    [Header("Chose your lvl you want")]
    [SerializeField]
    private int lvlInspector = 1;


    [Header("Made a random on this list")]
    [SerializeField]
    private List<GameObject> m_listLVL1;
    [SerializeField]
    private List<GameObject> m_listLVL2;

    // Use this for initialization
    void Awake()
    {
        randlvl(lvlInspector);
    }

    // Update is called once per frame
    void Update()
    {

    }
    

    public void randlvl(int lvl)
    {
        int ind;
        GameObject objFinal;
        switch (lvl)
        {
            case 1 :
                ind = Random.Range(0, m_listLVL1.Count);
                objFinal = m_listLVL1[ind].gameObject;
                break;
            case 2 :
                ind = Random.Range(0, m_listLVL2.Count);
                objFinal = m_listLVL2[ind].gameObject;
                break;
            default:
                ind = Random.Range(0, m_listLVL1.Count);
                objFinal = m_listLVL1[ind].gameObject;
                break;
        }

        GameObject instance = Instantiate(objFinal, this.transform.parent.transform);
        instance.transform.position = this.gameObject.transform.position;
        Destroy(this.gameObject);
    }


}

   