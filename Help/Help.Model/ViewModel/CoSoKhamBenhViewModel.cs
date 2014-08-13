using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help.Model.ViewModel
{
    public class CoSoKhamBenhViewModel
    {
        public CoSoKhamBenh CoSoKham { get; set; }
        public IEnumerable<LoaiCoSoKhamBenh> LoaiCoSoKham { get; set; }
        public IEnumerable<LoaiDieuTri> LoaiDieuTri { get; set; }
    }
}
