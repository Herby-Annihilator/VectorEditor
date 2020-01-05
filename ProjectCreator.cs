using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace GraphicsEditor2
{
    class ProjectCreator
    {
        public string FilePath { get; set; }
        public string ProjectName { get; set; }

        public string FullPath { get; private set; }

        public ProjectCreator()
        {
            ProjectName = "DefaultProject";
            FilePath = "C:\\";
        }

        public ProjectCreator(string filePath, string projectName)
        {
            FilePath = filePath;
            ProjectName = projectName;
            FullPath = FilePath + "\\" + ProjectName;
        }
        /// <summary>
        /// Создаст  папку с проектом
        /// </summary>
        public virtual void CreateProject()
        {
            if (string.IsNullOrWhiteSpace(FilePath) || string.IsNullOrWhiteSpace(ProjectName))
            {
                MessageBox.Show("Некорректное имя", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return;
            }
            if (Directory.Exists(FullPath) == true)
            {
                DialogResult dialogResult = MessageBox.Show("Такой проект уже существует. Заменить?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                else
                    Directory.Delete(FullPath, true);
            }
            Directory.CreateDirectory(FullPath);
            StreamWriter writer = new StreamWriter(FullPath + "\\" + ProjectName + ".dat");
            if (writer == null)
            {
                throw new FileNotFoundException("Не удалось создать проект. Попробуйте еще раз");
            }
            writer.WriteLine("ProjectName: " + ProjectName);
            writer.WriteLine(writer.NewLine + "Powered by RukinStudio" + writer.NewLine);
            writer.Close();
        }
    }
}
