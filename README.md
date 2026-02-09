# 🏰 Royal Run — Unity Endless Runner

> **Royal Run** is an endless-runner style mobile/PC game built in Unity where the player runs automatically, switches lanes, jumps over fences, and dodges incoming obstacles. The game uses procedural level chunk generation, input actions, physics materials, animations, and scoring mechanics to create a polished, fast‑paced experience.

---

## 📸 Game Preview

[![Watch the video](https://img.youtube.com/vi/VIDEO_ID/0.jpg)]([https://www.youtube.com/watch?v=VIDEO_ID](https://youtu.be/syOwLyX-B-Q))

---

## 🎮 Core Features

* Automatic player running
* Lane‑based movement using **Input Actions**
* Chunk‑based **procedural level generation**
* Multiple obstacle variants & fence types
* Physics materials for smooth gameplay
* Score system + coin implementation
* Game over logic
* Post‑processing for final visual look
* Animations: running, jumping, triggers

---

## 🧠 How Gameplay Works

### 🔹 Automatic Running

The player constantly moves forward using a fixed forward speed.

### 🔹 Lane Change System

The player can switch between L‑C‑R lanes using Input Action callbacks.

### 🔹 Procedural Level

Level is built using **moving chunks** that recycle behind the player to create infinite gameplay.

### 🔹 Spawning Obstacles

Obstacles spawn using an **object spawner** that uses random selection from prefab lists.

### 🔹 Score & Coins

Score increases with distance and coins add extra points.

---

## 🛠️ Tech Stack

* **Unity Engine**
* **C#**
* **Input System Package**
* **Navmesh / Physics Materials (if used)**
* **Post Processing Stack**

---

## 🚀 How to Run the Project

1. Clone or download the project folder
2. Open in **Unity 2021+** (or your used version)
3. Make sure Input System package is installed
4. Press **Play** to start the endless runner
