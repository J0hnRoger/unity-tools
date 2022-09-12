using UnityEditor;
using static System.IO.Directory;
using static System.IO.Path;
using static UnityEngine.Application;
using static UnityEditor.AssetDatabase;

namespace RogerFamily.Editor
{
    public static class ToolsMenu
    {
        [MenuItem("Developer/Setup/Create Project Structure")]
        public static void CreateDefaultFolderHierarchy()
        {
            CreateDirectories(Combine(dataPath, "_Project"));
            Refresh();
        }

        static void CreateDirectories(string root, params string[] dir)
        {
            var fullPath = Combine(dataPath, root);
            foreach (var newDirectory in dir)
                CreateDirectory(Combine(fullPath, newDirectory));
        }
    }
}
