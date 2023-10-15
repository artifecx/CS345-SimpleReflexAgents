using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenigaSimpleReflexAgents
{
    public partial class Form1 : Form
    {
        private PictureBox vacuumPictureBox = new PictureBox
        {
            Size = new Size(50, 50),
            SizeMode = PictureBoxSizeMode.StretchImage,
            Image = Properties.Resources.vacuum
        };

        private HashSet<Panel> visitedPanels = new HashSet<Panel>();
        private List<Panel> possibleNextPanels = new List<Panel>();
        private List<Panel> unvisitedPanels = new List<Panel>();
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        private bool selectedRandom = true;

        public Form1()
        {
            InitializeComponent();
            EnableControlsInGroupBox(gbSettingsManual, false);
            Reset();
            cbStartLocation.SelectedIndex = 0;

            checkA.CheckedChanged += CheckBox_CheckedChanged;
            checkB.CheckedChanged += CheckBox_CheckedChanged;
            checkC.CheckedChanged += CheckBox_CheckedChanged;
            checkD.CheckedChanged += CheckBox_CheckedChanged;
        }

        private void rbRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRandom.Checked)
            {
                gbSettingsManual.Enabled = false;
                EnableControlsInGroupBox(gbSettingsManual, false);
                Reset();
            }
        }

        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManual.Checked)
            {
                gbSettingsManual.Enabled = true;
                EnableControlsInGroupBox(gbSettingsManual, true);
                Reset();
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                Panel correspondingPanel = GetCorrespondingPanel(checkBox.Name);

                if (!correspondingPanel.Controls.Contains(vacuumPictureBox))
                {
                    correspondingPanel.Controls.Clear();
                }
                else
                {
                    correspondingPanel.Controls.Clear();
                    RedrawVacuum(correspondingPanel);
                }

                if (checkBox.Checked)
                {
                    PictureBox dirtPictureBox = CreateDirtPictureBox(correspondingPanel);
                    correspondingPanel.Controls.Add(dirtPictureBox);
                }
            }
        }

        private void cbStartLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLocation = cbStartLocation.SelectedItem.ToString();
            DrawVacuumCleaner(selectedLocation);
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            EnableControlsInGroupBox(gbSettingsMode, false);
            EnableControlsInGroupBox(gbSettingsManual, false);

            tbAction.AppendText("Start in " + GetCurrentPanel().Name.Last() + "\n");

            while (!AllPanelsCleaned())
            {
                Panel currentPanel = GetCurrentPanel();

                CleanPanel(currentPanel);
                visitedPanels.Add(currentPanel);

                MoveToNextPanel(currentPanel);

                try
                {
                    await Task.Delay(1000, cancellationTokenSource.Token);
                }
                catch (TaskCanceledException)
                {
                    break;
                }
            }

            CleanPanel(GetCurrentPanel());
            tbAction.AppendText("\nAll panels cleaned, click reset or switch modes.");

            EnableControlsInGroupBox(gbSettingsMode, true);
            if (rbManual.Checked)
            {
                EnableControlsInGroupBox(gbSettingsManual, true);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cancellationTokenSource?.Cancel();
            Reset();
            cancellationTokenSource = new CancellationTokenSource();
        }

        private void EnableControlsInGroupBox(GroupBox groupBox, bool status)
        {
            foreach (Control control in groupBox.Controls)
            {
                control.Enabled = status;
            }
        }

        private void DrawVacuumCleaner(string selectedLocation)
        {
            Panel correspondingPanel = GetCorrespondingPanel(selectedLocation);
            correspondingPanel.Controls.Remove(vacuumPictureBox);
            RedrawVacuum(correspondingPanel);
        }

        private void RedrawVacuum(Panel panel)
        {
            vacuumPictureBox.Location = new Point(
                (panel.Width - vacuumPictureBox.Width) / 2,
                (panel.Height - vacuumPictureBox.Height) / 2 - 50
            );
            panel.Controls.Add(vacuumPictureBox);
        }

        private PictureBox CreateDirtPictureBox(Panel parentPanel)
        {
            PictureBox dirtPictureBox = new PictureBox
            {
                Image = Properties.Resources.dirt,
                Size = new Size(50, 50),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            dirtPictureBox.Parent = parentPanel;

            dirtPictureBox.Location = new Point(
                (dirtPictureBox.Parent.Width - dirtPictureBox.Width) / 2,
                dirtPictureBox.Parent.Height - dirtPictureBox.Height
            );

            return dirtPictureBox;
        }

        private Panel GetCurrentPanel()
        {
            foreach (Control control in Controls)
            {
                if (control is Panel panel && panel.Controls.Contains(vacuumPictureBox))
                {
                    return panel;
                }
            }
            return null;
        }

        private Panel GetCorrespondingPanel(string checkBoxName)
        {
            string panelIdentifier = checkBoxName.StartsWith("check") ? checkBoxName.Substring(5) : checkBoxName;

            switch (panelIdentifier)
            {
                case "A":
                    return pnlA;
                case "B":
                    return pnlB;
                case "C":
                    return pnlC;
                case "D":
                    return pnlD;
                default:
                    return GetRandomPanel();
            }
        }

        private Panel GetRandomPanel()
        {
            Random random = new Random();
            int randomIndex = random.Next(1, 5);

            switch (randomIndex)
            {
                case 1:
                    return pnlA;
                case 2:
                    return pnlB;
                case 3:
                    return pnlC;
                case 4:
                    return pnlD;
                default:
                    throw new InvalidOperationException();
            };
        }

        private List<Panel> GetRandomPanels(int percentage)
        {
            List<Panel> allPanels = new List<Panel> { pnlA, pnlB, pnlC, pnlD };
            Random random = new Random();
            List<Panel> selectedPanels = new List<Panel>();

            foreach (Panel panel in allPanels)
            {
                if (random.Next(100) < percentage)
                {
                    selectedPanels.Add(panel);
                }
            }

            return selectedPanels;
        }

        private void MoveToNextPanel(Panel currentPanel)
        {
            Panel nextPanel = GetNextPanel(currentPanel);

            tbAction.AppendText("Move to " + nextPanel.Name.Last() + "\n");

            nextPanel.Controls.Add(vacuumPictureBox);

            RedrawVacuum(nextPanel);
        }

        private Panel GetNextPanel(Panel currentPanel)
        {
            possibleNextPanels = GetPossibleNextPanels(currentPanel);

            // Filter out the visited panels
            unvisitedPanels = possibleNextPanels.Except(visitedPanels).ToList();

            // Randomly visit an unvisited panel
            // only works for initial state
            // because you are not allowed to return to previous after moving
            Random random = new Random();
            int randomIndex = random.Next(unvisitedPanels.Count);
            Panel nextPanel = unvisitedPanels[randomIndex];

            visitedPanels.Add(nextPanel);

            return nextPanel;
        }
        private List<Panel> GetPossibleNextPanels(Panel currentPanel)
        {
            switch (currentPanel.Name)
            {
                case "pnlA":
                    return new List<Panel> { pnlB, pnlC };
                case "pnlB":
                    return new List<Panel> { pnlA, pnlD };
                case "pnlC":
                    return new List<Panel> { pnlA, pnlD };
                case "pnlD":
                    return new List<Panel> { pnlB, pnlC };
                default:
                    throw new InvalidOperationException();
            }
        }

        private bool AllPanelsCleaned()
        {
            return visitedPanels.Contains(pnlA) &&
                   visitedPanels.Contains(pnlB) &&
                   visitedPanels.Contains(pnlC) &&
                   visitedPanels.Contains(pnlD);
        }

        private void CleanPanel(Panel panel)
        {
            // Perform cleaning action based on the presence of dirt
            if (panel.Controls.OfType<PictureBox>().Any(p => AreImagesEqual(p.Image, Properties.Resources.dirt)))
            {
                tbAction.AppendText("Clean " + panel.Name.Last() + "\n");
                panel.Controls.Clear();
                RedrawVacuum(panel);
            }
            else
            {
                tbAction.AppendText("No Action\n");
            }
        }

        // added this method to see if dirt exists in the panel because "if ==" doesnt work in CleanPanel()
        private bool AreImagesEqual(Image image1, Image image2)
        {
            if (image1 == null || image2 == null)
            {
                return false;
            }

            using (MemoryStream ms1 = new MemoryStream(), ms2 = new MemoryStream())
            {
                image1.Save(ms1, image1.RawFormat);
                image2.Save(ms2, image2.RawFormat);

                byte[] imageBytes1 = ms1.ToArray();
                byte[] imageBytes2 = ms2.ToArray();

                return StructuralComparisons.StructuralEqualityComparer.Equals(imageBytes1, imageBytes2);
            }
        }

        private void ClearAllPanels()
        {
            foreach (Control control in Controls)
            {
                if (control is Panel panel)
                {
                    panel.Controls.Clear();
                }
            }
        }

        private void Reset()
        {
            ClearAllPanels();

            visitedPanels.Clear();
            unvisitedPanels = possibleNextPanels.ToList();

            if (rbManual.Checked)
            {
                // If in manual mode, fill in the checked boxes with dirt
                foreach (Control control in gbSettingsManual.Controls)
                {
                    if (control is CheckBox checkBox && checkBox.Checked)
                    {
                        Panel correspondingPanel = GetCorrespondingPanel(checkBox.Name);
                        PictureBox dirtPictureBox = CreateDirtPictureBox(correspondingPanel);
                        correspondingPanel.Controls.Add(dirtPictureBox);
                    }
                }

                // Put the vacuum in the selected option
                Panel initialPanel = GetCorrespondingPanel(cbStartLocation.SelectedItem.ToString());
                initialPanel.Controls.Add(vacuumPictureBox);
                RedrawVacuum(initialPanel);
            }
            else
            {
                // Randomize vacuum location
                Panel initialPanel = GetRandomPanel();
                initialPanel.Controls.Add(vacuumPictureBox);
                RedrawVacuum(initialPanel);

                // Percentage of dirt appearing in each panel
                int dirtPercentage = 50;
                List<Panel> panelsWithDirt = GetRandomPanels(dirtPercentage);

                // Randomize dirt location
                foreach (Panel panel in panelsWithDirt)
                {
                    PictureBox dirtPictureBox = CreateDirtPictureBox(panel);
                    panel.Controls.Add(dirtPictureBox);
                }
            }

            btnStart.Enabled = true;
            tbAction.Text = string.Empty;
        }
    }
}