# Scenes Switcher

[🇺🇦 Read in Ukrainian](README.uk.md)

**Scenes Switcher** is a Unity Editor tool by **Khomix** that adds a button in the Scene View Toolbar for quickly switching between scenes from **Build Settings**.

## ✨ Features
- Dropdown in Scene View with all scenes from Build Settings.
- Automatically opens the selected scene (with save confirmation).
- Works only in Editor (does not get included in the build).

---

## 📦 Installation

### Install via UPM (recommended)
1. In Unity, open **Window → Package Manager**.
2. Click **+ → Add package from git URL…**
3. Paste:
   https://github.com/Khomix/Khomix.ScenesSwitcher.git#v1.0.0


### Install via `.unitypackage`
1. Download `KhomixScenesSwitcher.unitypackage` from [Releases](https://github.com/Khomix/Khomix.ScenesSwitcher/releases).
2. In Unity, choose **Assets → Import Package → Custom Package…**
3. Select the file and import.

---

## 🚀 Usage
1. Add scenes to **File → Build Settings… → Scenes In Build**.
2. Open **Scene View**.
3. If the **Scenes** button doesn’t appear automatically:
- In the top-right corner of Scene View, click the **three dots (Overlays)**.
- In the list, enable **Scenes Switcher**.
- After that, the button will appear in the toolbar.
4. Click **Scenes** → select a scene from the list → it will open immediately.

---

## 📂 Package Structure
Editor/
Khomix.ScenesSwitcher.Editor.asmdef
ScenesDropdown.cs

---

## ⚙️ Requirements
- Unity **2021.3 LTS** or newer
- Editor-only package

---

## 📜 License
Distributed under the [MIT](LICENSE) License.  
Author: **Khomix**

