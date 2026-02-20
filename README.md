# 🎮 Maze GamE

A simple 3D maze game built with Unity where you navigate a ball through a maze using physics-based controls.

## 🎯 About

This is a classic ball-rolling maze game where players must guide a ball from start to finish by tilting and navigating through maze walls. The game uses Unity's physics engine (Rigidbody) to create realistic ball movement.

## 🕹️ How to Play

- **Arrow Keys** or **WASD** — Move the ball
- Navigate through the maze without falling off the edges
- Reach the end to complete the level!

## 🚀 Getting Started

### Prerequisites

- [Unity Hub](https://unity.com/download) installed on your computer
- Unity Editor version **2022.3.46f1** or compatible (2022.3.x LTS recommended)

### Running the GamE

1. **Clone or download** this repository to your local machine

2. **Open Unity Hub** and click **"Open"** or **"Add"**

3. **Navigate** to the project folder and select it:
   ```
   MazeGame-main
   ```

4. **Wait** for Unity to import all assets (this may take a few minutes on first open)

5. **Open the game scene:**
   - In the Project window, go to `Assets → Scenes`
   - Double-click on `SampleScene`

6. **Press the Play button** (▶️) at the top of the Unity Editor to start playing!

### Building the Game

To create a standalone executable:

1. Go to **File → Build Settings**
2. Select your target platform (Windows, Mac, Linux, etc.)
3. Click **"Build"** and choose a destination folder
4. Run the generated executable

## 📁 Project Structure

```
MazeGame/
├── Assets/
│   ├── Material/       # Materials for visual appearance
│   ├── Scenes/         # Game scenes
│   │   └── SampleScene.unity
│   └── Script/         # Game scripts
│       └── motion.cs   # Ball movement controller
├── Packages/           # Unity package dependencies
├── ProjectSettings/    # Unity project configuration
└── README.md
```

## 🛠️ Technical Details

- **Engine:** Unity 2022.3.46f1 (LTS)
- **Physics:** Rigidbody-based ball movement
- **Controls:** Force-based input using `Input.GetAxis()`
- **Default Speed:** 10 units

## 🎨 Customization

Want to tweak the gameplay? Here are some easy modifications:

- **Ball Speed:** Select the ball in the scene, find the `Motion` script in the Inspector, and adjust the `Speed` value
- **Maze Layout:** Modify the walls and obstacles in the Scene view
- **Materials:** Edit materials in `Assets/Material/` to change colors and appearance

## 📄 License

This project is licensed under the **GNU General Public License v3.0** — see the [LICENSE](LICENSE) file for details.

---

*Have fun navigating the maze! 🎲*
