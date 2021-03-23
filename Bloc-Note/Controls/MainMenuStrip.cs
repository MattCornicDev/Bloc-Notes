using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloc_Note.Controls
{
    public class MainMenuStrip : MenuStrip
    {
        private const string NAME = "MainMenuStrip";
        public MainMenuStrip()
        {
            Name = NAME;
            Dock = DockStyle.Top;

            FileDropDownMenu();
            EditDropDownMenu();
            FormatDropDownMenu();
            ViewDropDownMenu();
        }

        public void FileDropDownMenu()
        {
            var fileDropDownMenu = new ToolStripMenuItem("Fichier");

            var newMenu = new ToolStripMenuItem("Nouveau", null, null, Keys.Control | Keys.N);
            var openMenu = new ToolStripMenuItem("Ouvrir...", null, null, Keys.Control | Keys.O);
            var saveMenu = new ToolStripMenuItem("Enregister", null, null, Keys.Control | Keys.S);
            var saveAsMenu = new ToolStripMenuItem("Enregister sous...", null, null, Keys.Control | Keys.Shift | Keys.N);
            var quiteMenu = new ToolStripMenuItem("Quitter", null, null, Keys.Alt | Keys.F4);

            fileDropDownMenu.DropDownItems.AddRange(new ToolStripItem[] { newMenu, openMenu, saveMenu, saveAsMenu, quiteMenu });

            Items.Add(fileDropDownMenu);
        }

        public void EditDropDownMenu()
        {
            var EditDropDownMenu = new ToolStripMenuItem("Edition");

            var cancelMenu = new ToolStripMenuItem("Annuler", null, null, Keys.Control | Keys.Z);
            var restoreMenu = new ToolStripMenuItem("Restaurer...", null, null, Keys.Control | Keys.Y);


            EditDropDownMenu.DropDownItems.AddRange(new ToolStripItem[] { cancelMenu, restoreMenu });

            Items.Add(EditDropDownMenu);
        }

        public void FormatDropDownMenu()
        {
            var FormatDropDownMenu = new ToolStripMenuItem("Format");

            var fontMenu = new ToolStripMenuItem("Police...");


            FormatDropDownMenu.DropDownItems.AddRange(new ToolStripItem[] { fontMenu });

            Items.Add(FormatDropDownMenu);
        }

        public void ViewDropDownMenu()
        {
            var ViewDropDownMenu = new ToolStripMenuItem("Affichage");

            var alwaysOnTopMenu = new ToolStripMenuItem("Toujours devant");

            var zoomDropDownMenu = new ToolStripMenuItem("Zomm");

            var zoomInMenu = new ToolStripMenuItem("Zoom avant", null, null, Keys.Control | Keys.Add);
            var zoomOutMenu = new ToolStripMenuItem("Zoom arrière", null, null, Keys.Control | Keys.Subtract);
            var zoomResetMenu = new ToolStripMenuItem("Restaurer le zoom par défaut", null, null, Keys.Control | Keys.Divide);

            zoomInMenu.ShortcutKeyDisplayString = "Ctrl+Num +";
            zoomOutMenu.ShortcutKeyDisplayString = "Ctrl+Num -";
            zoomResetMenu.ShortcutKeyDisplayString = "Ctrl+Num /";

            zoomDropDownMenu.DropDownItems.AddRange(new ToolStripItem[] { zoomInMenu, zoomOutMenu, zoomResetMenu });

            ViewDropDownMenu.DropDownItems.AddRange(new ToolStripItem[] { alwaysOnTopMenu, zoomDropDownMenu });
            
            Items.Add(ViewDropDownMenu);
        }
    }
}
