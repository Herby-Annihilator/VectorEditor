using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GraphicsEditor2
{
    public partial class CreateProjectParameters : Form
    {
        //
        // Fields
        //

        private ToolStripContentPanel ToolStripContentPanel;


        //
        // Constructors
        //
        public CreateProjectParameters(ToolStripContentPanel toolStripContentPanel) : this()
        {
            ToolStripContentPanel = toolStripContentPanel;
        }
        public CreateProjectParameters()
        {
            InitializeComponent();
        }
        //
        // Methods
        //
        private bool IsAllTextBoxesFilled()
        {
            foreach(Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                    if (control.Text == "")
                        return false;
            }
            return true;
        }
        //
        // Events
        //
        /// <summary>
        /// Создает новый канвас для рисования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = new PictureBox();
            int width = Convert.ToInt32(textBoxCanvasWidth.Text);
            int height = Convert.ToInt32(textBoxCanvasHeight.Text);
            pictureBox.ClientSize = new Size(width, height);
            pictureBox.BorderStyle = BorderStyle.FixedSingle;

            this.ToolStripContentPanel.Controls.Add(pictureBox);
            Size toolStripSize = ToolStripContentPanel.Size;
            pictureBox.BackColor = Color.White;
            pictureBox.Location = new Point(toolStripSize.Width / 2 - width / 2, toolStripSize.Height / 2 - height / 2);
            //
            // Создание проекта
            //
            ProjectCreator projectCreator = new ProjectCreator(comboBoxProjectPlacement.Text, textBoxProjectName.Text);
            try
            {
                projectCreator.CreateProject();
            }
            catch (FileNotFoundException e1)
            {
                MessageBox.Show(e1.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
            this.Dispose();
        }
        /// <summary>
        /// блокирует ввод букв
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCanvasWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        /// <summary>
        /// закрывает форму при нажатии кнопки ОТМЕНА
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        /// <summary>
        /// Выбирается директория
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxProjectPlacement_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = comboBoxProjectPlacement.Text;
            if (path == "Обзор...")
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    path = folderBrowserDialog.SelectedPath;
                    if (path == null)
                    {
                        MessageBox.Show("Выберите директорию", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    comboBoxProjectPlacement.Text = path;
                    comboBoxProjectPlacement.Items.Add(path);

                }
                else
                {
                    return;
                }              
            }
            if (IsAllTextBoxesFilled())
            {
                buttonCreate.Enabled = true;
            }
            else
            {
                buttonCreate.Enabled = false;
            }
        }
        /// <summary>
        /// Сообщает о заполненности всех textbox в данной форме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxProjectName_TextChanged(object sender, EventArgs e)
        {
            if (IsAllTextBoxesFilled())
                this.buttonCreate.Enabled = true;
            else
                buttonCreate.Enabled = false;
        }
    }
}
