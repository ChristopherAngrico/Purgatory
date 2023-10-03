# Purgatory Game

<img src="https://github.com/ChristopherAngrico/Purgatory/assets/87889745/bd150fb6-9bb0-4bcf-bc7c-26eafd74f49e" height="70%" width="70%">

## Description
The last survivor in a world overrun by monsters, he had faced near-death experiences time and again. Now, armed only with throwing knives, he has become a fearless monster hunter, taking down each terrifying creature one by one.

## Game Mechanic
<p>Attack<p/><br/>
<img src="https://github.com/ChristopherAngrico/Purgatory/assets/87889745/8c9b3237-6ae1-4a2b-ae16-81913c0171a3" height="30%" width="30%">

```C#
private void ThrowKnifeDirection()
    {
        GameObject knifeClone = Instantiate(g_knife) as GameObject;
        knifeClone.transform.position = transform.position;
        knifeClone.transform.rotation = Quaternion.Euler(0, 0, rotationZ + 90);
        knifeClone.GetComponent<Rigidbody2D>().velocity = direction * throwSpeed;
    }
```

<p>Movement<p/><br/>
<img src="https://github.com/ChristopherAngrico/Purgatory/assets/87889745/7ff3abb8-6dbb-4f13-95bc-42b76e9b2073" height="30%" width="30%">
    
```c#
rb.velocity = PlayerInput.getPlayerInput.direction * movementSpeed;
```

<p>Clone<p/><br/>
<img src="https://github.com/ChristopherAngrico/Purgatory/blob/main/Purgatory/Clone.png?raw=true" height="30%" width="30%">

<p>Flip<p/><br/>
<img src="https://github.com/ChristopherAngrico/Purgatory/assets/87889745/1f706385-2949-48d1-823b-81fef4812ce3" height="30%" width="30%">

```C#
private void FlippingSprite()
    {
        //Flipping sprite by following mouse direction
        if (differenceXPosition < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
```


<p>Boss1 Attack<p/><br/>
<img src="https://github.com/ChristopherAngrico/Purgatory/assets/87889745/86130c7f-67c9-4ae1-b9ad-826727822875" height="30%" width="30%">

```C#
private void OnEnable()
    {
        if (transform.parent.CompareTag("Boss1"))
        {
            box = GetComponentInChildren<BoxCollider2D>();
            box.enabled = true;
        }
        if (transform.parent.CompareTag("Boss2") || transform.parent.CompareTag("Minion"))
        {
            polygon = GetComponentInChildren<PolygonCollider2D>();
            polygon.enabled = true;
        }
    }
    private void OnDisable()
    {
        if (transform.parent.CompareTag("Boss1"))
        {
            box.enabled = false;
        }
        if (transform.parent.CompareTag("Boss2") || transform.parent.CompareTag("Minion"))
        {
            polygon.enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Clone"))
        {

            damagePlayer = true;
            if (GameObject.FindWithTag("Clone") != null)
            {
                damageClone = true;
            }
        }
    }
```

<p>Boss1 Walk<p/><br/>
<img src="https://github.com/ChristopherAngrico/Purgatory/assets/87889745/475a1834-14e0-4b3a-a736-9e804c5007c4" height="30%" width="30%">

<p>Boss1 die<p/><br/>
<img src="https://github.com/ChristopherAngrico/Purgatory/assets/87889745/feb9907e-a63e-4fd9-bd3c-7950b8e6c5ad" height="30%" width="30%">  

<p>Point<p/><br/>
<img src="https://github.com/ChristopherAngrico/Purgatory/assets/87889745/86071b8f-42d8-4625-88bb-73ae58c17b82" height="30%" width="30%">

<p>Upgrade UI<p/><br/>
<img src="https://github.com/ChristopherAngrico/Purgatory/assets/87889745/e365da18-d551-4479-9c82-08d5834c2566" height="30%" width="30%">

<p>Boss2 Attack<p/><br/>
<img src="https://github.com/ChristopherAngrico/Purgatory/assets/87889745/b8d06361-696d-49d4-b44d-1479694e5e6a" height="30%" width="30%">

<p>Boss2 walk<p/><br/>
<img src="https://github.com/ChristopherAngrico/Purgatory/assets/87889745/38b54c18-e735-4d8e-91b5-4d98b6f5f35f" height="30%" width="30%">

<p>Boss2 die<p/><br/>
<img src="https://github.com/ChristopherAngrico/Purgatory/assets/87889745/ed864e71-65b6-41ca-9d96-c6f778c7a968" height="30%" width="30%">

## Game controls

The following controls are bound in-game, for gameplay and testing.

| Key Binding       | Function          |
| ----------------- | ----------------- |
| W,A,S,D           | Standard movement |
| Left Click        | Throw  knife      |

### Script

This game operates on a series of scripts..

| Script       | Description                                                  |
| ------------------- | ------------------------------------------------------------ |
| `PlayerMovement` | To control player movement such as "WASD". |
| `Animated`  | Control all the animation such as Player, Clone, and Enemy. |
| `CloneHealth`  | Control clone health. |
| `FixRotateHealthBar`  | Fix health bar rotation for example: player face the left side or right side the rotation still remaining same.  |
| `DetectPlayer`  | Detect player is within enemy range.  |
| `EnemyCondition`  | Condition of an enemy such as getting hit by player or die.  |
| `HitPlayer`  | If player enter range attack will get hit. |
| `SpawnEnemy`  | Spawn manager to control spawn system. |
| `HealthSystem`  | Simplify class of health system. |
| `InputSystem`  | New input system. |
| `Knife damage`  | to damage enemy when it hit. |
| `PlayerHurt`  | Condition of the player such as getting hit by enemy or die. |
| `PlayerInput`  | Control all input. |
| `ThrowKnife`  | Throw knife by mouse direction. |
| `BackgroundLoop`  | Move the background if player move to all direction. |
| `ChangeScene`  | Control changing scene. |
| `DestroyKnife`  | Knife will get destroy when fly out of screen. |
| `FollowTarget`  | Follow player position such as player move to right main camera, spawner, and background follow the player position. |
| `ThrowKnife`  | Throw knife by mouse direction. |
| `GameManager`  | Manage point and wave system. |
| `MovingSpawner`  | To make sure spawn position is random. |
| `BuyButton`  | Action after mouse clicked for buy button. |
| `GUIButton`  | Action after mouse clicked for menu. |
| `VolumeControl`  | Control game volume. |
| `Point`  | Show point in UI text. |

## Short Gameplay
From here:
https://www.youtube.com/watch?v=xbCiaC3eRx0&ab_channel=ChristopherAngrico
