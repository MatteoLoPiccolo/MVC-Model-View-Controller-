using UnityEngine;

public class TankModel 
{
    private TankController tankController;
    public float movementSpeed;
    public float rotationSpeed;
    public TankTypes tankTypes;
    public Material color;


    public TankModel(float _movementSpeed, float _rotationSpeed, TankTypes _tankTypes, Material _color)
    {
        this.movementSpeed = _movementSpeed;
        this.rotationSpeed = _rotationSpeed;
        this.tankTypes = _tankTypes;
        this.color = _color;
    }

    public void SetTankController(TankController _tankController)
    {
        this.tankController = _tankController;
    }
}