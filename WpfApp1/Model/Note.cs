using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace WpfTaskmanager
{
    public class Note : Task
    {
        public Note() { }

        public Note(string text)
        {
            this.Text = text;
        }
        
        public override string ToString()
        {
            return $"{Topic}\n{Text}";
        }
    }
}
