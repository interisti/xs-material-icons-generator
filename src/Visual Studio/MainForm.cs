using MaterialIcons.UI;
using Microsoft.VisualStudio.Shell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialIconsGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO start waiting
            this.LoadIcons();
            this.LoadColors();
            this.LoadSizes();
            // TODO stop waiting

            this.iconComboBox.SelectedIndexChanged += IconComboBox_SelectedIndexChanged;
            this.colorComboBox.SelectedIndexChanged += ColorComboBox_SelectedIndexChanged;
            this.sizeComboBox.SelectedIndexChanged += SizeComboBox_SelectedIndexChanged;
        }

        private void LoadIcons()
        {
            this.iconComboBox.DataSource = IconDownloader.DownloadIconsFromRepo();
            // clear initial selection
            this.iconComboBox.SelectedIndex = -1;
        }

        private void LoadColors()
        {
            this.colorComboBox.DataSource = IconColors.KnownColors.Concat(IconColors.Colors.Keys).ToList();
        }

        private void LoadSizes()
        {
            this.sizeComboBox.DataSource = IconDownloader.KnownSizes;
            this.sizeComboBox.SelectedItem = IconDownloader.KnownSizes[1];
        }

        private void SetPreview()
        {
            // TODO
        }

        private void StartDownloading()
        {
            // TODO
        }

        #region Events

        private void SizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetPreview();
        }

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetPreview();
        }

        private void IconComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetPreview();
        }

        private void sourceButton_Click(object sender, EventArgs e)
        {
            VsShellUtilities.OpenSystemBrowser("https://github.com/google/material-design-icons");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.StartDownloading();
        }

        #endregion
    }
}
