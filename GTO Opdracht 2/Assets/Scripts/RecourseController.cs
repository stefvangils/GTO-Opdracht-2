using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecourseController : MonoBehaviour {

    public Text Wood;
    public Text Metal;
    public Text Gold;
    public Text Soldier;

    private int woodCount;
    private int metalCount;
    private int goldCount;
    private int soldierCount;
    

    // Use this for initialization
    void Start () {
        SetAllCountZero();
        SetCountText(Wood, woodCount);
        SetCountText(Metal, metalCount);
        SetCountText(Gold, goldCount);
        SetCountText(Soldier, soldierCount);
    }
	
	// Update is called once per frame
	void Update () {
		
	}



    void SetCountText(Text text, int count)
    {
        text.text = text.name+": " + count.ToString();       
    }

    void SetAllCountZero()
    {
        woodCount = 0;
        metalCount = 0;
        goldCount = 0;
        soldierCount = 0;
    }

    public void AddWood()
    {
        woodCount = woodCount + 1;
        SetCountText(Wood, woodCount);
    }
    public void DelWood()
    {
        if(woodCount > 0)
        {
            woodCount = woodCount - 1;
            SetCountText(Wood, woodCount);
        }
        
    }
    public void AddMetal()
    {
        metalCount = metalCount + 1;
        SetCountText(Metal, metalCount);
    }
    public void DelMetal()
    {
        if (metalCount > 0)
        {
            woodCount = woodCount - 1;
            SetCountText(Metal, metalCount);
        }

    }

    public void BuyGold()
    {
        if(woodCount > 9 && metalCount > 9)
            {
            woodCount = woodCount - 10;
            metalCount = metalCount - 10;
            goldCount = goldCount + 1;
            SetCountText(Wood, woodCount);
            SetCountText(Metal, metalCount);
            SetCountText(Gold, goldCount);
        }
    }

    public void BuySoldier()
    {
        if (goldCount > 2)
        {           
            goldCount = goldCount - 3;
            soldierCount = soldierCount + 1;
            SetCountText(Gold, goldCount);
            SetCountText(Soldier, soldierCount);
        }
    }
}
