using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Models
{
    class MenuItem
    {
        public string Name { get; set; } // abtract property -- khi nao nap data vao thi mới tốn ô nhớ -> thích hợp dùng cho các model - entity - DTO (data transfer object)
        public string MenuPage { get; set; }
        public string Icon { get; set; }
        //indexer - ve tim hieu lai

    }
}
