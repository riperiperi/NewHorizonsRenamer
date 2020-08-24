using NHSE.Core;
using System;
using System.IO;
using System.Windows.Forms;

namespace NewHorizonsRenamer
{
    public partial class Main : Form
    {
        private HorizonSave _loaded;
        private bool _readonly;
        private Villager[] _villagers;
        private DesignPattern[] _designs;
        private DesignPatternPRO[] _designsTailor;
        private DesignPatternPRO[] _pro;

        private int lastPlayer = 0;

        public Main()
        {
            InitializeComponent();
        }

        public string TryLocateRyu()
        {
            string saveBase = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Ryujinx/bis/user/save/");

            try
            {
                string[] list = Directory.GetDirectories(saveBase);

                foreach (string dir in list)
                {
                    if (File.Exists(Path.Combine(dir, "0/main.dat")) &&
                        File.Exists(Path.Combine(dir, "0/mainHeader.dat")) &&
                        Directory.Exists(Path.Combine(dir, "0/Villager0")))
                    {
                        return Path.Combine(dir, "0");
                    }
                }
            }
            catch (Exception)
            {

            }

            return null;
        }

        public void LoadSave(string folder)
        {
            try
            {
                _loaded = new HorizonSave(folder);
                _villagers = _loaded.Main.GetVillagers();
                _designs = _loaded.Main.GetDesigns();
                _designsTailor = _loaded.Main.GetDesignsTailor();
                _pro = _loaded.Main.GetDesignsPRO();

                StatusLabel.Text = folder;

                CopyFolder(folder, $"bak-{(uint)DateTime.Now.Ticks}");

                PopulateSave(true);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Could not open save: ${e.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PopulateSave(bool resetPlayerNum)
        {
            SaveBox.Enabled = true;

            _readonly = true;

            if (resetPlayerNum)
            {
                PlayerNum.Maximum = _loaded.Players.Length - 1;

                PlayerNum.Value = 0;
                lastPlayer = 0;
            }

            int playerNum = (int)PlayerNum.Value;

            Player player = _loaded.Players[playerNum];
            PlayerName.Text = player.Personal.PlayerName;
            PlayerID.Text = "ID: " + player.Personal.PlayerID.ToString("x8");

            TownName.Text = player.Personal.TownName;
            TownID.Text = "ID: " + player.Personal.TownID.ToString("x8");

            _readonly = false;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.FileName = "main.dat";
            dialog.Title = "Locate main.dat in the AC:NH save.";
            dialog.DefaultExt = ".dat";
            dialog.Filter = "AC:NH Main Save File (.dat)|*.dat";

            var result = dialog.ShowDialog();

            if (result != DialogResult.OK) return;

            LoadSave(Path.GetDirectoryName(dialog.FileName));
        }

        public static void CopyFolder(string source, string dest, bool subfolders = true)
        {
            Directory.CreateDirectory(dest);

            var dir = new DirectoryInfo(source);
            foreach (var file in dir.EnumerateFiles())
            {
                var path = Path.Combine(dest, file.Name);
                file.CopyTo(path, false);
            }

            if (!subfolders)
                return;

            foreach (var folder in dir.EnumerateDirectories())
            {
                var path = Path.Combine(dest, folder.Name);
                CopyFolder(folder.FullName, path);
            }
        }

        private void UpdateCrossRefsPlayer(bool randomID, int playerNum = -1)
        {
            Random random = new Random();
            byte[] bytes = new byte[4];

            playerNum = playerNum == -1 ? (int)PlayerNum.Value : playerNum;

            Player player = _loaded.Players[playerNum];

            string oldName = player.Personal.PlayerName;
            string newName = PlayerName.Text;
            uint oldId = player.Personal.PlayerID;
            random.NextBytes(bytes);
            uint newId = randomID ? BitConverter.ToUInt32(bytes, 0) : oldId;

            string oldTown = player.Personal.TownName;
            string newTown = TownName.Text;
            uint oldTownId = player.Personal.TownID;
            random.NextBytes(bytes);
            uint newTownId = randomID ? BitConverter.ToUInt32(bytes, 0) : oldTownId;

            byte[] oldPlayerIdentity = player.Personal.GetPlayerIdentity();
            byte[] oldTownIdentity = player.Personal.GetTownIdentity();

            player.Personal.PlayerName = newName;
            player.Personal.PlayerID = newId;

            player.Personal.TownName = newTown;
            player.Personal.TownID = newTownId;

            byte[] newPlayerIdentity = player.Personal.GetPlayerIdentity();
            byte[] newTownIdentity = player.Personal.GetTownIdentity();

            _loaded.ChangeIdentity(oldPlayerIdentity, newPlayerIdentity);
            _loaded.ChangeIdentity(oldTownIdentity, newTownIdentity);

            /*
             * I would much prefer if we could surgically replace the relevant IDs rather than find replace,
             * but they don't seem to be all covered yet. Maybe one day.
             * Just hope someone doesn't spell out your ID and name in a furniture arrangment or something.
             * 
            foreach (var villager in _villagers)
            {
                var memories = villager.GetMemories();

                foreach (var memory in memories)
                {
                    if (memory.PlayerName == oldName && memory.PlayerID == oldId && memory.TownName == oldTown && memory.TownID == oldTownId)
                    {
                        memory.PlayerName = newName;
                        memory.PlayerID = newId;
                        memory.TownName = newTown;
                        memory.TownID = newTownId;
                    }
                }

                villager.SetMemories(memories);
            }

            _loaded.Main.SetVillagers(_villagers);

            foreach (var design in _designs)
            {
                if (design.PlayerName == oldName && design.PlayerID == oldId && design.TownName == oldTown && design.TownID == oldTownId)
                {
                    design.PlayerName = newName;
                    design.PlayerID = newId;
                    design.TownName = newTown;
                    design.TownID = newTownId;
                }
            }

            _loaded.Main.SetDesigns(_designs);

            foreach (var design in _pro)
            {
                if (design.PlayerName == oldName && design.PlayerID == oldId && design.TownName == oldTown && design.TownID == oldTownId)
                {
                    design.PlayerName = newName;
                    design.PlayerID = newId;
                    design.TownName = newTown;
                    design.TownID = newTownId;
                }
            }

            _loaded.Main.SetDesignsPRO(_pro);

            foreach (var design in _designsTailor)
            {
                if (design.PlayerName == oldName && design.PlayerID == oldId && design.TownName == oldTown && design.TownID == oldTownId)
                {
                    design.PlayerName = newName;
                    design.PlayerID = newId;
                    design.TownName = newTown;
                    design.TownID = newTownId;
                }
            }

            _loaded.Main.SetDesignsTailor(_designsTailor);

            for (int i = 0; i < _loaded.Players.Length; i++)
            {
                if (i == playerNum) continue;

                Player other = _loaded.Players[i];

                other.Personal.TownName = newTown;
                other.Personal.TownID = newTownId;
            }
            */
        }

        private void Save()
        {
            try
            {
                UpdateCrossRefsPlayer(false);

                _loaded.Save((uint)DateTime.Now.Ticks);

                MessageBox.Show("Successfully saved the modified game data!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not save game data.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            UpdateCrossRefsPlayer(true);
            PopulateSave(false);
            Save();
        }

        private void SaveOldButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void PlayerName_TextChanged(object sender, EventArgs e)
        {
            if (_readonly) return;
        }

        private void TownName_TextChanged(object sender, EventArgs e)
        {
            if (_readonly) return;
        }

        private void PlayerNum_ValueChanged(object sender, EventArgs e)
        {
            if (_readonly) return;

            UpdateCrossRefsPlayer(false, lastPlayer);
            lastPlayer = (int)PlayerNum.Value;

            PopulateSave(false);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string autoLoad = TryLocateRyu();
            if (autoLoad != null)
            {
                LoadSave(autoLoad);
            }
        }
    }
}
