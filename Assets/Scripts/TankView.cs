﻿using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTankController(TankController _tankController)
    {
        this.tankController = _tankController;
    }
}