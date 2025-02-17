using Fusion;
using UnityEngine;

public class PlayerWeaponController : NetworkBehaviour, IBeforeUpdate
{
    public Quaternion LocalQuaternionPivotRot { get; private set; }
    [SerializeField] private float delayBetweenShots = 0.18f;
    [SerializeField] private ParticleSystem muzzleEffect;
    [SerializeField] private Camera localCam;
    [SerializeField] private Transform pivotToRotate;

    [Networked, HideInInspector] public NetworkBool IsHoldingShootingKey { get; private set; }
    [Networked(OnChanged = nameof(OnMuzzleEffectStateChanged))] private NetworkBool playMuzzleEffect { get; set; }
    [Networked] private Quaternion currentPlayerPivotRotation { get; set; }
    
    [Networked] private NetworkButtons buttonsPrev { get; set; }
    [Networked] private TickTimer shootCoolDown { get; set; }
    
    public void BeforeUpdate()
    {
        if (Runner.LocalPlayer == Object.HasInputAuthority)
        {
            var direction = localCam.ScreenToWorldPoint(Input.mousePosition) - transform.position;

            var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            LocalQuaternionPivotRot = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    public override void FixedUpdateNetwork()
    {
        if (Runner.TryGetInputForPlayer<PlayerData>(Object.InputAuthority, out var input))
        {
            CheckShootInput(input);
            currentPlayerPivotRotation = input.GunPivotRotation;

            buttonsPrev = input.NetworkButtons;
        }
        
        pivotToRotate.rotation = currentPlayerPivotRotation;
    }

    private void CheckShootInput(PlayerData input)
    {
        var currentBtns = input.NetworkButtons.GetPressed(buttonsPrev);

        IsHoldingShootingKey = currentBtns.WasReleased(buttonsPrev, PlayerController.PlayerInputButtons.Shoot);
        
        if (currentBtns.WasReleased(buttonsPrev, PlayerController.PlayerInputButtons.Shoot) && shootCoolDown.ExpiredOrNotRunning(Runner))
        {
            playMuzzleEffect = true;
            shootCoolDown = TickTimer.CreateFromSeconds(Runner, delayBetweenShots);
        }
        else
        {
            playMuzzleEffect = false;
        }
    }


    private static void OnMuzzleEffectStateChanged(Changed<PlayerWeaponController> changed)
    {
        var currentState = changed.Behaviour.playMuzzleEffect;

        changed.LoadOld();
        var oldState = changed.Behaviour.playMuzzleEffect;

        if (oldState != currentState)
        {
            changed.Behaviour.PlayOrStopMuzzleEffect(currentState);
        }
    }

    private void PlayOrStopMuzzleEffect(bool play)
    {
        if (play)
        {
            muzzleEffect.Play();
        }
        else
        {
            muzzleEffect.Stop();
        }
    }
}













