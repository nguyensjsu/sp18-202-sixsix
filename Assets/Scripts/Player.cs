using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerController))]
[RequireComponent(typeof(GunController))]
public class Player : LivingEntity
{

    public float moveSpeed = 5;

<<<<<<< HEAD
    public Crosshairs crosshairs;

=======
>>>>>>> parent of f619e5f... add crosshairs
    Camera viewCamera;
    PlayerController controller;
    GunController gunController;

    protected override void Start()
    {
        base.Start();
        controller = GetComponent<PlayerController>();
        gunController = GetComponent<GunController>();
        viewCamera = Camera.main;
    }

    void Update()
    {
        // Movement input
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 moveVelocity = moveInput.normalized * moveSpeed;
        controller.Move(moveVelocity);

        // Look input
        Ray ray = viewCamera.ScreenPointToRay(Input.mousePosition);
<<<<<<< HEAD
        Plane groundPlane = new Plane(Vector3.up, Vector3.up * gunController.GunHeight);
=======
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
>>>>>>> parent of f619e5f... add crosshairs
        float rayDistance;

        if (groundPlane.Raycast(ray, out rayDistance))
        {
            Vector3 point = ray.GetPoint(rayDistance);
            //Debug.DrawLine(ray.origin,point,Color.red);
            controller.LookAt(point);
<<<<<<< HEAD
            crosshairs.transform.position = point;
            crosshairs.DetectTargets(ray);
            if ((new Vector2(point.x, point.z) - new Vector2(transform.position.x, transform.position.z)).sqrMagnitude > 1)
            {
                gunController.Aim(point);
            }
=======
>>>>>>> parent of f619e5f... add crosshairs
        }

        // Weapon input
        if (Input.GetMouseButton(0))
        {
            gunController.OnTriggerHold();
        }
        if (Input.GetMouseButtonUp(0))
        {
            gunController.OnTriggerRelease();
        }
<<<<<<< HEAD
        if (Input.GetKeyDown(KeyCode.R))
        {
            gunController.Reload();
        }
    }
}
=======
    }
}
>>>>>>> parent of f619e5f... add crosshairs
