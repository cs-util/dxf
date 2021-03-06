using System.Collections.Generic;
using System.Linq;

namespace IxMilia.Dxf.Test
{
    public class TestCodePairBufferReader : IDxfCodePairReader
    {
        public List<DxfCodePair> Pairs { get; }

        public TestCodePairBufferReader(IEnumerable<(int code, object value)> pairs)
            : this(pairs.Select(cp => new DxfCodePair(cp.code, cp.value)))
        {
        }

        public TestCodePairBufferReader(IEnumerable<DxfCodePair> pairs)
        {
            Pairs = pairs.ToList();
        }

        public IEnumerable<DxfCodePair> GetCodePairs() => Pairs;

        public void SetUtf8Reader()
        {
        }
    }
}
