using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryTraining
{
    public partial class Form1 : Form
    {
        public List<int> CallNumList = new List<int>();
        public List<string> ColumnTest = new List<string>();
        public int UserScore;

        public int intCount;
        public string key;
        public string value;


        public Dictionary<string, string> DeweyColumns = new Dictionary<string, string>(); //creation of the dictionary 

        Tree<string> tree = new Tree<string>();

        public string s1 = "\t";
        public string s2 = "\t\t";
        public string line;
        public string file_contents = "";
        public int index;
        public int index3;
        public List<string> temp = new List<string>();
        public List<int> indexList = new List<int>();
        public List<int> indexList3 = new List<int>();
        public List<string> indexList2 = new List<string>();
        public List<string> indexList4 = new List<string>();
        public List<string> indexList5 = new List<string>();
        public List<string> indexList6 = new List<string>();
        public int num = 0;
        public int num3 = 0;
        public int randomCall = 0;      //random level 3 call number 
        public int newRand = 0;
        public int newRand2 = 0;
        public int newRand3 = 0;
        public string strRand = "";
        public List<string> firstCall = new List<string>();     //stores first level call number 
        public List<string> secondCall = new List<string>();    //stores second level call number 
        public List<string> thirdCall = new List<string>();     //stores third level call number 
        public string newstring;
        public string newstring2;
        public string newstring3;
        public string strRand2;
        public string strRand3;
        public string strRand4;
        public Random rand = new Random();
        

        public Form1()
        {          
            InitializeComponent();
            button3.Visible = false;
            button4.Visible = false;
            this.Text = "Library Training!";

            tree.Root = new TreeNode<string>() { Data = "DeweyDecimal" };
            using (StreamReader sr = new StreamReader("DeweyDecimal.txt"))
            {
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    if (!line.Contains(s1))
                        temp.Add(line);
                }
            }       //streamreader that fills the tree with call number level 1 
            tree.Root.Children = new List<TreeNode<string>>
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(0), Parent = tree.Root},
                        new TreeNode<string>() {Data = temp.ElementAt(1), Parent = tree.Root},
                        new TreeNode<string>() {Data = temp.ElementAt(2), Parent = tree.Root},
                        new TreeNode<string>() {Data = temp.ElementAt(3), Parent = tree.Root},
                        new TreeNode<string>() {Data = temp.ElementAt(4), Parent = tree.Root},
                        new TreeNode<string>() {Data = temp.ElementAt(5), Parent = tree.Root},
                        new TreeNode<string>() {Data = temp.ElementAt(6), Parent = tree.Root},
                        new TreeNode<string>() {Data = temp.ElementAt(7), Parent = tree.Root},
                        new TreeNode<string>() {Data = temp.ElementAt(8), Parent = tree.Root},
                        new TreeNode<string>() {Data = temp.ElementAt(9), Parent = tree.Root}
                    };                     //loads the tree 
            temp.Clear();
            using (StreamReader sr = new StreamReader("DeweyDecimal.txt"))
            {
                while (!sr.EndOfStream) //2nd call number 
                {
                    line = sr.ReadLine();
                    if (!line.Contains(s2) && line.Contains(s1))

                        temp.Add(line);
                }
            }       //streamreader that fills tree with call number level 2
            tree.Root.Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(0), Parent = tree.Root.Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(1), Parent = tree.Root.Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(2), Parent = tree.Root.Children[0] }
                    };      //loads the tree 
            tree.Root.Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(3), Parent = tree.Root.Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(4), Parent = tree.Root.Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(5), Parent = tree.Root.Children[1] }
                    };
            tree.Root.Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(6), Parent = tree.Root.Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(7), Parent = tree.Root.Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(8), Parent = tree.Root.Children[2] }
                    };
            tree.Root.Children[3].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(9), Parent = tree.Root.Children[3] },
                        new TreeNode<string>() {Data = temp.ElementAt(10), Parent = tree.Root.Children[3] },
                        new TreeNode<string>() {Data = temp.ElementAt(11), Parent = tree.Root.Children[3] }
                    };
            tree.Root.Children[4].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(12), Parent = tree.Root.Children[4] },
                        new TreeNode<string>() {Data = temp.ElementAt(13), Parent = tree.Root.Children[4] },
                        new TreeNode<string>() {Data = temp.ElementAt(14), Parent = tree.Root.Children[4] }
                    };
            tree.Root.Children[5].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(15), Parent = tree.Root.Children[5] },
                        new TreeNode<string>() {Data = temp.ElementAt(16), Parent = tree.Root.Children[5] },
                        new TreeNode<string>() {Data = temp.ElementAt(17), Parent = tree.Root.Children[5] }
                    };
            tree.Root.Children[6].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(18), Parent = tree.Root.Children[6] },
                        new TreeNode<string>() {Data = temp.ElementAt(19), Parent = tree.Root.Children[6] },
                        new TreeNode<string>() {Data = temp.ElementAt(20), Parent = tree.Root.Children[6] }
                    };
            tree.Root.Children[7].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(21), Parent = tree.Root.Children[7] },
                        new TreeNode<string>() {Data = temp.ElementAt(22), Parent = tree.Root.Children[7] },
                        new TreeNode<string>() {Data = temp.ElementAt(23), Parent = tree.Root.Children[7] }
                    };
            tree.Root.Children[8].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(24), Parent = tree.Root.Children[8] },
                        new TreeNode<string>() {Data = temp.ElementAt(25), Parent = tree.Root.Children[8] },
                        new TreeNode<string>() {Data = temp.ElementAt(26), Parent = tree.Root.Children[8] }
                    };
            tree.Root.Children[9].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(27), Parent = tree.Root.Children[9] },
                        new TreeNode<string>() {Data = temp.ElementAt(28), Parent = tree.Root.Children[9] },
                        new TreeNode<string>() {Data = temp.ElementAt(29), Parent = tree.Root.Children[9] }
                    };
            temp.Clear();
            using (StreamReader sr = new StreamReader("DeweyDecimal.txt"))
            {
                while (!sr.EndOfStream) //3rd call number 
                {
                    line = sr.ReadLine();
                    if (line.Contains(s1) && line.Contains(s2))
                        temp.Add(line);
                }
            }       //streamreader that fills the tree with call number level 3 
            tree.Root.Children[0].Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(0), Parent = tree.Root.Children[0].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(1), Parent = tree.Root.Children[0].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(2), Parent = tree.Root.Children[0].Children[0] }
                    }; //loads the tree 
            tree.Root.Children[0].Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(3), Parent = tree.Root.Children[0].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(4), Parent = tree.Root.Children[0].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(5), Parent = tree.Root.Children[0].Children[1] }
                    };
            tree.Root.Children[0].Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(6), Parent = tree.Root.Children[0].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(7), Parent = tree.Root.Children[0].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(8), Parent = tree.Root.Children[0].Children[2] }
                    };
            using (StreamReader sr = new StreamReader("DeweyDecimal.txt"))
            {
                while (!sr.EndOfStream) //3rd call number 
                {
                    line = sr.ReadLine();
                    if (line.Contains(s1) && line.Contains(s2))
                        temp.Add(line);
                }
            }
            tree.Root.Children[1].Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(9), Parent = tree.Root.Children[1].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(10), Parent = tree.Root.Children[1].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(11), Parent = tree.Root.Children[1].Children[0] }
                    };
            tree.Root.Children[1].Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(12), Parent = tree.Root.Children[1].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(13), Parent = tree.Root.Children[1].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(14), Parent = tree.Root.Children[1].Children[1] }
                    };
            tree.Root.Children[1].Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(15), Parent = tree.Root.Children[1].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(16), Parent = tree.Root.Children[1].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(17), Parent = tree.Root.Children[1].Children[2] }
                    };
            using (StreamReader sr = new StreamReader("DeweyDecimal.txt"))
            {
                while (!sr.EndOfStream) //3rd call number 
                {
                    line = sr.ReadLine();
                    if (line.Contains(s1) && line.Contains(s2))
                        temp.Add(line);
                }
            }
            tree.Root.Children[2].Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(18), Parent = tree.Root.Children[2].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(19), Parent = tree.Root.Children[2].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(20), Parent = tree.Root.Children[2].Children[0] }
                    };
            tree.Root.Children[2].Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(21), Parent = tree.Root.Children[2].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(22), Parent = tree.Root.Children[2].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(23), Parent = tree.Root.Children[2].Children[1] }
                    };
            tree.Root.Children[2].Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(24), Parent = tree.Root.Children[2].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(25), Parent = tree.Root.Children[2].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(26), Parent = tree.Root.Children[2].Children[2] }
                    };
            using (StreamReader sr = new StreamReader("DeweyDecimal.txt"))
            {
                while (!sr.EndOfStream) //3rd call number 
                {
                    line = sr.ReadLine();
                    if (line.Contains(s1) && line.Contains(s2))
                        temp.Add(line);
                }
            }
            tree.Root.Children[3].Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(27), Parent = tree.Root.Children[3].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(28), Parent = tree.Root.Children[3].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(29), Parent = tree.Root.Children[3].Children[0] }
                    };
            tree.Root.Children[3].Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(30), Parent = tree.Root.Children[3].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(31), Parent = tree.Root.Children[3].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(32), Parent = tree.Root.Children[3].Children[1] }
                    };
            tree.Root.Children[3].Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(33), Parent = tree.Root.Children[3].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(34), Parent = tree.Root.Children[3].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(35), Parent = tree.Root.Children[3].Children[2] }
                    };
            using (StreamReader sr = new StreamReader("DeweyDecimal.txt"))
            {
                while (!sr.EndOfStream) //3rd call number 
                {
                    line = sr.ReadLine();
                    if (line.Contains(s1) && line.Contains(s2))
                        temp.Add(line);
                }
            }
            tree.Root.Children[4].Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(36), Parent = tree.Root.Children[4].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(37), Parent = tree.Root.Children[4].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(38), Parent = tree.Root.Children[4].Children[0] }
                    };
            tree.Root.Children[4].Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(39), Parent = tree.Root.Children[4].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(40), Parent = tree.Root.Children[4].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(41), Parent = tree.Root.Children[4].Children[1] }
                    };
            tree.Root.Children[4].Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(42), Parent = tree.Root.Children[4].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(43), Parent = tree.Root.Children[4].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(44), Parent = tree.Root.Children[4].Children[2] }
                    };
            using (StreamReader sr = new StreamReader("DeweyDecimal.txt"))
            {
                while (!sr.EndOfStream) //3rd call number 
                {
                    line = sr.ReadLine();
                    if (line.Contains(s1) && line.Contains(s2))
                        temp.Add(line);
                }
            }
            tree.Root.Children[5].Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(45), Parent = tree.Root.Children[5].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(46), Parent = tree.Root.Children[5].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(47), Parent = tree.Root.Children[5].Children[0] }
                    };
            tree.Root.Children[5].Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(48), Parent = tree.Root.Children[5].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(49), Parent = tree.Root.Children[5].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(50), Parent = tree.Root.Children[5].Children[1] }
                    };
            tree.Root.Children[5].Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(51), Parent = tree.Root.Children[5].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(52), Parent = tree.Root.Children[5].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(53), Parent = tree.Root.Children[5].Children[2] }
                    };
            using (StreamReader sr = new StreamReader("DeweyDecimal.txt"))
            {
                while (!sr.EndOfStream) //3rd call number 
                {
                    line = sr.ReadLine();
                    if (line.Contains(s1) && line.Contains(s2))
                        temp.Add(line);
                }
            }
            tree.Root.Children[6].Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(54), Parent = tree.Root.Children[6].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(55), Parent = tree.Root.Children[6].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(56), Parent = tree.Root.Children[6].Children[0] }
                    };
            tree.Root.Children[6].Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(57), Parent = tree.Root.Children[6].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(58), Parent = tree.Root.Children[6].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(59), Parent = tree.Root.Children[6].Children[1] }
                    };
            tree.Root.Children[6].Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(60), Parent = tree.Root.Children[6].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(61), Parent = tree.Root.Children[6].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(62), Parent = tree.Root.Children[6].Children[2] }
                    };
            using (StreamReader sr = new StreamReader("DeweyDecimal.txt"))
            {
                while (!sr.EndOfStream) //3rd call number 
                {
                    line = sr.ReadLine();
                    if (line.Contains(s1) && line.Contains(s2))
                        temp.Add(line);
                }
            }
            tree.Root.Children[7].Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(63), Parent = tree.Root.Children[7].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(64), Parent = tree.Root.Children[7].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(65), Parent = tree.Root.Children[7].Children[0] }
                    };
            tree.Root.Children[7].Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(66), Parent = tree.Root.Children[7].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(67), Parent = tree.Root.Children[7].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(68), Parent = tree.Root.Children[7].Children[1] }
                    };
            tree.Root.Children[7].Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(69), Parent = tree.Root.Children[7].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(70), Parent = tree.Root.Children[7].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(71), Parent = tree.Root.Children[7].Children[2] }
                    };
            using (StreamReader sr = new StreamReader("DeweyDecimal.txt"))
            {
                while (!sr.EndOfStream) //3rd call number 
                {
                    line = sr.ReadLine();
                    if (line.Contains(s1) && line.Contains(s2))
                        temp.Add(line);
                }
            }
            tree.Root.Children[8].Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(72), Parent = tree.Root.Children[8].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(73), Parent = tree.Root.Children[8].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(74), Parent = tree.Root.Children[8].Children[0] }
                    };
            tree.Root.Children[8].Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(75), Parent = tree.Root.Children[8].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(76), Parent = tree.Root.Children[8].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(77), Parent = tree.Root.Children[8].Children[1] }
                    };
            tree.Root.Children[8].Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(78), Parent = tree.Root.Children[8].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(79), Parent = tree.Root.Children[8].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(80), Parent = tree.Root.Children[8].Children[2] }
                    };
            using (StreamReader sr = new StreamReader("DeweyDecimal.txt"))
            {
                while (!sr.EndOfStream) //3rd call number 
                {
                    line = sr.ReadLine();
                    if (line.Contains(s1) && line.Contains(s2))
                        temp.Add(line);
                }
            }
            tree.Root.Children[9].Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(81), Parent = tree.Root.Children[9].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(82), Parent = tree.Root.Children[9].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(83), Parent = tree.Root.Children[9].Children[0] }
                    };
            tree.Root.Children[9].Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(84), Parent = tree.Root.Children[9].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(85), Parent = tree.Root.Children[9].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(86), Parent = tree.Root.Children[9].Children[1] }
                    };
            tree.Root.Children[9].Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(87), Parent = tree.Root.Children[9].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(88), Parent = tree.Root.Children[9].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(89), Parent = tree.Root.Children[9].Children[2] }
                    };

            for (int i = 0; i < 10; i++)
            {
                indexList.Add(index);
                index++;
            }
            for (int i = 0; i < 3; i++)
            {
                indexList3.Add(index3);
                index3++;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                var rand = new Random();//declaring the use of  a list 

                for (int i = 0; i < 10; i++)
                {
                    listBox1.Items.Add(rand.Next(001, 1000));   // randomly generates 10 call numbers to the listbox  
                }
                foreach (int item in listBox1.Items)   //stores the numbers in the list 
                    CallNumList.Add(item);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Unfortunately you ran into the error: " + exc + " .Please Restart the system.");
            }

        }

        private void btnItemUp_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBox1.SelectedIndex;
                object item = listBox1.SelectedItem;
                if (listBox1.SelectedIndex.Equals(-1))
                    MessageBox.Show("Please select an Item first!");
                else
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    listBox1.Items.Insert(index - 1, item);
                    listBox1.SelectedIndex = index - 1;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Unfortunately you ran into the error: " + exc + " .Please Restart the system.");
            }
        }
        private void btnItemDown_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBox1.SelectedIndex;
                object item = listBox1.SelectedItem;

                if (listBox1.SelectedIndex == -1)
                    MessageBox.Show("Please select an Item first!");
                else
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    listBox1.Items.Insert(index + 1, item);
                    listBox1.SelectedIndex = index + 1;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Unfortunately you ran into the error: " + exc + " .Please Restart the system.");
            }
        }

        private void btnCheckOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int ScoreDecrement = -50;
                int ScoreIncrement = 100;
                CallNumList.Sort();
                List<int> test = new List<int>();
                foreach (int item in listBox1.Items)   //stores the numbers in the list 
                    test.Add(item);

                if (CallNumList.SequenceEqual(test))
                {
                    UserScore = UserScore + ScoreIncrement;
                    lblUserScore.Text = UserScore.ToString();
                    lblUserMessage.Text = "Well Done!!";
                    listBox1.Items.Clear();
                    CallNumList.Clear();
                    test.Clear();
                }
                else
                {
                    UserScore = UserScore + ScoreDecrement;
                    lblUserScore.Text = UserScore.ToString();
                    lblUserMessage.Text = "Try Again :(";
                    listBox1.Items.Clear();
                    CallNumList.Clear();
                    test.Clear();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Unfortunately you ran into the error: " + exc + " .Please Restart the system.");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                intCount++;
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                lblUserScore2.Text = UserScore.ToString();
                Random random = new Random();
                int index;

                DeweyColumns = new Dictionary<string, string>(){  //stores all the dictionary data 
                {"001-099", "Generalities"},
                {"100-199", "Philosophy and Psychology"},
                {"200-299", "Religion"},
                {"300-399", "Social Science"},
                {"400-499", "Languages"},
                {"500-599", "Natural Science"},
                {"600-699", "Applied Science"},
                {"700-799", "Arts and Recreation"},
                {"800-899", "Literature"},
                {"900-999", "Geography and History"},
                {"92 & 920", "Biography and Collective Biography"}
            };


                if (intCount % 2 == 0)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        while (listBox2.Items.Count <= 3 || listBox3.Items.Count <= 6)
                        {
                            index = random.Next(DeweyColumns.Count);

                            KeyValuePair<string, string> pair = DeweyColumns.ElementAt(index);

                            if (listBox2.Items.Count != 4)
                            {

                                listBox2.Items.Add(pair.Key);
                                DeweyColumns.Remove(pair.Key);
                                RandomiseListBox();
                            }
                            if (listBox3.Items.Count != 7)
                            {
                                listBox3.Items.Add(pair.Value);
                                DeweyColumns.Remove(pair.Value);
                                RandomiseListBox2();
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 7; i++)
                    {
                        while (listBox2.Items.Count <= 6 || listBox3.Items.Count <= 3)
                        {
                            index = random.Next(DeweyColumns.Count);

                            KeyValuePair<string, string> pair = DeweyColumns.ElementAt(index);

                            if (listBox2.Items.Count != 7)
                            {

                                listBox2.Items.Add(pair.Key);
                                DeweyColumns.Remove(pair.Key);
                                RandomiseListBox();
                            }
                            if (listBox3.Items.Count != 4)
                            {
                                listBox3.Items.Add(pair.Value);
                                DeweyColumns.Remove(pair.Value);
                                RandomiseListBox2();
                            }
                        }
                    }
                }
                if (listBox2.Items.Count.Equals(0))
                {
                    listBox2.Items.Clear();
                }
                if (listBox3.Items.Count.Equals(0))
                {
                    listBox3.Items.Clear();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Unfortunately you ran into the error: " + exc + " .Please Restart the system.");
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            try
            {
                DeweyColumns = new Dictionary<string, string>(){
                {"001-099", "Generalities"},
                {"100-199", "Philosophy and Psychology"},
                {"200-299", "Religion"},
                {"300-399", "Social Science"},
                {"400-499", "Languages"},
                {"500-599", "Natural Science"},
                {"600-699", "Applied Science"},
                {"700-799", "Arts and Recreation"},
                {"800-899", "Literature"},
                {"900-999", "Geography and History"},
                {"92 & 920", "Biography and Collective Biography"}
            };
                int index = listBox2.SelectedIndex;
                string lb2Item, lb3Item;
                int ScoreDecrement = -10;
                int ScoreIncrement = 20;
                if (listBox2.SelectedIndex.Equals(-1))
                    MessageBox.Show("Please select an Item for column 1 first!");
                if (listBox3.SelectedIndex.Equals(-1))
                    MessageBox.Show("Please select an Item for column 2 first!");
                else
                {
                    lb2Item = listBox2.SelectedItem.ToString();
                    lb3Item = listBox3.SelectedItem.ToString();
                    if (DeweyColumns.ContainsKey(lb2Item.ToString()) && DeweyColumns[lb2Item.ToString()].Equals(lb3Item.ToString()))
                    {
                        lblScoreRemark.Text = "Well Done!!";
                        listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                        listBox3.Items.RemoveAt(listBox3.SelectedIndex);
                        UserScore = UserScore + ScoreIncrement;
                        lblUserScore2.Text = UserScore.ToString();
                    }
                    else
                    {
                        lblScoreRemark.Text = "Try Again !!";
                        UserScore = UserScore + ScoreDecrement;
                        lblUserScore2.Text = UserScore.ToString();

                    }
                    if (listBox2.Items.Count.Equals(0))
                    {
                        listBox2.Items.Clear();
                    }
                    if (listBox3.Items.Count.Equals(0))
                    {
                        listBox3.Items.Clear();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Unfortunately you ran into the error: " + exc + " .Please Restart the system.");
            }
        }
        private Random randomiser = new Random();
        private void RandomiseListBox()
        {
            try
            {
                int count = this.listBox2.Items.Count;
                object item;

                for (int index = 0; index <= count - 2; index++)
                {
                    item = this.listBox2.Items[this.randomiser.Next(index, count)];
                    this.listBox2.Items.Remove(item);
                    this.listBox2.Items.Insert(index, item);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Unfortunately you ran into the error: " + exc + " .Please Restart the system.");
            }
        }
        private void RandomiseListBox2()
        {
            try
            {
                int count = this.listBox3.Items.Count;
                object item;

                for (int index = 0; index <= count - 2; index++)
                {
                    item = this.listBox3.Items[this.randomiser.Next(index, count)];
                    this.listBox3.Items.Remove(item);
                    this.listBox3.Items.Insert(index, item);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Unfortunately you ran into the error: " + exc + " .Please Restart the system.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            tboxDescriptionCall.Text = "";
            num = indexList.ElementAt(randomiser.Next(index));
            num3 = indexList3.ElementAt(randomiser.Next(index3));

            foreach (var node in tree.Root.Children[num].Children[num3].Children) //this gets all the tree data
            {
                lblUserScore3.Text = UserScore.ToString();              
                newstring = node.Data;
                newstring2 = node.Parent.Data.ToString();
                newstring3 = node.Parent.Parent.Data.ToString();
                newstring3 = newstring3.Trim();
                indexList2.Add(newstring);
                indexList5.Add(newstring2);
                indexList4.Add(newstring3);

            }

            randomCall = rand.Next(indexList2.Count);
            string strRand = indexList2[randomCall];
            strRand = strRand.Trim();
            strRand = strRand.Substring(4);
            tboxDescriptionCall.Text = strRand;         //choices the random call number level 3
            listBox4.Items.Add(indexList4.ElementAt(randomCall)); //puts the correct answer in the listbox 

            using (StreamReader sr = new StreamReader("DeweyDecimal.txt")) 
            {
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    if (!line.Contains(s1))
                        thirdCall.Add(line);
                }
            }
            while (!listBox4.Items.Count.Equals(4))         //fills the list box with incorrect answers 
             {
                 newRand = rand.Next(thirdCall.Count);
                 strRand2 = thirdCall[newRand];
                 if (!strRand2.Equals(indexList4.ElementAt(randomCall)) && !listBox4.Items.Contains(strRand2) && !listBox4.Items.Equals(newstring3) && !listBox4.Items.Contains(strRand2))
                 {
                     listBox4.Items.Add(strRand2);
                     strRand2 = "";
                 }
             }   
            listBox4.Sorted = true;
            button1.Visible = true;
            button3.Visible = false;
            button4.Visible = false;

        }
        private void button1_Click_2(object sender, EventArgs e)        //call number level 2 
        {
            if (listBox4.SelectedIndex.Equals(-1))
                MessageBox.Show("Please select an Item first!");
            else
            {
                if (listBox4.SelectedItem.Equals(indexList4.ElementAt(randomCall)))
                {
                    listBox4.Items.Clear();
                    listBox4.Items.Add(indexList5.ElementAt(randomCall)); //puts the correct answer in the listbox 
                    using (StreamReader sr = new StreamReader("DeweyDecimal.txt"))
                    {
                        while (!sr.EndOfStream) 
                        {
                            line = sr.ReadLine();
                            if (!line.Contains(s2) && line.Contains(s1))
                                secondCall.Add(line);
                        }
                    }
                    while (!listBox4.Items.Count.Equals(4))//fills the list box with incorrect answers 
                    {
                        newRand2 = rand.Next(secondCall.Count);
                        strRand3 = secondCall[newRand2];
                        if (!strRand3.Equals(indexList5.ElementAt(randomCall)) && !listBox4.Items.Contains(strRand3) && !listBox4.Items.Equals(newstring3))
                        {
                            listBox4.Items.Add(strRand3);
                            strRand3 = "";
                        }
                    }
                    UserScore = UserScore + 20;
                    lblUserScore3.Text = UserScore.ToString();
                    lblUserScoreDescrip.Text = "Well Done \n +20";
                    button1.Visible = false;
                    button3.Visible = true;
                    button4.Visible = false;
                }
                else if (!listBox4.SelectedItem.Equals(indexList4.ElementAt(randomCall)))
                {
                    lblUserScoreDescrip.Text = "Incorrect \n -10";
                    UserScore = UserScore - 10;
                    lblUserScore3.Text = UserScore.ToString();
                    listBox4.Items.Clear();
                    tboxDescriptionCall.Text = "";
                }                   
            }
        }

        private void button3_Click(object sender, EventArgs e)       //call number level 3 
        {
            if (listBox4.SelectedIndex.Equals(-1))
                MessageBox.Show("Please select an Item first!");
            else
            {
                if (listBox4.SelectedItem.Equals(indexList5.ElementAt(randomCall)))
                {
                    listBox4.Items.Clear();
                    listBox4.Items.Add(indexList2.ElementAt(randomCall)); //puts the correct answer in the listbox 

                    using (StreamReader sr = new StreamReader("DeweyDecimal.txt"))
                    {
                        while (!sr.EndOfStream) //3rd call number 
                        {
                            line = sr.ReadLine();
                            if (line.Contains(s1) && line.Contains(s2))
                                firstCall.Add(line);
                        }
                    }
                    
                    while (!listBox4.Items.Count.Equals(4))//fills the list box with incorrect answers 
                    {
                        newRand3 = rand.Next(firstCall.Count);
                        strRand4 = firstCall[newRand3];
                        if (!listBox4.Items.Contains(strRand4))
                        {
                            listBox4.Items.Add(strRand4);
                            strRand4 = "";
                        }
                    }
                    UserScore = UserScore + 20;
                    lblUserScore3.Text = UserScore.ToString();
                    lblUserScoreDescrip.Text = "Well Done \n +20";
                    button1.Visible = false;
                    button3.Visible = false;
                    button4.Visible = true;
                }
                else if(!listBox4.SelectedItem.Equals(indexList5.ElementAt(randomCall)))
                {
                    lblUserScoreDescrip.Text = "Incorrect \n -10";
                    UserScore = UserScore - 10;
                    lblUserScore3.Text = UserScore.ToString();
                    listBox4.Items.Clear();
                    tboxDescriptionCall.Text = "";
                }
                   
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox4.SelectedIndex.Equals(-1))
                MessageBox.Show("Please select an Item first!");
            else
            {
                if (listBox4.SelectedItem.Equals(indexList2.ElementAt(randomCall))) //checks if answer is correct 
                {
                    listBox4.Items.Clear();
                    tboxDescriptionCall.Text = "Well Done, you have completed the quiz!";
                    lblUserScoreDescrip.Text = "Well Done \n +40";         //gamification feature code 
                    UserScore = UserScore + 40;
                    lblUserScore3.Text = UserScore.ToString();
                    button1.Visible = false;
                    button3.Visible = false;
                    button4.Visible = true;
                }
                else if (!listBox4.SelectedItem.Equals(indexList2.ElementAt(randomCall)))
                {
                    lblUserScoreDescrip.Text = "Incorrect \n -10";
                    UserScore = UserScore - 10;
                    lblUserScore3.Text = UserScore.ToString();
                    listBox4.Items.Clear();
                    tboxDescriptionCall.Text = "";
                }
                    
            }
        }
    }
}