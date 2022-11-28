using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firmaPMS
{

    public partial class Glowny : Form
    {
        public Glowny()
        {
            InitializeComponent();
            OdczytZPliku();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boczny dialog = new boczny();
            dialog.Text = "Dodawanie podgałęzi";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                wiseTree.SelectedNode.Nodes.Add(dialog.nazwa);
            }

        }

        private void ZapisDoPliku()
        {
            List<myNode> lista = new List<myNode>();
            DodajDoListy(wiseTree.Nodes[0], ref lista);
            if (lista.Count == 0)
                return;

            string text = "";
            foreach (myNode elem in lista)
            {
                text += elem.nazwa + " " + elem.rodzic + "\n";
            }
            File.WriteAllText("Brudas.txt",text);
        }

        private void zmienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boczny dialog = new boczny();
            dialog.Text = "Modyfikowanie galezi";
            dialog.nazwa = wiseTree.SelectedNode.Text;
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                wiseTree.SelectedNode.Text = dialog.nazwa;
            }
        }

        private void DodajGalazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boczny dialog = new boczny();
            dialog.Text = "Dodawanie gałęzi";
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                wiseTree.Nodes.Add(dialog.nazwa);
            }
        }

        private void usunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wiseTree.Nodes.Remove(wiseTree.SelectedNode);
        }

        private void ok_Click(object sender, EventArgs e)
        {
            ZapisDoPliku();
            Application.Exit();
        }

             private void DodajDoListy(TreeNode node, ref List<myNode> lista)
        {
            if (node == null)
                return;
            string r, n;
            if (node.Parent == null)
                r = "brak";
            else
                r = node.Parent.Text;
            n = node.Text;

            lista.Add(new myNode(r, n));
            if (node.NextNode != null)
                DodajDoListy(node.NextNode, ref lista);
            if (node.GetNodeCount(true) > 0)
                DodajDoListy(node.FirstNode, ref lista);
        }
        private TreeNode ZnajdzRodzica(TreeNode node, string rodzic)
        {
            TreeNode wynik = null;
            if (node == null)
                return null;
            if (node.Text == rodzic)
                return node;

            if (node.NextNode != null)
                wynik = ZnajdzRodzica(node.NextNode, rodzic);
            if (node.GetNodeCount(true) > 0)
               wynik =  ZnajdzRodzica(node.FirstNode, rodzic);

            return wynik;

        }

        private void zamknij_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Zapisac zmiany przed zamknieciem?",
                "Zamykanie", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                ZapisDoPliku();
                Application.Exit();
            }
            else if (res == DialogResult.No)
            {
                Application.Exit();
            }    
        }
        private void OdczytZPliku()
        {
            wiseTree.Nodes.Clear();
            List<myNode> lista = new List<myNode>();
            if (!File.Exists("Brudas.txt"))
                return;
            
            string[] tab = File.ReadAllLines("Brudas.txt");
            foreach (string elem in tab)
            {
                string[] pom = elem.Split(' ');
                lista.Add(new myNode(pom[1], pom[0]));
            }
            foreach(myNode node in lista)
            {
                if (node.rodzic == "brak")
                    wiseTree.Nodes.Add(new TreeNode(node.nazwa));
                else
                {
                    TreeNode rodzic = ZnajdzRodzica(wiseTree.Nodes[0], node.rodzic);
                    if (rodzic != null)
                        rodzic.Nodes.Add(node.nazwa);
                }
            }
        }
    }
    public class myNode
    {
        public string rodzic;
        public string nazwa;

        public myNode(string rodzic, string nazwa)
        {
            this.rodzic = rodzic;
            this.nazwa = nazwa;
        }
    }

}
