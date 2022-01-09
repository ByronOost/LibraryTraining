using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryTraining;

namespace LibraryTraining
{
    public class TreeNode<T> 
    {
        public T Data { get; set; }
        public TreeNode<T> Parent { get; set; }
        public List<TreeNode<T>> Children { get; set; }
    }
}
