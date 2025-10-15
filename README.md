# 🌌 Unknown Planet — Unity 3D Physics Scene

An interactive 3D environment built in **Unity** that demonstrates real-time physics, gravitational forces, and particle effects within an alien landscape. This project combines creativity and technical precision to showcase Unity’s physics engine and animation capabilities.

---

## 🪐 Overview

**Unknown Planet** explores the behavior of physics-based objects in a sci-fi environment inspired by alien terrain.  
Players control a penguin wearing a green hat as it navigates across a planet with realistic gravity, windmill motion, and particle-based waterfalls.  

The project highlights key Unity features:
- Rigidbody-driven movement and collisions  
- Dynamic camera tracking and user input  
- Gravitational force simulation for planetary pull  
- Particle systems for fluid-like water effects  
- Hinge joints for rotational windmill mechanics  

---

## 🧠 Core Features

| Feature | Description |
|----------|-------------|
| **Physics-Based Movement** | Uses Unity’s `Rigidbody` for realistic mass, drag, and gravity simulation. |
| **Custom Gravity System** | Applies directional force toward a defined planet center, creating orbital-like motion. |
| **Windmill Simulation** | Implements `HingeJoint` with torque for wind-powered rotation. |
| **Waterfall Particles** | Uses Unity’s Particle System to simulate water droplets with velocity and gravity influence. |
| **Dynamic Camera System** | Third-person view that follows player orientation and mouse focus. |

---

## ⚙️ Technical Principles

- **Newtonian Mechanics:** `Force = Mass × Acceleration` governs Rigidbody motion.  
- **Vector Mathematics:** Directional forces determine object trajectories and gravity pull.  
- **Collision Detection:** Unity’s Collider system manages physical interactions.  
- **Torque & Rotation:** Applied around the y-axis for turning and windmill movement.  
- **Transform Updates:** Ensures smooth camera tracking and user immersion.  

---

## 🎮 Controls

| Action | Key |
|--------|-----|
| Move Forward / Backward | W / S |
| Rotate | A / D |
| Jump | Spacebar |
| Camera Orbit | Mouse Movement |

---

## 🧩 Evaluation

This project effectively integrates **Unity’s physics engine** with interactive gameplay.  
The combination of **gravitational pull, fluid simulation, and Rigidbody dynamics** showcases realistic motion and environmental depth.  
Future improvements may include dynamic wind zones and particle-object interactions for enhanced realism.

---

## 📁 Folder Structure

```plaintext
UnknownPlanet/
├── Assets/
│   ├── Scripts/
│   ├── Scenes/
│   ├── Materials/
│   └── Prefabs/
├── Packages/
├── ProjectSettings/
└── README.md
