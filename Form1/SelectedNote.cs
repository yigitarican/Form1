using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class SelectedNote
    {
        public int NoteID { get; set; }
        public string NoteHeader { get; set; }
        public string Notes { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public bool isActive { get; set; }
        public string updatedBy { get; set; }
        public DateTime updateDate { get; set; }
        public string createdBy { get; set; }
        public DateTime createDate { get; set; }
    }
}
