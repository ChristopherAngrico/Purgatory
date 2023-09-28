# Purgatory Game

<img src="https://github.com/ChristopherAngrico/Purgatory/assets/87889745/bd150fb6-9bb0-4bcf-bc7c-26eafd74f49e" height="70%" width="70%">

## Description
The last survivor in a world overrun by monsters, he had faced near-death experiences time and again. Now, armed only with throwing knives, he has become a fearless monster hunter, taking down each terrifying creature one by one.

## Game Mechanic
<p>Attack<p/><br/>
<img src="https://github.com/ChristopherAngrico/Purgatory/blob/main/Purgatory/Attack.GIF?raw=true" height="30%" width="30%">
  
<p>Movement<p/><br/>
<img src="https://github.com/ChristopherAngrico/Purgatory/blob/main/Purgatory/Movement.GIF?raw=true" height="30%" width="30%">

<p>Clone<p/><br/>
<img src="https://github.com/ChristopherAngrico/Purgatory/blob/main/Purgatory/Clone.png?raw=true" height="30%" width="30%">

<p>Flip<p/><br/>
<img src="https://github.com/ChristopherAngrico/Purgatory/blob/main/Purgatory/Flip.GIF?raw=true" height="30%" width="30%">

<p>Boss1<p/><br/>
<img src="https://github.com/ChristopherAngrico/Purgatory/blob/main/Purgatory/Boss1.GIF?raw=true" height="30%" width="30%">  

<p>Point<p/><br/>
<img src="https://github.com/ChristopherAngrico/Purgatory/blob/main/Purgatory/Point.png" height="30%" width="30%">

<p>Upgrade UI<p/><br/>
<img src="https://github.com/ChristopherAngrico/Purgatory/blob/main/Purgatory/UI%20Upgrade.png" height="30%" width="30%">

<p>Boss2<p/><br/>
<img src="https://github.com/ChristopherAngrico/Purgatory/blob/main/Purgatory/Boss2.GIF" height="30%" width="30%">
  
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
