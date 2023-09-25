# Purgatory Game

<img src="https://sat02pap001files.storage.live.com/y4mrCaZN_tgxTS8FzVOZ67-ZUZ3w6d3UivzrwUTKrPY61k81MKYxb8Qhr83xPhLWIogXjExJOPLk9_VDdACU-5W6lmpI98_mSD5kRpeAD0TMSuSyM5n-tkt4Lp5HhqeM5fr87dnyH6CEegt32JxhBHtiypvu3yIy2TnWYUBZyO_rOApNpp5EVlLm0YOyxdW_luEanwo9Isfb_VDL_C_N5jl1FgE7ywe7pG8fLmQB3TmJWE?encodeFailures=1&width=393&height=221" height="70%" width="70%">

## Description
The last survivor in a world overrun by monsters, he had faced near-death experiences time and again. Now, armed only with throwing knives, he has become a fearless monster hunter, taking down each terrifying creature one by one.

## Game Mechanic
Purchasing items with points is pretty simple. To accumulate points, simply let your player take damage from enemies; your health will decrease, but those losses will be converted into points.  

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
