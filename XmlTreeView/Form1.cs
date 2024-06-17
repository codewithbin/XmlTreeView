using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace XmlTreeView
{
    public partial class Form1 : Form
    {
        private OpenFileDialog open = new OpenFileDialog();
        private XmlDocument xmlDoc = new XmlDocument();
        StreamWriter sw = null;
        public Form1()
        {
            InitializeComponent();
            open.Filter = "XML Files (*.xml)|*.xml";
        }
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            textStatus.Text = "";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textPath.Text = open.FileName;
                xmlTree_Load(sender, e);
            }
        }
        private void xmlTree_Load(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            xmlDoc.Load(textPath.Text);
            LoadTreeViewFromXmlDoc(xmlDoc, treeView);
            treeView.ExpandAll();
        }
        private void LoadTreeViewFromXmlDoc(XmlDocument xml_doc, System.Windows.Forms.TreeView trv)
        {
            trv.Nodes.Clear();
            AddTreeViewNode(trv.Nodes, xml_doc.DocumentElement);
        }
        private void AddTreeViewNode(TreeNodeCollection parent_nodes, XmlNode xml_node)
        {
            TreeNode new_node = parent_nodes.Add(xml_node.Name);
            foreach (XmlNode child_node in xml_node.ChildNodes)
            {
                AddTreeViewNode(new_node.Nodes, child_node);
            }
        }

        private void textInput_MouseClick(object sender, MouseEventArgs e)
        {
            textStatus.Text = "";
            if (e.Button == MouseButtons.Left)
            {
                if (textInput.Text == "Enter Text") textInput.Text = "";
            }
        }
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textStatus.Text = "";
            textInput.Text = treeView.SelectedNode.Text;

        }
        private void treeView_Click(object sender, EventArgs e)
        {
            textStatus.Text = "";
            treeView.ExpandAll();
            //textInput.Text = "Enter Text";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseClick += Form1_Load;
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            textStatus.Text = "";
            textInput.Text = "Enter Text";
        }
        private void CollapseNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Nodes.Count > 0)
                {
                    CollapseNodes(node.Nodes);
                }
                node.Collapse();
            }
        }
        private TreeNode FindNode(TreeNodeCollection nodes, string searchText)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Text.Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    return node;
                }
                TreeNode foundNode = FindNode(node.Nodes, searchText);
                if (foundNode != null)
                {
                    return foundNode;
                }
            }
            return null;
        }
        private void buttonFind_Click(object sender, EventArgs e)
        {
            textStatus.Text = "";
            if (textInput.Text == "" || textInput.Text == "Enter Text")
            {
                textStatus.Text = "Please Enter Text";
            }
            else
            {
                CollapseNodes(treeView.Nodes);
                TreeNode foundNode = FindNode(treeView.Nodes, textInput.Text);
                if (foundNode != null)
                {
                    treeView.SelectedNode = foundNode;
                    foundNode.Expand();
                    textStatus.Text = "Node Found";
                }
                else
                {
                    textStatus.Text = "Node Not Found";
                }
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textStatus.Text = "";
            TreeNode node;
            if (textInput.Text == "" || textInput.Text == "Enter Text")
                node = new TreeNode("New Node");
            else node = new TreeNode(textInput.Text);
            try
            {
                treeView.SelectedNode.Nodes.Add(node);
            }
            catch (Exception ex)
            {
                treeView.Nodes.Add(node);
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            textStatus.Text = "";
            if(textInput.Text == "" || textInput.Text == "Enter Text")
            {
                textStatus.Text = "Please Enter Text";
            }
            else
            {
                try
                {
                    treeView.SelectedNode.Text = textInput.Text;
                }
                catch(Exception ex)
                {
                    textStatus.Text = "Please Select Node";
                }
            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            textStatus.Text = "";
            treeView.SelectedNode.Remove();
        }
        public void exportToXml(string filename)
        {
            sw = new StreamWriter(filename, false, System.Text.Encoding.UTF8);
            sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sw.WriteLine("<" + treeView.Nodes[0].Text + ">");

            foreach (TreeNode node in treeView.Nodes)
            {
                int cntTab = 1;
                saveNode(node.Nodes, cntTab);
                sw.WriteLine("\n\t");
            }
            sw.WriteLine("</" + treeView.Nodes[0].Text + ">");

            sw.Close();
            var lines = File.ReadAllLines(filename).Where(line => !String.IsNullOrWhiteSpace(line));
            File.WriteAllLines(filename, lines);

        }
        private void saveNode(TreeNodeCollection tnc, int cntTab)
        {
            sw.WriteLine("\n");
            for (int i = 0; i < cntTab; i++)
            {
                sw.Write("\t");
            }
            foreach (TreeNode node in tnc)
            {
                if (node.Nodes.Count > 0)
                {
                    sw.WriteLine("");
                    sw.Write("<" + node.Text + ">");
                    saveNode(node.Nodes, cntTab+1);
                    /*for (int i = 0; i < cntTab; i++)
                    {
                        sw.Write("\t");
                    }*/
                    sw.WriteLine("</" + node.Text + ">");
                }
                else if (node.Nodes.Count == 0)
                {
                    /*for (int i = 0; i < cntTab; i++)
                    {
                        sw.Write("\t");
                    }*/
                    sw.WriteLine("<" + node.Text + "/>");
                }
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            exportToXml(textPath.Text);
            textStatus.Text = "Saved";
        }
    }
}
