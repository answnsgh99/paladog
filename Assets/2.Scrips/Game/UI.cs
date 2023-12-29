using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public static UI instance;

    private void Awake() => instance = this;

    [SerializeField] private TMP_Text bscoreTxt;
    [SerializeField] private TMP_Text rscoreTxt;

    private int bscore;
    private int rscore;


    public int Bscore
    {
        get { return bscore; }
        set
        {
            bscore = value;
            bscoreTxt.text = bscore.ToString("00");
        }
    }

    public int Rscore
    {
        get { return rscore; }
        set
        {
            rscore = value;
            rscoreTxt.text = rscore.ToString("00");
        }
    }

    

    private void Start()
    {
        rscore = 20;
        bscore = 20;
    }

}
