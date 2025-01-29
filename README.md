# **Roll-A-Ball: Studio 1 Project**
This is the submission for the COSC516 Studio 1.

## **1. Project Introduction**

Welcome to the **Roll-A-Ball** project, a beginner-friendly Unity 101 project designed to introduce you to Unity's core features, including physics systems, scripting, and user input handling. This project demonstrates how to create a simple environment where a player controls a rolling ball on a plane, collecting objects while avoiding falling off the edges.

Key features of the project include:
- Physics-based movement for a dynamic ball controller.
- Real-time user input detection using the keyboard.
- Visual enhancements through materials and animations.
- A **bonus feature**: The ability for the ball to jump, implemented with collision detection to prevent multi-jump exploits.

---

## **2. User Guide**

### **Running the Project**
1. Clone the repository from GitHub:
   ```bash
   git clone <repository-url>
   cd RollABall
   ```
2. Open the project in Unity (tested on Unity version `6.00031f` or compatible versions).
3. Press the **Play** button in Unity's editor to start the game.

### **Controls**
- **Movement**:
  - Use **WASD** or arrow keys to control the ball's movement on the plane.
- **Jump**:
  - Press **Space** to make the ball jump (**ONLY** when the ball is on the ground).

### **Notes**
- The ball is affected by gravity, so be careful to avoid falling off the edges.
- If the ball cannot move or jump:
  - Ensure that ground objects are tagged as `Ground`.
  - Ensure that pickup objects have the **Is Trigger** option enabled in the Inspector.

---

## **3. Project Demo Video**

Below is a demo video showcasing the core functionalities of the project, including ball movement, jumping, and collecting objects:

[![Roll-A-Ball Demo Video](https://img.youtube.com/vi/your-video-id/0.jpg)](https://www.youtube.com/watch?v=your-video-id)

> Click the image above to view the full demo video.

---

## **4. Key Features**

1. **Physics-Driven Ball Movement**:
   - The ball's movement is powered by Unity's Rigidbody and AddForce system for dynamic interactions.
2. **Real-Time User Input**:
   - Keyboard inputs control the ball's direction and jumping actions in real time.
3. **Bonus Feature**:
   - A jumping mechanic is implemented with collision detection to prevent mid-air double jumps.

---

## **5. File Structure**

```
RollABall/
├── Assets/
│   ├── Scripts/
│   │   ├── BallController.cs    # Main script controlling ball movement and jumping
│   │   ├── Test.cs              # Placeholder script for testing features
│   ├── Scenes/
│   │   └── SampleScene.unity    # The main game scene
```

---

## **6. Project Contributors**

- **LostboiSurviveA1one**

---

Feel free to raise an issue on GitHub if you have any questions or suggestions! 😊
