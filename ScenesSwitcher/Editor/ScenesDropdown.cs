#if UNITY_EDITOR
using System.IO;
using UnityEditor;
using UnityEditor.Overlays;
using UnityEditor.SceneManagement;
using UnityEditor.Toolbars;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Khomix.ScenesSwitcher.Editor {
  [EditorToolbarElement(Id, typeof(SceneView))]
  public class ScenesDropdown : EditorToolbarDropdown {
    public const string Id = "Khomix/ScenesSwitcher";

    public ScenesDropdown() {
      text = "Scenes";
      tooltip = "Open scene from Build Settings";
      clicked += ShowMenu;
    }

    private void ShowMenu() {
      var menu = new GenericMenu();
      int count = SceneManager.sceneCountInBuildSettings;

      if (count == 0) {
        menu.AddDisabledItem(new GUIContent("No scenes in Build Settings"));
      } else {
        for (int i = 0; i < count; i++) {
          string path = SceneUtility.GetScenePathByBuildIndex(i);
          string name = Path.GetFileNameWithoutExtension(path);

          menu.AddItem(new GUIContent(name), false, () => {
            if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
              EditorSceneManager.OpenScene(path);
          });
        }
      }

      menu.ShowAsContext();
    }
  }

  [Overlay(typeof(SceneView), "Scenes Switcher", defaultDisplay = true)]
  public class SceneSwitcherOverlay : ToolbarOverlay {
    public SceneSwitcherOverlay()
      : base(ScenesDropdown.Id) {}
  }
}
#endif
